using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.User
{
    public class PermissaoAplication : ApplicationBase<Permissao>, IPermissaoAplication
    {
        private readonly IPermissaoServices _permissaoRepository;

        public PermissaoAplication(IPermissaoServices permissaoRepository):base(permissaoRepository)
        {
            _permissaoRepository = permissaoRepository;
        }

        public Permissao GetPermissaoByNome(string nome)
        {
            return _permissaoRepository.GetPermissaoByNome(nome);
        }
    }
}
