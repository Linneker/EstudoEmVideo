using acme.estudoemvideo.aplication.Interfaces.Movie.Util;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.util.ViewModel.Movie.Util;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Movie
{
    public class CategoriaController : LayoutBaseController<Categoria, CategoriaViewModel>
    {
        private readonly ICategoriaAplication _aplication;
        private const string NOME_METODO = "Categoria";
        private const string CAMINHO_PADRAO = "/Categoria";
        private IMenuApplication _menuApplication;
        private IMapper _mapper;
        public CategoriaController(ICategoriaAplication aplicationBase,
            IMenuApplication menuApplication, IMapper mapper) : base(aplicationBase, NOME_METODO, CAMINHO_PADRAO, menuApplication, mapper)
        {
            _menuApplication = menuApplication;
            _mapper = mapper;
            _aplication = aplicationBase;
        }

        public override IActionResult Index()
        {
            List<CategoriaViewModel> listaCategorias =_mapper.Map<List<CategoriaViewModel>>(_aplication.GetAll());
            return View(listaCategorias);
        }

        [HttpGet]
        public IActionResult ModalCadastraCategoria()
        {
            return View("../Categoria/Modal/ModalCadastroCategoria", new CategoriaViewModel());
        }
    }
}
