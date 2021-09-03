using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.User
{
    public class PermissaoContaAplication : ApplicationBase<PermissaoConta>,IPermissaoContaAplication
    {
        private readonly IPermissaoContaServices _permissaoContaRepository;
        public PermissaoContaAplication(IPermissaoContaServices permissaoContaRepository):base(permissaoContaRepository)
        {
            _permissaoContaRepository = permissaoContaRepository;
        }

        public PermissaoConta GetPermissaoContaByData(DateTime dataCadastro)
        {
            return _permissaoContaRepository.GetPermissaoContaByData(dataCadastro);
        }
    }
}
