using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.util.ViewModel.Movie;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.api.Controllers.Movie
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class CategoriaVideoController : LayoutBaseController<CategoriaVideo, CategoriaVideoViewModel>
    {
        private readonly ICategoriaVideoAplication _aplication;
        private const string NOME_METODO = "CATEGORIA VÍDEO";
        private IMapper _mapper;
        public CategoriaVideoController(ICategoriaVideoAplication categoriaVideoAplication, IMapper mapper) :base(categoriaVideoAplication, mapper, NOME_METODO)
        {
            _aplication = categoriaVideoAplication;
            _mapper = mapper;
        }
        
        [Authorize("Bearer")]
        [HttpGet("GetCategoriaVideoByPeriodo/{dataInicio}/{dataFim}")]
        public List<CategoriaVideo> GetCategoriaVideoByPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            var retorno = _aplication.GetCategoriaVideoByDate(dataInicio, dataFim);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetCategoriaVideoByDate/{data}")]
        public List<CategoriaVideo> GetCategoriaVideoByDate(DateTime data)
        {
            var retorno = _aplication.GetCategoriaVideoByDate(data);
            return retorno;
        }
    }
}