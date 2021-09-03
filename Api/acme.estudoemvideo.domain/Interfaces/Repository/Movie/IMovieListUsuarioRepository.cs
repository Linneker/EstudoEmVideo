using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Movie
{
    public interface IMovieListUsuarioRepository : IRepositoryBase<MovieListUsuario>
    {
        MovieListUsuario GetMovieListUsuarioByIdAndDownload(Guid id, bool download);
        MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(Guid idMovieList, Guid idUsuario, bool download);
        List<MovieListUsuario> GetMovieListUsuarioByDownload(bool download);
        Task<List<MovieListUsuario>> GetMovieListUsuarioByDownloadAsync(bool download);

        MovieListUsuario GetMovieListUsuarioByIdAndFavorito(Guid id, bool favorito);
        MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(Guid idMovieList, Guid idUsuario, bool favorito);
        List<MovieListUsuario> GetMovieListUsuarioByFavorito(bool favorito);
        Task<List<MovieListUsuario>> GetMovieListUsuarioByFavoritoAsync(bool favorito);

        List<MovieListUsuario> GetMovieListUsuarioByDataCriacao(DateTime dataCriacao);
        Task<List<MovieListUsuario>> GetMovieListUsuarioByDataCriacaoAsync(DateTime dataCriacao);
        MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuario(Guid idMovieList, Guid idUsuario);
    }
}
