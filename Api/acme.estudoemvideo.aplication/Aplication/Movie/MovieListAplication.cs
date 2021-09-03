using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Movie
{
    public class MovieListAplication : ApplicationBase<MovieList>, IMovieListAplication
    {
        private IMovieListServices _movieListServices;
        public MovieListAplication(IMovieListServices movieListRepository):base(movieListRepository)
        {
            _movieListServices = movieListRepository;
        }

        public List<MovieList> GetMovieListByName(string nome)
        {
            return _movieListServices.GetMovieListByName(nome);
        }
        public Task<List<MovieList>> GetMovieListByNameAsync(string nome)
        {
            return _movieListServices.GetMovieListByNameAsync(nome);
        }
    }
}
