using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.util.ViewModel.School;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Modal
{
    public class ModalEscolaController : Controller
    {
        private readonly IPermissaoAplication _permissaoAplication;

        public ModalEscolaController(IPermissaoAplication permissaoAplication)
        {
            _permissaoAplication = permissaoAplication;
        }

        [Route("Escola/Modal/ModalCadastroEscola")]
        [Authorize]
        public IActionResult ModalCadastroEscola()
        {
            EscolaViewModel escolaViewModel = new EscolaViewModel();
            return View("../Escola/Modal/ModalCadastroEscola", escolaViewModel);
        }
    }
}
