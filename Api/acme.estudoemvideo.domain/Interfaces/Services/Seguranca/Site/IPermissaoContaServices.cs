using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using System;

namespace acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site
{
    public interface IPermissaoContaServices : IServicesBase<PermissaoConta>
    {
        PermissaoConta GetPermissaoContaByData(DateTime dataCadastro);

    }
}
