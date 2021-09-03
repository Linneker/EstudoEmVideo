using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.User
{
    public interface IPermissaoContaAplication : IApplicationBase<PermissaoConta>
    {
        PermissaoConta GetPermissaoContaByData(DateTime dataCadastro);

    }
}
