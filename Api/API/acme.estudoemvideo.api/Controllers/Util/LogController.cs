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
    public class LogController<TEntity> : LayoutBaseController<Log<TEntity>, LogViewModel<TEntity>> where TEntity : class
    {
        private readonly ILogAplication<TEntity> _aplication;
        private const string NOME_METODO = "Log";
        private IMapper _mapper;
        public LogController(ILogAplication<TEntity> logAplication, IMapper mapper) : base(logAplication, mapper, NOME_METODO)
        {
            _aplication = logAplication;
        }

        [Authorize("Bearer")]
        [HttpGet("GetLogByName/{nome}")]
        public List<Log<TEntity>> GetLogByName(string nome)
        {
            var retorno = _aplication.GetLogByName(nome);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetLogByDataLog/{dataLog}")]
        public List<Log<TEntity>> GetLogByDataLog(DateTime dataLog)
        {
            var retorno = _aplication.GetLogByDataLog(dataLog);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetLogByPeriodo/{dataInicial}/{dataFinal}")]
        public List<Log<TEntity>> GetLogByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            var retorno = _aplication.GetLogByPeriodo(dataInicial, dataFinal);
            return retorno;
        }
    }
}