using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Seguranca.Site
{
    public class PermissaoRepository : RepositoryBase<Permissao>, IPermissaoRepository
    {
        public PermissaoRepository(Context db) : base(db)
        {
        }

        public Permissao GetPermissaoByNome(string nome)
        {
            var query = (from permissao in _db.Permissoes
                         where permissao.Nome == nome
                         select permissao).First();
            return query;
        }
    }
}
