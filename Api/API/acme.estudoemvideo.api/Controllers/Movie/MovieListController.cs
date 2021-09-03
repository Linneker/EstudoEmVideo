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
    public class MovieListController : LayoutBaseController<MovieList, MovieListViewModel>
    {
        private readonly IMovieListAplication _movieListAplication;
        private const string NOME_METODO = "MOVIE LIST";
        private IMapper _mapper;
        public MovieListController(IMovieListAplication movieListAplication, IMapper mapper) :base(movieListAplication, mapper,NOME_METODO)
        {
            _movieListAplication = movieListAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetByIdAsync/{id}")]
        public async Task<MovieList> GetByIdAsync(Guid id)
        {
            var retorno = await _movieListAplication.GetByIdAsync(id);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetMovieListByName/{nome}")]
        public List<MovieList> GetMovieListByName(string nome)
        {
            var movieList = _movieListAplication.GetMovieListByName(nome);
            return movieList;
        }
    }
}