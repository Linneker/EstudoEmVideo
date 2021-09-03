using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Movie
{
    public class MovieListServices : ServiceBase<MovieList>, IMovieListServices
    {
        private IMovieListRepository _movieListRepository;
        public MovieListServices(IMovieListRepository movieListRepository):base(movieListRepository)
        {
            _movieListRepository = movieListRepository;
        }

        public List<MovieList> GetMovieListByName(string nome)
        {
            return _movieListRepository.GetMovieListByName(nome);
        }

        public Task<List<MovieList>> GetMovieListByNameAsync(string nome)
        {
            return _movieListRepository.GetMovieListByNameAsync(nome);
        }
    }
}
