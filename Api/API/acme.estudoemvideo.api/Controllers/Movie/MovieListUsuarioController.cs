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
    public class MovieListUsuarioController : LayoutBaseController<MovieListUsuario, MovieListUsuarioViewModel>
    {
        private readonly IMovieListUsuarioAplication _aplication;
        private const string NOME_METODO = "MOVIE LIST USUARIO";
        private readonly IMapper _mapper;
        public MovieListUsuarioController(IMovieListUsuarioAplication movieListUsuarioAplication, IMapper mapper) :base(movieListUsuarioAplication, mapper,NOME_METODO)
        {
            _aplication = movieListUsuarioAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByIdAndDownload/{id}/{download}")]
        public MovieListUsuario GetMovieListUsuarioByIdAndDownload(Guid id, bool download)
        {
            var retorno = _aplication.GetMovieListUsuarioByIdAndDownload(id, download);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload/{idMovieList}/{idUsuario}/{download}")]
        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(Guid idMovieList, Guid idUsuario, bool download)
        {
            var retorno = _aplication.GetMovieListUsuarioByIdMovieListAndIdUsuarioAndDownload(idMovieList, idUsuario, download);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByDownload/{download}")]
        public List<MovieListUsuario> GetMovieListUsuarioByDownload(bool download)
        {
            var retorno = _aplication.GetMovieListUsuarioByDownload(download);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByIdAndFavorito/{id}/{favorito}")]
        public MovieListUsuario GetMovieListUsuarioByIdAndFavorito(Guid id, bool favorito)
        {
            var retorno = _aplication.GetMovieListUsuarioByIdAndFavorito(id, favorito);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito/{idMovieList}/{idUsuario}/{favorito}")]
        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(Guid idMovieList, Guid idUsuario, bool favorito)
        {
            var retorno = _aplication.GetMovieListUsuarioByIdMovieListAndIdUsuarioAndFavorito(idMovieList, idUsuario, favorito);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByFavorito/{favorito}")]
        public List<MovieListUsuario> GetMovieListUsuarioByFavorito(bool favorito)
        {
            var retorno = _aplication.GetMovieListUsuarioByFavorito(favorito);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByDataCriacao/{dataCriacao}")]
        public List<MovieListUsuario> GetMovieListUsuarioByDataCriacao(DateTime dataCriacao)
        {
            var retorno = _aplication.GetMovieListUsuarioByDataCriacao(dataCriacao);
            return retorno;
        }
        [Authorize("Bearer")]
        [HttpGet("GetMovieListUsuarioByIdMovieListAndIdUsuario/{idUsuario}/{idMovieList}")]
        public MovieListUsuario GetMovieListUsuarioByIdMovieListAndIdUsuario(Guid idUsuario, Guid idMovieList)
        {
            var retorno = _aplication.GetMovieListUsuarioByIdMovieListAndIdUsuario(idUsuario, idMovieList);
            return retorno;
        }

    }
}