using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Movie
{
    public class VideoMovieListAplication : ApplicationBase<VideoMovieList>, IVideoMovieListAplication
    {
        private IVideoMovieListServices _videoMovieListRepository;
        public VideoMovieListAplication(IVideoMovieListServices videoMovieListRepository):base(videoMovieListRepository)
        {
            _videoMovieListRepository = videoMovieListRepository;
        }
        public List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataInicial, DateTime dataFinal)
        {
            return _videoMovieListRepository.GetMovieListByDataLacamento(dataInicial, dataFinal);
        }

        public List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataLancamento)
        {
            return _videoMovieListRepository.GetMovieListByDataLacamento(dataLancamento);
        }
        public Task<List<VideoMovieList>> GetMovieListByDataLacamentoAsync(DateTime dataInicial, DateTime dataFinal)
        {
            return _videoMovieListRepository.GetMovieListByDataLacamentoAsync(dataInicial, dataFinal);
        }

        public Task<List<VideoMovieList>> GetMovieListByDataLacamentoAsync(DateTime dataLancamento)
        {
            return _videoMovieListRepository.GetMovieListByDataLacamentoAsync(dataLancamento);
        }
    }
}
