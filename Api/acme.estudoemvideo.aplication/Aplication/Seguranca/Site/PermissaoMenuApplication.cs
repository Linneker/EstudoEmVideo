using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Seguranca.Site
{
    public class PermissaoMenuApplication : ApplicationBase<PermissaoMenu>, IPermissaoMenuApplication
    {
        private readonly IPermissaoMenuServices _permissaoMenuServices;

        public PermissaoMenuApplication(IPermissaoMenuServices permissaoMenuServices):base(permissaoMenuServices)
        {
            _permissaoMenuServices = permissaoMenuServices;
        }

        public List<PermissaoMenu> GetMenusByPermissaoId(Guid permissaoId)
        {
            return _permissaoMenuServices.GetMenusByPermissaoId(permissaoId);
        }

        public Task<List<PermissaoMenu>> GetMenusByPermissaoIdAsync(Guid permissaoId)
        {
            return _permissaoMenuServices.GetMenusByPermissaoIdAsync(permissaoId);
        }
    }
}
