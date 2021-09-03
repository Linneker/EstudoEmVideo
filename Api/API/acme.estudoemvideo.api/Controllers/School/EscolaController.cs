using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.util.ViewModel.School;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.api.Controllers.School
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class EscolaController : LayoutBaseController<Escola,EscolaViewModel>
    {

        private readonly IEscolaApplication _aplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "Escola";
        public EscolaController(IEscolaApplication contaAplication, IMapper mapper) :base(contaAplication, mapper,NOME_METODO)
        {
            _aplication = contaAplication;
        }
        
        [Authorize("Bearer")]
        [HttpGet("GetEscolasByNome/{nome}")]
        public List<Escola> GetEscolasByNome(string nome)
        {
            var retorno =  _aplication.GetEscolasByNome(nome);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetEscolasByRazaoSocial/{razaoSocial}")]
        public List<Escola> GetEscolasByRazaoSocial(string razaoSocial)
        {
            var retorno =  _aplication.GetEscolasByRazaoSocial(razaoSocial);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetEscolaByCnpj/{cnpj}")]
        public Escola GetEscolaByCnpj(string cnpj)
        {
            var retorno = _aplication.GetEscolaByCnpj(cnpj);
            return retorno;
        }

    }
}