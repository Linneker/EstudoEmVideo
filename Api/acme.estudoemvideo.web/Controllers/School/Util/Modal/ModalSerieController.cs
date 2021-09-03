using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.util.ViewModel.School.Util;
using Microsoft.AspNetCore.Authorization;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.util.ViewModel.Util;

namespace acme.estudoemvideo.web.Controllers.School.Util.Modal
{
    public class ModalSerieController : LayoutBaseController<Serie,SerieViewModel>
    {
        private readonly ISerieApplication _serieApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "SERIE";
        private const string CAMINHO = "/Modal";
        private readonly IMenuApplication _menuApplication;

        public ModalSerieController(ISerieApplication serieApplication, IMapper mapper, IMenuApplication menuApplication)
           : base(serieApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _serieApplication = serieApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }
        [Route("Modal/ModalCadastroSerie")]
        [Authorize]
        public IActionResult ModalCadastroSerie()
        {
            var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/ModalCadastroSerie");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            SerieViewModel bimestreViewModel = new SerieViewModel();
            return View($"../Serie/Modal/ModalCadastroSerie", bimestreViewModel);
        }
    }
}
