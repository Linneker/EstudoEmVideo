using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.util.ViewModel.School.Util;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Util.Modal
{
    public class ModalBimestreController : LayoutBaseController<Bimestre,BimestreViewModel>
    {
        private readonly IBimestreApplication _bimestreApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "BIMESTRE";
        private const string CAMINHO = "/Bimestre/Modal";
        private readonly IMenuApplication _menuApplication;

        public ModalBimestreController(IBimestreApplication bimestreApplication, IMapper mapper, IMenuApplication menuApplication)
            : base(bimestreApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _bimestreApplication = bimestreApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

        [Route("Bimestre/Modal/ModalCadastroBimestre")]
        [Authorize]
        public IActionResult ModalCadastroBimestre()
        {
            var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/ModalCadastroBimestre");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            BimestreViewModel bimestreViewModel = new BimestreViewModel();
            return View($"../Bimestre/Modal/ModalCadastroBimestre", bimestreViewModel);
        }
    }
}
