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
    public class VideoMovieListRepository : RepositoryBase<VideoMovieList>, IVideoMovieListRepository
    {
        public VideoMovieListRepository(Context db) : base(db)
        {
        }

        public List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataInicial, DateTime dataFinal)
        {
            var query = (from vMl in _db.VideoMovieLists
                         where vMl.DataLigacao >= dataInicial && vMl.DataLigacao <= dataFinal
                         select vMl).AsNoTracking().ToList();
            return query;
        }

        public List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataLancamento)
        {
            var query = (from vMl in _db.VideoMovieLists
                         where vMl.DataLigacao == dataLancamento
                         select vMl).AsNoTracking().ToList();
            return query;
        }

        public Task<List<VideoMovieList>> GetMovieListByDataLacamentoAsync(DateTime dataInicial, DateTime dataFinal)
        {
            var query = (from vMl in _db.VideoMovieLists
                         where vMl.DataLigacao >= dataInicial && vMl.DataLigacao <= dataFinal
                         select vMl).AsNoTracking().ToListAsync();
            return query;
        }

        public Task<List<VideoMovieList>> GetMovieListByDataLacamentoAsync(DateTime dataLancamento)
        {
            var query = (from vMl in _db.VideoMovieLists
                         where vMl.DataLigacao == dataLancamento
                         select vMl).AsNoTracking().ToListAsync();
            return query;
        }
    }
}
