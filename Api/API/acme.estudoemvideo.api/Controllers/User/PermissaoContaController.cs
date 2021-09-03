using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acme.estudoemvideo.api.Controllers.User
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class PermissaoContaController : LayoutBaseController<PermissaoConta,PermissaoContaViewModel>
    {
        private readonly IPermissaoContaAplication _aplication;
        private IMapper _mapper;
        private const string NOME_SERVICO = "PERMISSÃO CONTA";
        public PermissaoContaController(IPermissaoContaAplication permissaoContaAplication, IMapper mapper):base(permissaoContaAplication,mapper, NOME_SERVICO)
        {
            _aplication = permissaoContaAplication;
        }
   
        [Authorize("Bearer")]
        [HttpGet("GetPermissaoContaByData/{dataCadastro}")]
        public PermissaoConta GetPermissaoContaByData(DateTime dataCadastro)
        {
            var permissaoConta = _aplication.GetPermissaoContaByData(dataCadastro);
            return permissaoConta;
        }
    }
}