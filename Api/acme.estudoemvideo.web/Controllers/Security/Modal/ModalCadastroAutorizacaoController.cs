using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.util.ViewModel.Seguranca;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.web.Controllers.Security.Modal
{
    public class ModalCadastroAutorizacaoController : Controller
    {
        [Route("AutorizacaoApi/Modal/ModalCadastroAutorizacao")]
        public IActionResult Index()
        {
            AutorizacaoApiViewModel autorizacaoApiViewModel = new AutorizacaoApiViewModel();
            return View("../AutorizacaoApi/Modal/ModalCadastroAutorizacao", autorizacaoApiViewModel);
        }
    }
}
