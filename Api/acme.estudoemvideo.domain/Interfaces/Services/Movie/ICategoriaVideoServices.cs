using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.Movie
{
    public interface ICategoriaVideoServices : IServicesBase<CategoriaVideo>
    {
        List<CategoriaVideo> GetCategoriaVideoByDate(DateTime dataInicial, DateTime dataFinal);
        List<CategoriaVideo> GetCategoriaVideoByDate(DateTime data);

        Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime dataInicial, DateTime dataFinal);
        Task<List<CategoriaVideo>> GetCategoriaVideoByDateAsync(DateTime data);
    }
}