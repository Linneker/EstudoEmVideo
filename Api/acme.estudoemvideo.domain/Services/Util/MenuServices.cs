using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Util
{
    public class MenuServices : ServiceBase<Menu>, IMenuServices
    {
        private readonly IMenuRepository _menuRepository;

        public MenuServices(IMenuRepository menuRepository):base(menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public Menu GetMenuByCaminho(string caminho)
        {
            return _menuRepository.GetMenuByCaminho(caminho);
        }

        public Task<Menu> GetMenuByCaminhoAsync(string caminho)
        {
            return _menuRepository.GetMenuByCaminhoAsync(caminho);
        }

        public Menu GetMenuById(Guid id)
        {
            return _menuRepository.GetMenuById(id);
        }

        public Task<Menu> GetMenuByIdAsync(Guid id)
        {
            return _menuRepository.GetMenuByIdAsync(id);
        }

        public Menu GetMenuByNome(string nome)
        {
            return _menuRepository.GetMenuByNome(nome);
        }

        public Task<Menu> GetMenuByNomeAsync(string nome)
        {
            return _menuRepository.GetMenuByNomeAsync(nome);
        }

        public List<Menu> GetMenus()
        {
            return _menuRepository.GetMenus();
        }

        public Task<List<Menu>> GetMenusAsync()
        {
            return _menuRepository.GetMenusAsync();
        }

        public List<Menu> GetMenusByCaminho(string caminho)
        {
            return _menuRepository.GetMenusByCaminho(caminho);
        }

        public Task<List<Menu>> GetMenusByCaminhoAsync(string caminho)
        {
            return _menuRepository.GetMenusByCaminhoAsync(caminho);
        }

        public List<Menu> GetMenusByMenuId(Guid id)
        {
            return _menuRepository.GetMenusByMenuId(id);
        }

        public Task<List<Menu>> GetMenusByMenuIdAsync(Guid id)
        {
            return _menuRepository.GetMenusByMenuIdAsync(id);
        }

        public List<Menu> GetMenusByNome(string nome)
        {
            return _menuRepository.GetMenusByNome(nome);
        }

        public Task<List<Menu>> GetMenusByNomeAsync(string nome)
        {
            return _menuRepository.GetMenusByNomeAsync(nome);
        }
    }
}
