using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Movie
{
    public interface IMovieListRepository : IRepositoryBase<MovieList>
    {
        List<MovieList> GetMovieListByName(string nome);

        Task<List<MovieList>> GetMovieListByNameAsync(string nome);
    }
}
