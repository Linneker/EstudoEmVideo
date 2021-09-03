using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Movie
{
    public class MovieListUsuarioAplication : ApplicationBase<MovieListUsuario>, IMovieListUsuarioAplication
    {
        private IMovieListUsuarioServices _movieListUsuarioServices;
        public MovieListUsuarioAplication(IMovieListUsuarioServices movieListUsuarioRepository):base(movieListUsuarioRepository)
        {
            _movieListUsuarioServices = movieListUsuarioRepository;
        }

        public List<MovieListUsuario> GetMovieListUsuarioByDataCriacao(DateTime dataCriacao)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByDataCriacao(dataCriacao);
        }

        public List<MovieListUsuario> GetMovieListUsuarioByDownload(bool download)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByDownload(download);
        }

        public List<MovieListUsuario> GetMovieListUsuarioByFavorito(bool favorito)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByFavorito(favorito);
        }

        public Task<List<MovieListUsuario>> GetMovieListUsuarioByDataCriacaoAsync(DateTime dataCriacao)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByDataCriacaoAsync(dataCriacao);
        }

        public Task<List<MovieListUsuario>> GetMovieListUsuarioByDownloadAsync(bool download)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByDownloadAsync(download);
        }

        public Task<List<MovieListUsuario>> GetMovieListUsuarioByFavoritoAsync(bool favorito)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByFavoritoAsync(favorito);
        }

        public MovieListUsuario GetMovieListUsuarioByIdAndDownload(Guid id, bool download)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByIdAndDownload(id, download);
        }

        public MovieListUsuario GetMovieListUsuarioByIdAndFavorito(Guid id, bool favorito)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByIdAndFavorito(id, favorito);
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(Guid idMovieList, Guid idUsuario, bool download)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(idMovieList, idUsuario, download);
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(Guid idMovieList, Guid idUsuario, bool favorito)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(idMovieList, idUsuario, favorito);
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuario(Guid idUsuario, Guid idMovieList)
        {
            return _movieListUsuarioServices.GetMovieListUsuarioByIdMovieListAndIdUsuario(idMovieList, idUsuario);
        }
    }
}
