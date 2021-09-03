using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Seguranca.Site
{
    public class PermissaoMenuRepository : RepositoryBase<PermissaoMenu>, IPermissaoMenuRepository
    {
        public PermissaoMenuRepository(Context db) : base(db)
        {
        }

        public List<PermissaoMenu> GetMenusByPermissaoId(Guid permissaoId)
        {
            var query = (from pm in _db.PermissaoMenus
                         join p in _db.Permissoes on pm.PermissaoId equals p.Id
                         join m in _db.Menus on pm.MenuId equals m.Id
                         where pm.PermissaoId == permissaoId && m.Status == EnumStatus.Ativo
                         orderby m.Caminho, m.DataCriacao, m.Posicao
                         select new { pm, m, p }).AsNoTracking().ToList();
            var permissoesMenus = new List<PermissaoMenu>();
            foreach (var result in query)
            {
                result.m.PermissoesMenus = null;
                PermissaoMenu permissaoMenu = result.pm;
                permissaoMenu.Menu = result.m;
                permissaoMenu.Permissao = result.p;
                permissoesMenus.Add(permissaoMenu);
            }
            return permissoesMenus;
        }

        public Task<List<PermissaoMenu>> GetMenusByPermissaoIdAsync(Guid permissaoId)
        {
            var query = (from pm in _db.PermissaoMenus
                         join p in _db.Permissoes on pm.PermissaoId equals p.Id
                         join m in _db.Menus on pm.MenuId equals m.Id
                         where pm.PermissaoId == permissaoId && m.Status == EnumStatus.Ativo
                         select pm).ToListAsync<PermissaoMenu>();
            return query;
        }
    }
}
