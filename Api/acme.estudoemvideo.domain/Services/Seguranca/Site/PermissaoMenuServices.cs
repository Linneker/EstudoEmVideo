using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Seguranca.Site
{
    public class PermissaoMenuServices : ServiceBase<PermissaoMenu>, IPermissaoMenuServices
    {
        private new readonly IPermissaoMenuRepository _repositoryBase;
        public PermissaoMenuServices(IPermissaoMenuRepository repositoryBase) : base(repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public List<PermissaoMenu> GetMenusByPermissaoId(Guid permissaoId)
        {
            return _repositoryBase.GetMenusByPermissaoId(permissaoId);
        }

        public Task<List<PermissaoMenu>> GetMenusByPermissaoIdAsync(Guid permissaoId)
        {
            return _repositoryBase.GetMenusByPermissaoIdAsync(permissaoId);
        }
    }
}
