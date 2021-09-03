using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace acme.estudoemvideo.web.Controllers.Util
{
    public class MenuController : LayoutBaseController<Menu,MenuViewModel>
    {
        private readonly IMenuApplication _menuAplication;
        private readonly IPermissaoMenuApplication _permissaoMenuAplication;
        private readonly IMapper _mapper;
        //private readonly ILogAplication _logAplication;
        private const string CAMINHO_PADRAO = "/Menu";
        //private ICompetenciaApplication _competenciaApplication;

        public MenuController(IMenuApplication menuAplication, IPermissaoMenuApplication permissaoMenuAplication, IMapper mapper)
            : base(menuAplication, "MENU",CAMINHO_PADRAO, menuAplication, mapper)
        {
            _menuAplication = menuAplication;
            _mapper = mapper;
            //_logAplication = logAplication;
            _permissaoMenuAplication = permissaoMenuAplication;
            //_competenciaApplication = competenciaApplication;
        }

        [Authorize]
        [HttpGet]
        public string GetMenuByPermissao()
        {
            List<MenuViewModel> menu = SessionExtensions.GetObject<List<MenuViewModel>>(HttpContext.Session, "Menu");

            return JsonConvert.SerializeObject(menu);
        }

        [Authorize]
        [HttpPost]
        public RespostaPadraoModels AddMenu(string menuJson, string[] listaPermissao)
        {
            PermissaoContaViewModel permissaoViewModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            Menu menu = JsonConvert.DeserializeObject<Menu>(menuJson);
            foreach (string permissao in listaPermissao)
            {
                PermissaoMenu permissaoMenu = new PermissaoMenu();
                permissaoMenu.PermissaoId = new Guid(permissao);
                permissaoMenu.Permissao = null;
                permissaoMenu.Menu = null;
                menu.PermissoesMenus.Add(permissaoMenu);
            }
            RespostaPadraoModels response = _mapper.Map<RespostaPadraoModels>(_menuAplication.Add(menu,"MENU"));
            
            long[] idPermissaoMenuSalva = new long[listaPermissao.Length];
            int i = 0;
            return response;
        }

        [Authorize(Roles = "Root,Administrador")]
        public RespostaPadraoModels UpdateMenu(string menuJson, string[] listaPermissao)
        {
            PermissaoContaViewModel permissaoViewModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            Menu menu = JsonConvert.DeserializeObject<Menu>(menuJson);
            var velhoMenu = _menuAplication.GetById(menu.Id);
            if (menu.DataCriacao == null)
            {
                menu.DataCriacao = velhoMenu.DataCriacao == null ? DateTime.Now : velhoMenu.DataCriacao;
                if (menu.Status == EnumStatus.Inativo)
                {
                    menu.DataModificacao = DateTime.Now;
                    menu.DataInativacao = DateTime.Now;
                }
                else
                {
                    menu.DataModificacao = DateTime.Now;
                    menu.DataInativacao = null;
                }
            }
            var menuPermissao = _menuAplication.GetMenuById(menu.Id);
            if (!(menuPermissao is null))
            {
                foreach (var pm in menuPermissao.PermissoesMenus)
                {
                    _permissaoMenuAplication.Delete(pm,"MENU");
                }
                
            }
            foreach (var idPermissao in listaPermissao)
            {
                PermissaoMenu permissaoMn = new PermissaoMenu
                {
                    PermissaoId = new Guid(idPermissao),
                    MenuId = menu.Id,
                    Menu = null,
                    Permissao = null
                };
                _permissaoMenuAplication.Add(permissaoMn,"MENU");

            }
            RespostaPadraoModels response = _mapper.Map<RespostaPadraoModels>(_menuAplication.Update(menu,"MENU"));

            //_logControle.AddLog(response, "Menu", permissaoViewModel, EnumLog.SUCESS, null);
            string json = JsonConvert.SerializeObject(response);
            return response;
        }

        [HttpGet]
        [Authorize(Roles = "Root,Administrador")]
        public IActionResult Menu()
        {
            var menus = _menuAplication.GetMenusByCaminho(CAMINHO_PADRAO + "/Menu");
            var permissaoViewModel = Permissao(menus.Count == 0 ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            if (permissaoViewModel.Url == "" || permissaoViewModel.Url == null)
            {
                ViewBag.Permissao = permissaoViewModel;
                ViewBag.NomeUsuario = permissaoViewModel.Conta.Usuario.Nome;
                ViewBag.Login = permissaoViewModel.Conta.Login;
                return View(_mapper.Map<List<MenuViewModel>>(_menuAplication.GetAll()));
            }
            else
            {
                return View(permissaoViewModel.Url, permissaoViewModel);
            }
        }
    }
}
