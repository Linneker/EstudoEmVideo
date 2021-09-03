using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Erro
{
    [AllowAnonymous]
    public class ErroController : Controller
    {
        public IActionResult Erro403()
        {
            return View();
        }

        public IActionResult Erro403Interno()
        {
            var permissaoContaViewModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            return View(permissaoContaViewModel);
        }

        public IActionResult Erro403Modal()
        {
            var permissaoContaViewModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            return View(permissaoContaViewModel);
        }

        public IActionResult Erro404()
        {
            return View();
        }

        public IActionResult Erro404Interno()
        {
            var permissaoContaViewModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            return View(permissaoContaViewModel);
        }

        public IActionResult Erro500()
        {
            return View();
        }

        public IActionResult Erro500Interno()
        {
            var permissaoContaViewModel = SessionExtensions.GetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta");
            return View(permissaoContaViewModel);
        }
    }
}
