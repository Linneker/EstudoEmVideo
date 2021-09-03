using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Movie
{
    public class VideoServices : ServiceBase<Video>, IVideoServices
    {

        private IVideoRepository _videoRepository;
        public VideoServices(IVideoRepository videoRepository): base(videoRepository)
        {
            _videoRepository = videoRepository;
        }


        public List<Video> GetVideoByName(string name)
        {
            return _videoRepository.GetVideoByName(name);
        }

        public List<Video> GetVideoByPopularidade(EnumPopularidade enumPopularidade)
        {
            return _videoRepository.GetVideoByPopularidade(enumPopularidade);
        }
        public List<Video> GetVideoByVizualizacao(long vizualizacao)
        {
            return _videoRepository.GetVideoByVizualizacao(vizualizacao);
        }

        public List<Video> GetVideoByVizualizacaoEmNumero(long numeroVizualizador)
        {
            return _videoRepository.GetVideoByVizualizacaoEmNumero(numeroVizualizador);
        }

        public Task<List<Video>> GetVideoByNameAsync(string name)
        {
            return _videoRepository.GetVideoByNameAsync(name);
        }

        public Task<List<Video>> GetVideoByPopularidadeAsync(EnumPopularidade enumPopularidade)
        {
            return _videoRepository.GetVideoByPopularidadeAsync(enumPopularidade);
        }

        public Task<List<Video>> GetVideoByVizualizacaoAsync(long vizualizacao)
        {
            return _videoRepository.GetVideoByVizualizacaoAsync(vizualizacao);
        }

        public Task<List<Video>> GetVideoByVizualizacaoEmNumeroAsync(long numeroVizualizador)
        {
            return _videoRepository.GetVideoByVizualizacaoEmNumeroAsync(numeroVizualizador);
        }

        public List<Video> GetVideosByCategoriaId(Guid categoriaId)
        {
            return _videoRepository.GetVideosByCategoriaId(categoriaId);
        }
    }
}
