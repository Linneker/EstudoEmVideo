using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Security.Modal
{
    public class ModalPermissaoController : Controller
    {
        [Route("Permissao/Modal/ModalCadastroPermissao")]
        public IActionResult ModalCadastroAutorizacao()
        {
            PermissaoViewModel permissaoViewModel = new PermissaoViewModel();
            return View("../Permissao/Modal/ModalCadastroPermissao", permissaoViewModel);
        }
    }
}
