using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site
{
    public interface IPermissaoServices : IServicesBase<Permissao>
    {
        Permissao GetPermissaoByNome(string nome);
    }
}
