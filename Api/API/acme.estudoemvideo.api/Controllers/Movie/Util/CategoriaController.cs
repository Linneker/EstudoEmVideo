using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Movie.Util;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.util.ViewModel.Movie.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.api.Controllers.Movie.Util
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class CategoriaController : LayoutBaseController<Categoria,CategoriaViewModel>
    {
        private readonly ICategoriaAplication _aplication;
        private const string NOME_METODO = "CATEGORIA";
        private IMapper _mapper;
        public CategoriaController(ICategoriaAplication categoriaAplication, IMapper mapper) :base(categoriaAplication, mapper, NOME_METODO)
        {
            _aplication = categoriaAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetCategoriaByNome/{nome}")]
        public Categoria GetCategoriaByNome(string nome)
        {
            var cat = _aplication.GetCategoriaByNome(nome);
            return cat;
        }
        [Authorize("Bearer")]
        [HttpGet("GetCategoriaByTipo/{tipoCategoria}")]
        public Categoria GetCategoriaByTipo(EnumTipoCategoria tipoCategoria)
        {
            var cat = _aplication.GetCategoriaByTipo(tipoCategoria);
            return cat;
        }

    }
}