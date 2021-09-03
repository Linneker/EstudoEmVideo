using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Util
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(Context db) : base(db)
        {
        }
        public Menu GetMenuByCaminho(string caminho)
        {
            try
            {
                var query = (from mn in _db.Menus
                             where mn.Caminho == caminho && mn.Status == EnumStatus.Ativo
                             select mn).AsNoTracking().First<Menu>();
                return query;
            }
            catch
            {
                return new Menu();
            }

        }

        public Task<Menu> GetMenuByCaminhoAsync(string caminho)
        {
            try
            {

                var query = (from mn in _db.Menus
                             where mn.Caminho == caminho && mn.Status == EnumStatus.Ativo
                             select mn).AsNoTracking().FirstAsync<Menu>();
                return query;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public Menu GetMenuById(Guid id)
        {
            try
            {
                var query = (from mn in _db.Menus
                             join mp in _db.PermissaoMenus on mn.Id equals mp.MenuId
                             join p in _db.Permissoes on mp.PermissaoId equals p.Id
                             where mn.Id == id
                             select mn).Include(t=>t.PermissoesMenus).AsNoTracking().FirstOrDefault();

                return query;
            }
            catch(Exception e)
            {
                return new Menu();
            }
        }

        public Task<Menu> GetMenuByIdAsync(Guid id)
        {
            var query = (from mn in _db.Menus
                         join mp in _db.PermissaoMenus on mn.Id equals mp.MenuId
                         join p in _db.Permissoes on mp.PermissaoId equals p.Id
                         select mn).AsNoTracking().FirstOrDefaultAsync();
            return query;
        }

        public Menu GetMenuByNome(string nome)
        {
            var query = (from mn in _db.Menus
                         where mn.Nome == nome && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().First<Menu>();
            return query;
        }

        public Task<Menu> GetMenuByNomeAsync(string nome)
        {
            var query = (from mn in _db.Menus
                         where mn.Nome == nome && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().FirstAsync<Menu>();
            return query;
        }

        public List<Menu> GetMenus()
        {
            try
            {
                var query = (from mn in _db.Menus
                             join mp in _db.PermissaoMenus on mn.Id equals mp.MenuId
                             join p in _db.Permissoes on mp.PermissaoId equals p.Id
                             select new { mn, mp, p }).AsNoTracking().ToList();
                List<Menu> menus = new List<Menu>();
                foreach (var objetoGenerico in query)
                {

                    objetoGenerico.mp.Permissao = objetoGenerico.p;
                    objetoGenerico.mn.PermissoesMenus.Add(objetoGenerico.mp);
                    menus.Add(objetoGenerico.mn);
                }

                return menus;
            }
            catch
            {
                return new List<Menu>();
            }
        }

        public Task<List<Menu>> GetMenusAsync()
        {
            var query = (from mn in _db.Menus
                         join mp in _db.PermissaoMenus on mn.Id equals mp.MenuId
                         join p in _db.Permissoes on mp.PermissaoId equals p.Id
                         select mn).AsNoTracking().ToListAsync();
            return query;
        }

        public List<Menu> GetMenusByCaminho(string caminho)
        {
            try
            {
                var query = (from mn in _db.Menus
                             where mn.Caminho == caminho && mn.Status == EnumStatus.Ativo
                             select mn).AsNoTracking().ToList<Menu>();
                return query;
            }
            catch
            {
                return new List<Menu>();
            }
        }

        public Task<List<Menu>> GetMenusByCaminhoAsync(string caminho)
        {
            var query = (from mn in _db.Menus
                         where mn.Caminho == caminho && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().ToListAsync<Menu>();
            return query;
        }

        public List<Menu> GetMenusByMenuId(Guid id)
        {
            var query = (from mn in _db.Menus
                         where mn.MenuIdPai == id && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().ToList<Menu>();
            return query;
        }

        public Task<List<Menu>> GetMenusByMenuIdAsync(Guid id)
        {
            var query = (from mn in _db.Menus
                         where mn.MenuIdPai == id && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().ToListAsync<Menu>();
            return query;
        }

        public List<Menu> GetMenusByNome(string nome)
        {
            var query = (from mn in _db.Menus
                         where mn.Nome.Contains(nome) && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().ToList<Menu>();
            return query;
        }

        public Task<List<Menu>> GetMenusByNomeAsync(string nome)
        {
            var query = (from mn in _db.Menus
                         where mn.Nome.Contains(nome) && mn.Status == EnumStatus.Ativo
                         select mn).AsNoTracking().ToListAsync<Menu>();
            return query;
        }
    }
}
