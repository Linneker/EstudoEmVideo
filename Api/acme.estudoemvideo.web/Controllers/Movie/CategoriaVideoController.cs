using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Movie
{
    public class CategoriaVideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
