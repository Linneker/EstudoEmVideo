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
    public class MovieListRepository : RepositoryBase<MovieList>, IMovieListRepository
    {
        public MovieListRepository(Context db) : base(db)
        {
        }

        public List<MovieList> GetMovieListByName(string nome)
        {
            var query = (from ml in _db.MovieLists
                         where ml.NomeLista == nome
                         select ml).AsNoTracking().ToList();
            return query;
        }

        public Task<List<MovieList>> GetMovieListByNameAsync(string nome)
        {
            var query = (from ml in _db.MovieLists
                         where ml.NomeLista == nome
                         select ml).AsNoTracking().ToListAsync();
            return query;
        }
    }
}
