using acme.estudoemvideo.aplication.Interfaces.Movie.Util;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Movie.Util;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Movie.Util
{
    public class CategoriaAplication : ApplicationBase<Categoria>, ICategoriaAplication
    {
        private readonly ICategoriaServices _categoriaRepository;
        public CategoriaAplication(ICategoriaServices categoriaRepository):base (categoriaRepository)
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
