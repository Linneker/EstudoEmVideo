using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.api.Controllers.Util
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class ParametroController : LayoutBaseController<Parametro,ParametroViewModel>
    {

        private readonly IParametroAplication _aplication;
        private const string NOME_METODO = "Parametro";
        private readonly IMapper _mapper;
        public ParametroController(IParametroAplication parametroAplication, IMapper mapper) : base(parametroAplication, mapper, NOME_METODO)
        {
            _aplication = parametroAplication;
        }

        [Authorize("Bearer")]
        [HttpGet("Nome/{nome}")]
        public List<Parametro> GetParametrosByNome(string nome)
        {
            var retorno = _aplication.GetParametrosByNome(nome);
            return retorno;
        }
        [Authorize("Bearer")]
        [HttpGet("Ativo/{ativo}")]
        public List<Parametro> GetParametrosByAtivo(bool ativo)
        {
            var retorno = _aplication.GetParametrosByAtivo(ativo);
            return retorno;
        }

    }
}