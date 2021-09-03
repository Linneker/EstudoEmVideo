using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie.Util;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Movie.Util
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(Context db) : base(db)
        {
        }

        public Categoria GetCategoriaByNome(string nome)
        {
            var query = (from ctg in _db.Categorias
                         where ctg.Nome == nome
                         select ctg).AsNoTracking().First<Categoria>();
            return query;
        }

        public Categoria GetCategoriaByTipo(EnumTipoCategoria tipoCategoria)
        {
            var query = (from ctg in _db.Categorias
                         where ctg.Tipo == tipoCategoria
                         select ctg).AsNoTracking().First<Categoria>();
            return query;
        }
    }
}
