using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.User;
using acme.estudoemvideo.util.ViewModel.Util;
using acme.estudoemvideo.web.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers
{
    public class LayoutBaseController<TEntity, TEntityViewModel> : Controller where TEntity : AbstractEntity where TEntityViewModel : AbstractEntityViewModel
    {
        private PermissaoContaViewModel _permissaoContaModel;
        private readonly IApplicationBase<TEntity> _aplication;
        private readonly string _caminhoPadrao;
        private readonly string _nomeMetodo;
        private readonly IMenuApplication _menuAplication;
        private readonly IMapper _mapper;

        public LayoutBaseController(IApplicationBase<TEntity> aplicationBase, string nomeMetodo, string caminhoPadrao, IMenuApplication menuApplication, IMapper mapper)
        {
            _aplication = aplicationBase;
            _nomeMetodo = nomeMetodo;
            _caminhoPadrao = caminhoPadrao;
            _menuAplication = menuApplication;
            _mapper = mapper;
        }
        [Authorize]
        public virtual IActionResult Index1()
        {
            var menus = _menuAplication.GetMenusByCaminho(_caminhoPadrao + "/Index");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            return View(permissao.Url);
        }

        [Authorize]
        public virtual IActionResult Index()
        {
            try
            {
                var menus = _menuAplication.GetMenusByCaminho(_caminhoPadrao + "/Index");
                var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
                ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
                ViewBag.Login = permissao.Conta.Login;
                ViewData["Permissao"] = permissao;
                var t = _mapper.Map<List<TEntityViewModel>>(GetAll());
                if (t is null)
                {
                    return Index1();
                }
                return View(permissao.Url, t);
            }
            catch (Exception e)
            {
                return Index1();
            }
        }

        [Authorize]
        [HttpPost]
        public virtual RespostaPadraoModels Cadastro(TEntity json) => _mapper.Map<RespostaPadraoModels>(_aplication.Add(json, _nomeMetodo));

        [Authorize]
        [HttpPost]
        public virtual RespostaPadraoModels Post(string json) => _mapper.Map<RespostaPadraoModels>(_aplication.Add(JsonConvert.DeserializeObject<TEntity>(json), _nomeMetodo));

        [Authorize]
        [HttpPut]
        public RespostaPadraoModels Put([FromBody] TEntity tEntity) => _mapper.Map<RespostaPadraoModels>(_aplication.Update(tEntity, _nomeMetodo));

        [Authorize]
        [HttpDelete]
        public virtual RespostaPadraoModels Delete(Guid id) => _mapper.Map<RespostaPadraoModels>(_aplication.Delete(_aplication.GetById(id), _nomeMetodo));
        [Authorize]

        [Authorize]
        [HttpGet]
        public virtual TEntity GetById(Guid id)
        {
            var retorno = _aplication.GetById(id);
            return retorno;
        }

        [Authorize]
        [HttpGet]
        public List<TEntity> GetAll()
        {
            var retorno = _aplication.GetAll();
            return retorno;
        }

        [Authorize]
        [HttpGet]
        public virtual DataTableResponseViewModel<TEntityViewModel> GetDadosTable()
        {
            DataTableResponseViewModel<TEntityViewModel> dataTableResponseViewModel = new DataTableResponseViewModel<TEntityViewModel>();
            List<TEntityViewModel> parametroViewModel = _mapper.Map<List<TEntityViewModel>>(_aplication.GetAll());
            dataTableResponseViewModel.data = parametroViewModel;
            return dataTableResponseViewModel;
        }


        [Authorize]
        public PermissaoContaViewModel Permissao(List<MenuViewModel> caminhoMenu)
        {
            bool naoTemPermissao = true;
            _permissaoContaModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            var menus = SessionExtensions.GetObject<List<MenuViewModel>>(HttpContext.Session, "Menu");
            if (_permissaoContaModel == null)
            {
                Response.Redirect("/Erro/Erro403", true);
                _permissaoContaModel = new PermissaoContaViewModel();
                _permissaoContaModel.Conta = new ContaViewModel();
                _permissaoContaModel.Conta.Usuario = new UsuarioViewModel();
                _permissaoContaModel.Conta.Usuario.Nome = "";
                RemoverPermissao();
                _permissaoContaModel.Url = ("../Erro/Erro403");
                return _permissaoContaModel;
            }
            else if (!(_permissaoContaModel.Conta.ContaAtiva.Value))
            {
                Response.Redirect("/Erro/Erro403Interno", true);
                _permissaoContaModel = new PermissaoContaViewModel();
                _permissaoContaModel.Conta = new ContaViewModel();
                _permissaoContaModel.Conta.Usuario = new UsuarioViewModel();
                _permissaoContaModel.Conta.Usuario.Nome = "";
                RemoverPermissao();
                return _permissaoContaModel;
            }
            else if (!(_permissaoContaModel.Conta.Logado))
            {
                Response.Redirect("/Erro/Erro403", true);
                _permissaoContaModel = new PermissaoContaViewModel();
                _permissaoContaModel.Conta = new ContaViewModel();
                _permissaoContaModel.Conta.Usuario = new UsuarioViewModel();
                _permissaoContaModel.Conta.Usuario.Nome = "";
                RemoverPermissao();
                _permissaoContaModel.Url = "../Erro/Erro403";
                return _permissaoContaModel;
            }
            else if (caminhoMenu.Count == 0)
            {
                Response.Redirect("/Erro/Erro404Interno", true);
                _permissaoContaModel = new PermissaoContaViewModel();
                _permissaoContaModel.Conta = new ContaViewModel();
                _permissaoContaModel.Conta.Usuario = new UsuarioViewModel();
                _permissaoContaModel.Conta.Usuario.Nome = "";
                _permissaoContaModel.Url = "../Erro/Erro404Interno";
                return _permissaoContaModel;
            }
            try
            {
                foreach (MenuViewModel menu in menus)
                {
                    foreach (MenuViewModel mePesquisa in caminhoMenu)
                    {
                        if (mePesquisa.Id == menu.Id)
                        {
                            naoTemPermissao = false;
                            break;
                        }
                        else
                        {
                            naoTemPermissao = true;
                        }
                    }
                    if (!(naoTemPermissao))
                    {
                        break;
                    }
                }
            }
            catch
            {
                Response.Redirect("/Conta/Login", true);
                _permissaoContaModel.Url = "../Conta/Login";
                return _permissaoContaModel;
            }
            if (naoTemPermissao)
            {
                if (caminhoMenu.Count == 0)
                {
                    Response.Redirect("/Erro/Erro404Interno", true);
                    _permissaoContaModel.Url = "../Erro/Erro404Interno";
                    _permissaoContaModel.Update = false;
                    _permissaoContaModel.Add = false;
                    _permissaoContaModel.Read = false;
                    _permissaoContaModel.Delete = false;
                }
                else
                {
                    RedirectToAction("/Erro/Erro403Interno", true);
                    RemoverPermissao();
                }
            }

            return _permissaoContaModel;
        }
        [Authorize]
        public RespostaPadraoModels PreencheRespostaPadrao(EnumHttp enumHttp, string mensagem, string descricao, string status, List<Notification> notifications)
        {
            return new RespostaPadraoModels(enumHttp, mensagem, descricao, status, notifications);
        }
        private void RemoverPermissao()
        {
            _permissaoContaModel.Url = "../Erro/Erro403Interno";
            _permissaoContaModel.Update = false;
            _permissaoContaModel.Add = false;
            _permissaoContaModel.Read = false;
            _permissaoContaModel.Delete = false;
        }
    }
}
