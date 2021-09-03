using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Movie.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Movie.Util
{
    public class CategoriaServices : ServiceBase<Categoria>, ICategoriaServices
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaServices(ICategoriaRepository categoriaRepository):base (categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public Categoria GetCategoriaByNome(string nome)
        {
            return _categoriaRepository.GetCategoriaByNome(nome);
        }

        public Categoria GetCategoriaByTipo(EnumTipoCategoria tipoCategoria)
        {
            return _categoriaRepository.GetCategoriaByTipo(tipoCategoria);
        }
    }
}
