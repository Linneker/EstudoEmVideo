using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Movie;
using acme.estudoemvideo.util.ViewModel.Movie.Util;
using acme.estudoemvideo.util.ViewModel.Seguranca;
using acme.estudoemvideo.util.ViewModel.Util;
using acme.estudoemvideo.web.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Movie
{
    public class VideoController : LayoutBaseController<Video, VideoViewModel>
    {
        private readonly IMenuApplication _menuApplication;
        private readonly IVideoAplication _aplication;
        private const string NOME_METODO = "Video";
        private const string CAMINHO_PADRAO = "/Video";
        private readonly IMapper _mapper;
        private IWebHostEnvironment _appEnvironment;
        private readonly ILogger<VideoController> _logger;
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".mp4", ".zip" };
        private string _targetFilePath = "";
        private readonly ICategoriaVideoAplication _categoriaVideoAplication;
        private static readonly FormOptions _defaultFormOptions = new FormOptions();
        public VideoController(IVideoAplication aplication,
      IMapper mapper, IWebHostEnvironment env,
      ILogger<VideoController> logger, 
      IMenuApplication menuApplication,
      ICategoriaVideoAplication categoriaVideoAplication) : base(aplication, NOME_METODO, CAMINHO_PADRAO, menuApplication, mapper)
        {
            _aplication = aplication;
            _menuApplication = menuApplication;
            _mapper = mapper;
            _appEnvironment = env;
            _logger = logger;
            _categoriaVideoAplication = categoriaVideoAplication;
            _fileSizeLimit = 20000000097152;

        }


        public override IActionResult Index()
        {
            
            var video = _aplication.GetAll();
            return View(_mapper.Map<List<VideoViewModel>>(video));
        }

        [HttpPost]
        [DisableFormValueModelBinding]
        [AllowAnonymous]
        public async Task<RespostaPadraoModels> UploadPhysical()
        {
            string nomeArquivo = Request.Headers.Where(t => t.Key.Contains("nome")).FirstOrDefault().Value.FirstOrDefault();
            string descricaoVideo = Request.Headers.Where(t => t.Key.Contains("descicaovideo")).FirstOrDefault().Value.FirstOrDefault();
            string categoriaId= Request.Headers.Where(t => t.Key.Contains("categoriaidvideo")).FirstOrDefault().Value.FirstOrDefault();

            RespostaPadraoModels resposta = null;
            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
            {
                ModelState.AddModelError("Arquivo",
                    $"A requisição não pode ser processada (Erro 1).");
                // Log error
                List<Notification> notifications = new List<Notification> { new Notification("122", $"JsonDoProblema: {JsonConvert.SerializeObject(ModelState)}") };
                resposta = new RespostaPadraoModels(EnumHttp.ERRO_SERVIDOR, "Upload não realizado!",
                   "Erro", EnumLog.ERROR.ToString(), notifications);
                this.ModelState.AddModelError("1001", "Upload não realizado");
                return resposta;
            }

            var boundary = MultipartRequestHelper.GetBoundary(
                MediaTypeHeaderValue.Parse(Request.ContentType),
                _defaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();

            while (section != null)
            {
                var hasContentDispositionHeader =
                    ContentDispositionHeaderValue.TryParse(
                        section.ContentDisposition, out var contentDisposition);

                if (hasContentDispositionHeader)
                {
                    // This check assumes that there's a file
                    // present without form data. If form data
                    // is present, this method immediately fails
                    // and returns the model error.
                    if (!MultipartRequestHelper
                        .HasFileContentDisposition(contentDisposition))
                    {
                        ModelState.AddModelError("File",
                            $"The request couldn't be processed (Error 2).");
                        // Log error
                        List<Notification> notifications = new List<Notification> { new Notification("122", $"JsonDoProblema: {JsonConvert.SerializeObject(ModelState)}") };
                        resposta = new RespostaPadraoModels(EnumHttp.ERRO_SERVIDOR, "Upload não realizado!",
                           "Erro", EnumLog.ERROR.ToString(), notifications);

                        return resposta;
                    }
                    else
                    {
                        // Don't trust the file name sent by the client. To display
                        // the file name, HTML-encode the value.
                        var trustedFileNameForDisplay = WebUtility.HtmlEncode(
                                contentDisposition.FileName.Value is null ? "1" : contentDisposition.FileName.Value);
                        var trustedFileNameForFileStorage = nomeArquivo;

                        // **WARNING!**
                        // In the following example, the file is saved without
                        // scanning the file's contents. In most production
                        // scenarios, an anti-virus/anti-malware scanner API
                        // is used on the file before making the file available
                        // for download or for use by other systems. 
                        // For more information, see the topic that accompanies 
                        // this sample.

                        byte[] streamedFileContent = await FileHelpers.ProcessStreamedFile(
                            section, contentDisposition, ModelState,
                            _permittedExtensions, _fileSizeLimit);

                        if (!ModelState.IsValid)
                        {
                            List<Notification> notifications = new List<Notification> { new Notification("122", $"JsonDoProblema: {JsonConvert.SerializeObject(ModelState)}") };
                            resposta = new RespostaPadraoModels(EnumHttp.ERRO_SERVIDOR, "Upload não realizado!",
                               "Erro", EnumLog.ERROR.ToString(), notifications);
                            return resposta;
                        }
                        string caminhoWebRoot = _appEnvironment.WebRootPath;
                        _targetFilePath = $"C:/xampp/htdocs/videos/";
                        var ext = Path.GetExtension(contentDisposition.FileName.Value).ToLowerInvariant();

                        using (var targetStream = System.IO.File.Create(
                            Path.Combine(_targetFilePath, trustedFileNameForFileStorage)))
                        {
                            try
                            {
                                await targetStream.WriteAsync(streamedFileContent);
                            }
                            catch (Exception e)
                            {

                            }
                            List<CategoriaVideo> categoriasVideos = new List<CategoriaVideo>();
                            categoriasVideos.Add(new CategoriaVideo { CategoriaId = Guid.Parse(categoriaId) });
                            resposta = new RespostaPadraoModels(EnumHttp.SUCESSO, "Upload realizado com Sucesso!",
                            $"{{'NomeArquivo': '{Path.Combine(_targetFilePath, trustedFileNameForFileStorage)}', 'Extensao': '{ext}'}}",
                            EnumLog.SUCESS.ToString(), new List<Notification>());
                            Video video = new Video
                            {
                                Descricao = descricaoVideo,
                                Nome = nomeArquivo.Replace("mp4", ""),
                                NomeArquivo = nomeArquivo,
                                Caminho = "http://192.168.18.65:8081/videos/",
                                PopularidadeEmNumero = 2.5M,
                                Visualizacao = 0L,
                                EnumPopularidade = EnumPopularidade.Regular,
                                CategoriasVideos = categoriasVideos
                            };
                            _aplication.Add(video, NOME_METODO);

                            _logger.LogInformation(
                                "Uploaded file '{TrustedFileNameForDisplay}' saved to " +
                                "'{TargetFilePath}' as {TrustedFileNameForFileStorage}",
                                trustedFileNameForDisplay, _targetFilePath,
                                trustedFileNameForFileStorage);
                        }
                        //if (ext.Equals(".zip"))
                        //{
                        //    UploadZip($"{_targetFilePath}{contentDisposition.FileName.Value}",  _targetFilePath, contentDisposition.FileName.Value);
                        //}
                    }
                }

                // Drain any remaining section body that hasn't been consumed and
                // read the headers for the next section.
                section = await reader.ReadNextSectionAsync();
            }

            return resposta;
        }


        private static Encoding GetEncoding(MultipartSection section)
        {
            var hasMediaTypeHeader =
                MediaTypeHeaderValue.TryParse(section.ContentType, out var mediaType);

            // UTF-7 is insecure and shouldn't be honored. UTF-8 succeeds in 
            // most cases.
            if (!hasMediaTypeHeader || Encoding.UTF7.Equals(mediaType.Encoding))
            {
                return Encoding.UTF8;
            }

            return mediaType.Encoding;
        }

        public IActionResult Player(Guid id)
        {
            Video video = _aplication.GetById(id);
            VideoMovieListViewModel videoViewModel = new VideoMovieListViewModel();
            videoViewModel.Video = new VideoViewModel
            {
                NomeArquivo = video.NomeArquivo,
                Nome = video.Nome
            };
            return View("Player", videoViewModel);
        }


    }
}
