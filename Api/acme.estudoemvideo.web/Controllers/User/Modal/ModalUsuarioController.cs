using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.Site;
using acme.estudoemvideo.util.ViewModel.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.User.Modal
{
    public class ModalUsuarioController : Controller
    {
        private readonly IPermissaoAplication _permissaoAplication;
        private readonly IEscolaApplication _escolaApplication;
        private readonly IMateriaApplication _materiaApplication;
        public ModalUsuarioController(IPermissaoAplication permissaoAplication, IEscolaApplication escolaApplication, IMateriaApplication materiaApplication)
        {
            _permissaoAplication = permissaoAplication;
            _escolaApplication = escolaApplication;
            _materiaApplication = materiaApplication;
        }

        [Route("Usuario/Modal/ModalCadastroUsuario")]
        public IActionResult ModalCadastroUsuario()
        {
            List<Permissao> permissoes = _permissaoAplication.GetAll();
            List<SelectListItem> selectItens = permissoes.Select(t => new SelectListItem() { Text = t.Nome, Value = t.Id.ToString() }).ToList();
            ViewBag.Permissoes = selectItens;
            
            List<Escola> escolas = _escolaApplication.GetAll();
            List<SelectListItem> selectItemEscola = escolas.Select(t => new SelectListItem() { Text = t.Nome, Value = t.Id.ToString() }).ToList();
            ViewBag.Escolas = selectItemEscola;

            ViewBag.Materias = _materiaApplication.GetAll().Select(t => new SelectListItem() { Text = t.Nome, Value = t.Id.ToString() }).ToList();
            UsuarioSiteViewModel permissaoViewModel = new UsuarioSiteViewModel();
            
            return View("../Usuario/Modal/ModalCadastroUsuario", permissaoViewModel);
        }
    }
}
