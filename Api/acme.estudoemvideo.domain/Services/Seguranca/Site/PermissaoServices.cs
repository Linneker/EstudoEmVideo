using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Seguranca.Site
{
    public class PermissaoServices : ServiceBase<Permissao>, IPermissaoServices
    {
        private readonly IPermissaoRepository _permissaoRepository;

        public PermissaoServices(IPermissaoRepository permissaoRepository):base(permissaoRepository)
        {
            _permissaoRepository = permissaoRepository;
        }

        public Permissao GetPermissaoByNome(string nome)
        {
            return _permissaoRepository.GetPermissaoByNome(nome);
        }
    }
}
