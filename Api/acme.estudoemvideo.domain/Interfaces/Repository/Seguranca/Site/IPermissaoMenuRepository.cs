using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site
{
    public interface IPermissaoMenuRepository : IRepositoryBase<PermissaoMenu>
    {
        List<PermissaoMenu> GetMenusByPermissaoId(Guid permissaoId);
        Task<List<PermissaoMenu>> GetMenusByPermissaoIdAsync(Guid permissaoId);
    }
}
