using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.site.Controllers.Movie.Modal
{
    public class ModalCategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}