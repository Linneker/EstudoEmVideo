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
    public class VideoMovieListController : LayoutBaseController<VideoMovieList, VideoMovieListViewModel>
    {
        private readonly IVideoMovieListAplication _aplication;
        private const string NOME_METODO = "VÍDEO MOVIEW LIST";
        private readonly IMapper _mapper;
        public VideoMovieListController(IVideoMovieListAplication videoMovieListAplication, IMapper mapper) :base(videoMovieListAplication,mapper,NOME_METODO)
        {
            _aplication = videoMovieListAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListByDataPeriodo/{dataInicial}/{dataFinal}")]
        public List<VideoMovieList> GetMovieListByDataPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            var retorno = _aplication.GetMovieListByDataLacamento(dataInicial, dataFinal);
            return retorno;
        }
        
        [Authorize("Bearer")]
        [HttpGet("GetMovieListByDataLacamento/{dataLancamento}")]
        public List<VideoMovieList> GetMovieListByDataLacamento(DateTime dataLancamento)
        {
            var retorno = _aplication.GetMovieListByDataLacamento(dataLancamento);
            return retorno;
        }
    }
}