using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.util.ViewModel.School.Matter;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Matter.Modal
{
    public class ModalConteudoController : LayoutBaseController<Conteudo ,ConteudoViewModel>
    {
        private readonly IConteudoApplication _application;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "CONTEUDO";
        private const string CAMINHO = "/Modal";
        private readonly IMenuApplication _menuApplication;
        private readonly IMateriaApplication _materiaApplication;
        public ModalConteudoController(IConteudoApplication application, IMapper mapper, IMenuApplication menuApplication, IMateriaApplication materiaApplication)
            : base(application, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _application = application;
            _mapper = mapper;
            _menuApplication = menuApplication;
            _materiaApplication = materiaApplication;
        }

        [Route("Conteudo/Modal/ModalCadastroConteudo")]
        [Authorize]
        public IActionResult ModalCadastroConteudo()
        {
            var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/ModalCadastroConteudo");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            var materias = _materiaApplication.GetAll();
            List<SelectListItem> selectItens = materias.Select(t => new SelectListItem() { Text = t.Nome, Value = t.Id.ToString() }).ToList();
            ViewBag.Materias = selectItens;

            ConteudoViewModel autorizacaoApiViewModel = new ConteudoViewModel();
            return View("../Conteudo/Modal/ModalCadastroConteudo", autorizacaoApiViewModel);
        }
    }
}
