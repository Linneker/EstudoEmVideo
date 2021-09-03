using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Seguranca.Site
{
    public interface IPermissaoMenuApplication : IApplicationBase<PermissaoMenu>
    {
        List<PermissaoMenu> GetMenusByPermissaoId(Guid permissaoId);
        Task<List<PermissaoMenu>> GetMenusByPermissaoIdAsync(Guid permissaoId);
    }
}
