using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Movie
{
    public class MovieListUsuarioServices : ServiceBase<MovieListUsuario>, IMovieListUsuarioServices
    {
        private IMovieListUsuarioRepository _movieListUsuarioRepository;
        public MovieListUsuarioServices(IMovieListUsuarioRepository  movieListUsuarioRepository):base(movieListUsuarioRepository)
        {
            _movieListUsuarioRepository = movieListUsuarioRepository;
        }
        public List<MovieListUsuario> GetMovieListUsuarioByDataCriacao(DateTime dataCriacao)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByDataCriacao(dataCriacao);
        }
        public Task<List<MovieListUsuario>> GetMovieListUsuarioByDataCriacaoAsync(DateTime dataCriacao)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByDataCriacaoAsync(dataCriacao);
        }
        public List<MovieListUsuario> GetMovieListUsuarioByDownload(bool download)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByDownload(download);
        }
        public Task<List<MovieListUsuario>> GetMovieListUsuarioByDownloadAsync(bool download)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByDownloadAsync(download);
        }
        public List<MovieListUsuario> GetMovieListUsuarioByFavorito(bool favorito)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByFavorito(favorito);
        }
        public Task<List<MovieListUsuario>> GetMovieListUsuarioByFavoritoAsync(bool favorito)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByFavoritoAsync(favorito);
        }

        public MovieListUsuario GetMovieListUsuarioByIdAndDownload(Guid id, bool download)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByIdAndDownload(id, download);
        }

        public MovieListUsuario GetMovieListUsuarioByIdAndFavorito(Guid id, bool favorito)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByIdAndFavorito(id, favorito);
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(Guid idMovieList, Guid idUsuario, bool download)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(idMovieList, idUsuario, download);
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(Guid idMovieList, Guid idUsuario, bool favorito)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(idMovieList, idUsuario, favorito);
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuario(Guid idUsuario, Guid idMovieList)
        {
            return _movieListUsuarioRepository.GetMovieListUsuarioByIdMovieListAndIdUsuario(idMovieList, idUsuario);
        }
    }
}
