using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Util
{
    public interface IMenuApplication : IApplicationBase<Menu>
    {
        Menu GetMenuById(Guid id);

        List<Menu> GetMenus();
        Menu GetMenuByNome(string nome);
        Menu GetMenuByCaminho(string caminho);
        List<Menu> GetMenusByMenuId(Guid id);
        List<Menu> GetMenusByNome(string nome);
        List<Menu> GetMenusByCaminho(string caminho);

        Task<Menu> GetMenuByIdAsync(Guid id);
        Task<List<Menu>> GetMenusAsync();
        Task<Menu> GetMenuByNomeAsync(string nome);
        Task<Menu> GetMenuByCaminhoAsync(string caminho);
        Task<List<Menu>> GetMenusByMenuIdAsync(Guid id);


        Task<List<Menu>> GetMenusByNomeAsync(string nome);
        Task<List<Menu>> GetMenusByCaminhoAsync(string caminho);
    }
}
