using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.util.ViewModel.School;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.web.Controllers.School.Modal
{
    public class ModalAlunoEscolaController : Controller
    {
        [Route("AlunoEscola/Modal/ModalCadastroAlunoEscola")]
        [Authorize]
        public IActionResult ModalCadastroAlunoEscola()
        {
            AlunoEscolaViewModel autorizacaoApiViewModel = new AlunoEscolaViewModel();
            return View("../AlunoEscola/Modal/ModalCadastroAlunoEscola", autorizacaoApiViewModel);
        }
    }
}
