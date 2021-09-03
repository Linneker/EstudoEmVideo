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
    public class PermissaoContaServices : ServiceBase<PermissaoConta>,IPermissaoContaServices
    {
        private readonly IPermissaoContaRepository _permissaoContaRepository;
        public PermissaoContaServices(IPermissaoContaRepository permissaoContaRepository):base(permissaoContaRepository)
        {
            _permissaoContaRepository = permissaoContaRepository;
        }

        public PermissaoConta GetPermissaoContaByData(DateTime dataCadastro)
        {
            return _permissaoContaRepository.GetPermissaoContaByData(dataCadastro);
        }
    }
}
