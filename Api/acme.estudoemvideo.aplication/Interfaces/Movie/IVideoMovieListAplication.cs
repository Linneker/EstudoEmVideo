using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Movie
{
    public interface IVideoMovieListAplication : IApplicationBase<VideoMovieList>
    {
        List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataInicial, DateTime dataFinal);
        List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataLancamento);
        Task<List<VideoMovieList>> GetMovieListByDataLacamentoAsync(DateTime dataInicial, DateTime dataFinal);
        Task<List<VideoMovieList>> GetMovieListByDataLacamentoAsync(DateTime dataLancamento);

    }
}
