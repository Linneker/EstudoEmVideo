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
    public class VotoVideoController : LayoutBaseController<VotoVideo, VotoVideoViewModel>
    {
        private readonly IVotoVideoAplication _aplication;
        private const string NOME_METODO = "VOTO VÍDEO";
        private readonly IMapper _mapper;
        public VotoVideoController(IVotoVideoAplication votoVideoAplication, IMapper mapper) : base(votoVideoAplication, mapper,NOME_METODO)
        {
            _aplication= votoVideoAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVotoVideoByLikeRelevancia/{idVide}/{likeRelevancia}")]
        public List<VotoVideo> GetVotoVideoByLikeRelevancia(Guid idVideo, long likeRelevancia)
        {
            var retorno = _aplication.GetVotoVideoByLikeRelevancia(idVideo, likeRelevancia);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetVotoVideoByObservacao/{idVideo}/{observacao}")]
        public List<VotoVideo> GetVotoVideoByObservacao(Guid idVideo, string observacao)
        {
            var retorno = _aplication.GetVotoVideoByObservacao(idVideo, observacao);
            return retorno;
        }

    }
}