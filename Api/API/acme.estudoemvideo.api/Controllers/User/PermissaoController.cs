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
    public class PermissaoController : LayoutBaseController<Permissao, PermissaoViewModel>
    {
        private readonly IPermissaoAplication _aplication;
        private const string NOME_METODO = "Permissao";
        private IMapper _mapper;
        public PermissaoController(IPermissaoAplication permissaoAplication, IMapper mapper) : base(permissaoAplication, mapper, NOME_METODO)
        {
            _aplication = permissaoAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpGet("GetPermissaoByNome/{nome}")]
        public Permissao GetPermissaoByNome(string nome)
        {
            var permissao = _aplication.GetPermissaoByNome(nome);
            return permissao;
        }
    }
}