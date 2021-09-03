using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.aplication.Interfaces.Movie.Util;
using acme.estudoemvideo.util.ViewModel.Movie;
using acme.estudoemvideo.util.ViewModel.Movie.Util;
using acme.estudoemvideo.web.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Movie.Model
{
    public class ModalVideoController : Controller
    {
        private readonly ICategoriaAplication _categoriaVideoAplication;
        private readonly IMapper _mapper;

        public ModalVideoController(ICategoriaAplication categoriaVideoAplication, IMapper mapper)
        {
            _categoriaVideoAplication = categoriaVideoAplication;
            _mapper = mapper;
        }

        [Route("Video/Modal/ModalCadastroVideo")]
        [HttpGet]
        public IActionResult ModalCadastroVideo()
        {

            List<CategoriaViewModel> categorias = _mapper.Map<List<CategoriaViewModel>>(_categoriaVideoAplication.GetAll());

            List<SelectListItem> selectItens = categorias.Select(t => new SelectListItem() { Text = t.Nome, Value = t.Id.ToString() }).ToList();
            VideoSiteViewModel videoSiteView = new VideoSiteViewModel("", "", selectItens);
            return View("../Video/Modal/ModalCompletoCadastroVideo", videoSiteView);

        }
    }
}
