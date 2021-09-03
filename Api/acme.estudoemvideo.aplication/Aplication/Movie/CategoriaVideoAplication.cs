using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Movie
{
    public class CategoriaVideoAplication : ApplicationBase<CategoriaVideo>, ICategoriaVideoAplication
    {
        private ICategoriaVideoServices _categoriaVideoServices;
        public CategoriaVideoAplication(ICategoriaVideoServices servicesBase) : base(servicesBase)
        {
            _categoriaVideoServices = servicesBase;
        }
        public Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime dataInicial, DateTime dataFinal)
        {
            return _categoriaVideoServices.GetCategoriaVideoByDateAsync(dataInicial, dataFinal);
        }

        public Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime data)
        {
            return _categoriaVideoServices.GetCategoriaVideoByDateAsync(data);
        }
        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime dataInicial, DateTime dataFinal)
        {
            return _categoriaVideoServices.GetCategoriaVideoByDate(dataInicial, dataFinal);
        }

        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime data)
        {
            return _categoriaVideoServices.GetCategoriaVideoByDate(data);
        }
    }
}
