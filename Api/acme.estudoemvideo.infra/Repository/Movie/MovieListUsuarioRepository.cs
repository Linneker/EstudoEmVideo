using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Movie
{
    public class MovieListUsuarioRepository : RepositoryBase<MovieListUsuario>, IMovieListUsuarioRepository
    {
        public MovieListUsuarioRepository(Context db) : base(db)
        {
        }

        public List<MovieListUsuario> GetMovieListUsuarioByDataCriacao(DateTime dataCriacao)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.DataCriacao == dataCriacao
                         select ml).AsNoTracking().ToList();
            return query;
        }

        public Task<List<MovieListUsuario>> GetMovieListUsuarioByDataCriacaoAsync(DateTime dataCriacao)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.DataCriacao == dataCriacao
                         select ml).AsNoTracking().ToListAsync();
            return query;
        }

        public List<MovieListUsuario> GetMovieListUsuarioByDownload(bool download)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.Download == download
                         select ml).AsNoTracking().ToList();
            return query;
        }

        public Task<List<MovieListUsuario>> GetMovieListUsuarioByDownloadAsync(bool download)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.Download == download
                         select ml).AsNoTracking().ToListAsync();
            return query;
        }

        public List<MovieListUsuario> GetMovieListUsuarioByFavorito(bool favorito)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.Favorito == favorito
                         select ml).AsNoTracking().ToList();
            return query;
        }

        public Task<List<MovieListUsuario>> GetMovieListUsuarioByFavoritoAsync(bool favorito)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.Favorito == favorito
                         select ml).AsNoTracking().ToListAsync();
            return query;
        }

        public MovieListUsuario GetMovieListUsuarioByIdAndDownload(Guid id, bool download)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.Id == id && ml.Download == download
                         select ml).AsNoTracking().First();
            return query;
        }

        public MovieListUsuario GetMovieListUsuarioByIdAndFavorito(Guid id, bool favorito)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.Id == id && ml.Favorito == favorito
                         select ml).AsNoTracking().First();
            return query;
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuario(Guid idMovieList, Guid idUsuario)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.MovieList.Id == idMovieList && ml.Usuario.Id == idUsuario
                         select ml).AsNoTracking().First();
            return query;
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(Guid idMovieList, Guid idUsuario, bool download)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.MovieList.Id == idMovieList && ml.Usuario.Id == idUsuario && ml.Download == download
                         select ml).AsNoTracking().First();
            return query;
        }

        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(Guid idMovieList, Guid idUsuario, bool favorito)
        {
            var query = (from ml in _db.MovieListUsuarios
                         where ml.MovieList.Id == idMovieList && ml.Usuario.Id == idUsuario && ml.Favorito == favorito
                         select ml).AsNoTracking().First();
            return query;
        }


    }
}
