using acme.estudoemvideo.aplication.Interfaces.School.Notes;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.util.ViewModel.School.Notes;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Notes.Modal
{
    public class ModalNotaController : LayoutBaseController<Nota, NotaViewModel>
    {
        private readonly INotaApplication _notaApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "Nota";
        private const string CAMINHO = "/Nota/Modal";
        private readonly IMenuApplication _menuApplication;

        public ModalNotaController(INotaApplication notaApplication, IMapper mapper, IMenuApplication menuApplication)
            : base(notaApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _notaApplication = notaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

        [Route("Nota/Modal/ModalCadastroNota")]
        [Authorize]
        public IActionResult ModalCadastroNota()
        {
            var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/ModalCadastroNota");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            NotaViewModel NotaViewModel = new NotaViewModel();
            return View($"../Nota/Modal/ModalCadastroNota", NotaViewModel);
        }
    }
}
