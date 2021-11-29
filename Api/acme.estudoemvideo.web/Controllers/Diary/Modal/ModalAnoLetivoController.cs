using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel.Diary;
using acme.estudoemvideo.util.ViewModel.Util;
using acme.estudoemvideo.web.Controllers.Security;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Diary.Modal
{
    public class ModalAnoLetivoController : LayoutBaseController<AnoLetivo,AnoLetivoViewModel>
    {
        private static IAnoLetivoApplication _application;
        private static IMapper _mapper;
        private const string NOME_METODO = "ANO LETIVO";
        private const string CAMINHO = "/Modal";
        private static IMenuApplication _menuApplication;
        public ModalAnoLetivoController(IAnoLetivoApplication application, IMenuApplication menuApplication, IMapper mapper) 
            : base(application, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _application = application;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }
        
        [Route("AnoLetivo/Modal/ModalCadastroAnoLetivo")]
        [HttpGet("ModalCadastroAnoLetivo")]
        [Authorize]
        public IActionResult ModalCadastroAnoLetivo()
        {
            var menus = _mapper.Map<List<MenuViewModel>>(_menuApplication.GetMenusByCaminho(CAMINHO + "/ModalCadastroAnoLetivo"));
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            AnoLetivoViewModel autorizacaoApiViewModel = new AnoLetivoViewModel();
            return View("../AnoLetivo/Modal/ModalCadastroAnoLetivo", autorizacaoApiViewModel);
        }
    }
}
