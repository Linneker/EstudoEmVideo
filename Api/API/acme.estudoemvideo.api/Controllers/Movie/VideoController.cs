using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Movie;
using acme.estudoemvideo.util.ViewModel.Seguranca;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Http.Features;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace acme.estudoemvideo.api.Controllers.Movie
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class VideoController : LayoutBaseController<Video,VideoViewModel>
    {
        private readonly IVideoAplication _aplication;
        private const string NOME_METODO = "VÍDEO";
        private readonly IMapper _mapper;
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".mp4", ".zip" };
        private static readonly FormOptions _defaultFormOptions = new FormOptions();
        private IWebHostEnvironment _appEnvironment;
        private string _targetFilePath = "";

        public VideoController(IVideoAplication videoAplication, IMapper mapper) :base(videoAplication, mapper,NOME_METODO)
        {
            _aplication = videoAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVideoByName/{name}")]
        public List<Video> GetVideoByName(string name)
        {
            var retorno = _aplication.GetVideoByName(name);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVideoByPopularidade/{enumPopularidade}")]
        public List<Video> GetVideoByPopularidade(EnumPopularidade enumPopularidade)
        {
            var retorno = _aplication.GetVideoByPopularidade(enumPopularidade);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVideoByVizualizacao/{vizualizacao}")]
        public List<Video> GetVideoByVizualizacao(long vizualizacao)
        {
            var retorno = _aplication.GetVideoByVizualizacao(vizualizacao);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVideoByVizualizacaoEmNumero/{numeroVizualizador}")]
        public List<Video> GetVideoByVizualizacaoEmNumero(long numeroVizualizador)
        {
            var retorno = _aplication.GetVideoByVizualizacaoEmNumero(numeroVizualizador);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVideosByCategoriaId/{categoriaId}")]
        public List<Video> GetVideosByCategoriaId(Guid categoriaId)
        {
            var retorno = _aplication.GetVideosByCategoriaId(categoriaId);
            return retorno;
        }

        [HttpPost("UploadPhysical")]
        [DisableFormValueModelBinding]
        [AllowAnonymous]
        public async Task<RespostaPadraoModels> UploadPhysical()
        {
            string nomeArquivo = Request.Headers.Where(t => t.Key.Contains("nome")).FirstOrDefault().Value.FirstOrDefault();
            string descricaoVideo = Request.Headers.Where(t => t.Key.Contains("descicaovideo")).FirstOrDefault().Value.FirstOrDefault();

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
                        _targetFilePath = $"{caminhoWebRoot}\\arquivo\\video\\";
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
                            resposta = new RespostaPadraoModels(EnumHttp.SUCESSO, "Upload realizado com Sucesso!",
                            $"{{'NomeArquivo': '{Path.Combine(_targetFilePath, trustedFileNameForFileStorage)}', 'Extensao': '{ext}'}}",
                            EnumLog.SUCESS.ToString(), new List<Notification>());
                            Video video = new Video
                            {
                                Descricao = descricaoVideo,
                                Nome = nomeArquivo.Replace("mp4", ""),
                                NomeArquivo = nomeArquivo,
                                Caminho = _targetFilePath,
                                PopularidadeEmNumero = 2.5M,
                                Visualizacao = 0L,
                                EnumPopularidade = EnumPopularidade.Regular
                            };
                            _aplication.Add(video, NOME_METODO);

                            //_logger.LogInformation(
                            //    "Uploaded file '{TrustedFileNameForDisplay}' saved to " +
                            //    "'{TargetFilePath}' as {TrustedFileNameForFileStorage}",
                            //    trustedFileNameForDisplay, _targetFilePath,
                            //    trustedFileNameForFileStorage);
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



    }
}