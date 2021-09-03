using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.util.ViewModel.School.Matter;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Matter.Modal
{
    public class ModalMateriaController : LayoutBaseController<Materia,MateriaViewModel>
    {

        private readonly IMateriaApplication _application;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "MATERIA";
        private const string CAMINHO = "/Modal";
        private readonly IMenuApplication _menuApplication;

        public ModalMateriaController(IMateriaApplication application, IMapper mapper, IMenuApplication menuApplication)
            : base(application, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _application = application;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

        [Route("Materia/Modal/ModalCadastroMateria")]
        [Authorize]
        public IActionResult ModalCadastroMateria()
        {
            var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/ModalCadastroMateria");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            MateriaViewModel autorizacaoApiViewModel = new MateriaViewModel();
            return View("../Materia/Modal/ModalCadastroMateria", autorizacaoApiViewModel);
        }
    }
}
