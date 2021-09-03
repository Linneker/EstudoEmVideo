using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Movie
{
    public class CategoriaVideoServices : ServiceBase<CategoriaVideo>, ICategoriaVideoServices
    {
        private ICategoriaVideoRepository _categoriaVideoRepository;
        public CategoriaVideoServices(ICategoriaVideoRepository repositoryBase) : base(repositoryBase)
        {
            _categoriaVideoRepository = repositoryBase;
        }

        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime dataInicial, DateTime dataFinal)
        {
            return _categoriaVideoRepository.GetCategoriaVideoByDate(dataInicial, dataFinal);
        }

        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime data)
        {
            return _categoriaVideoRepository.GetCategoriaVideoByDate(data);
        }

        public Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime dataInicial, DateTime dataFinal)
        {
            return _categoriaVideoRepository.GetCategoriaVideoByDateAsync(dataInicial, dataFinal);
        }

        public Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime data)
        {
            return _categoriaVideoRepository.GetCategoriaVideoByDateAsync(data);
        }
    }
}
