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
    public class CategoriaVideoRepository : RepositoryBase<CategoriaVideo>, ICategoriaVideoRepository
    {
        public CategoriaVideoRepository(Context db) : base(db)
        {
        }

        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime dataInicial, DateTime dataFinal)
        {
            var query = (from catVideo in _db.CategoriasVideos
                         where catVideo.DataCadastro >= dataInicial && catVideo.DataCadastro <= dataFinal
                         select catVideo).AsNoTracking().ToList();
            return query;
        }
        public Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime dataInicial, DateTime dataFinal)
        {
            var query = (from catVideo in _db.CategoriasVideos
                         where catVideo.DataCadastro >= dataInicial && catVideo.DataCadastro <= dataFinal
                         select catVideo).AsNoTracking().ToListAsync();
            return query;
        }

        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime data)
        {
            var query = (from catVideo in _db.CategoriasVideos
                         where catVideo.DataCadastro == data
                         select catVideo).AsNoTracking().ToList();
            return query;
        }
        public Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime data)
        {
            var query = (from catVideo in _db.CategoriasVideos
                         where catVideo.DataCadastro == data
                         select catVideo).AsNoTracking().ToListAsync();
            return query;
        }
    }
}
