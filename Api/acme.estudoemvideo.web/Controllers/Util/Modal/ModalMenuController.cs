using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.Util;
using acme.estudoemvideo.web.Controllers.Security;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Util.Modal
{
    public class ModalMenuController : LayoutBaseController<Menu,MenuViewModel>
    {
        private const string CAMINHO_PADRAO = "/ModalMenu";
        private readonly IMapper _mapper;
        private readonly IMenuApplication _menuAplication;
        private readonly IPermissaoAplication _permissaoAplication;

        public ModalMenuController(IMapper mapper, IMenuApplication menuAplication, IPermissaoAplication permissaoAplication) : base(menuAplication, "", CAMINHO_PADRAO, menuAplication,mapper) 
        {
            _mapper = mapper;
            _menuAplication = menuAplication;
            _permissaoAplication = permissaoAplication;
        }

        [Route("Menu/Modal/ModalCadastroMenu")]
        [HttpGet]
        public IActionResult ModalCadastroMenu()
        {
            List<Permissao> permissoes = _permissaoAplication.GetAll();
            ViewBag.PermissaoMenu = _mapper.Map<List<PermissaoViewModel>>(permissoes);
            //var menusPrincipais = _menuAplication.GetMenusByMenuId(0);
            var menusPrincipais = _menuAplication.GetAll();
            menusPrincipais.Add(new Menu { Id = Guid.Parse("ae21b5ad-2124-4307-a44d-fb126c7046fb"), Caminho = "", Descricao = "", Nome = "Adiciona Menu Pai" });
            ViewBag.MenusPais = _mapper.Map<List<MenuViewModel>>(menusPrincipais).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome
            });
            return View("../Menu/Modal/ModalCadastroMenu", new MenuViewModel());
        }

        [Route("Menu/Modal/ModalEditarMenu")]
        [HttpGet("{id}")]
        public IActionResult ModalAtualizaMenu(Guid id)
        {
            List<Permissao> permissoes = _permissaoAplication.GetAll();
            var menu = _menuAplication.GetMenuById(id);
            if (menu is null)
            {
                menu = _menuAplication.GetById(id);
                if (menu is null)
                {
                    return View("../Menu/Modal/ModalEditarMenu", null);
                }
            }

            var menuViewModel = _mapper.Map<MenuViewModel>(menu);

            var menusPrincipais = _menuAplication.GetAll();
            menusPrincipais.Add(new Menu { Id = Guid.Parse("ae21b5ad-2124-4307-a44d-fb126c7046fb"), Caminho = "", Descricao = "", Nome = "Adiciona Menu Pai" });
            ViewBag.MenusPais = _mapper.Map<List<MenuViewModel>>(menusPrincipais).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome,
                Selected = x.Id.Equals(menu.MenuIdPai)
            });
            ViewBag.PermissaoMenu = _mapper.Map<List<PermissaoViewModel>>(permissoes);


            List<Permissao> pms = new List<Permissao>();
            foreach (var permissao in permissoes)
            {
                if(menu.PermissoesMenus.Any(t=>t.PermissaoId.Equals(permissao.Id)))
                    pms.Add(permissao);
            }
            ViewBag.PermissoesMenusSelecionados = _mapper.Map<List<PermissaoViewModel>>(pms);
            
            return View("../Menu/Modal/ModalEditarMenu", menuViewModel);
        }

        [Route("Menu/Modal/ModalDeleteMenu")]
        [HttpGet("{id}")]
        public IActionResult ModalDeleteMenu(Guid id)
        {
            List<Permissao> permissoes = _permissaoAplication.GetAll();
            ViewBag.PermissaoMenu = permissoes;
            var menuViewModel = _mapper.Map<MenuViewModel>(_menuAplication.GetById(id));
            return View("../Menu/Modal/ModalDeleteMenu", menuViewModel);

        }

    }
}
