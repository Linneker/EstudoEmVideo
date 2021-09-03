using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Util
{
    public class MenuApplication : ApplicationBase<Menu>, IMenuApplication
    {
        private readonly IMenuServices _menuServices;
        public MenuApplication(IMenuServices menuServices):base(menuServices)
        {
            _menuServices = menuServices;
        }
        public Menu GetMenuByCaminho(string caminho)
        {
            return _menuServices.GetMenuByCaminho(caminho);
        }

        public Task<Menu> GetMenuByCaminhoAsync(string caminho)
        {
            return _menuServices.GetMenuByCaminhoAsync(caminho);
        }

        public Menu GetMenuById(Guid id)
        {
            return _menuServices.GetMenuById(id);
        }

        public Task<Menu> GetMenuByIdAsync(Guid id)
        {
            return _menuServices.GetMenuByIdAsync(id);
        }

        public Menu GetMenuByNome(string nome)
        {
            return _menuServices.GetMenuByNome(nome);
        }

        public Task<Menu> GetMenuByNomeAsync(string nome)
        {
            return _menuServices.GetMenuByNomeAsync(nome);
        }

        public List<Menu> GetMenus()
        {
            return _menuServices.GetMenus();
        }

        public Task<List<Menu>> GetMenusAsync()
        {
            return _menuServices.GetMenusAsync();
        }

        public List<Menu> GetMenusByCaminho(string caminho)
        {
            return _menuServices.GetMenusByCaminho(caminho);
        }

        public Task<List<Menu>> GetMenusByCaminhoAsync(string caminho)
        {
            return _menuServices.GetMenusByCaminhoAsync(caminho);
        }

        public List<Menu> GetMenusByMenuId(Guid id)
        {
            return _menuServices.GetMenusByMenuId(id);
        }

        public Task<List<Menu>> GetMenusByMenuIdAsync(Guid id)
        {
            return _menuServices.GetMenusByMenuIdAsync(id);
        }

        public List<Menu> GetMenusByNome(string nome)
        {
            return _menuServices.GetMenusByNome(nome);
        }

        public Task<List<Menu>> GetMenusByNomeAsync(string nome)
        {
            return _menuServices.GetMenusByNomeAsync(nome);
        }
    }
}
