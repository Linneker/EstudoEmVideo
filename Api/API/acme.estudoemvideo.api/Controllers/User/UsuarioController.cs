using System;
using System.Collections.Generic;
using System.Linq;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.Map;
using acme.estudoemvideo.util.Map.Api;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Api.User;
using acme.estudoemvideo.util.ViewModel.User;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace acme.estudoemvideo.api.Controllers.User
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class UsuarioController : LayoutBaseController<Usuario, UsuarioViewModel>
    {
        private IMapper _map;
        private readonly IUsuarioAplication _aplication;
        private const string NOME_METODO = "Usuario";
        public UsuarioController(IUsuarioAplication usuarioAplication, IMapper map) : base(usuarioAplication, map,NOME_METODO)
        {
            _aplication = usuarioAplication;
            _map = map;
        }

        [Authorize]
        [HttpPost("Cadastro")]
        public RespostaPadraoModels CadastroUsuario(UsuarioApiViewModel usuarioApiViewModel)
        {
            Usuario usuario = usuarioApiViewModel.UsuarioViewModelToUsuario();
            Conta conta = usuarioApiViewModel.Conta.ContaApiViewModelToConta();
            var usuarioAdicionado = _aplication.CadastroUsuario(usuario, conta);
            var response = _map.Map<RespostaPadraoModels>(usuarioAdicionado);
            return response;
        }

        [Authorize("Bearer")]
        [HttpGet("GetUsuarioByCpf/{cpf}")]
        public Usuario GetUsuarioByCpf(string cpf)
        {
            var retorno = _aplication.GetUsuarioByCpf(cpf);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetUsuarioByEmail/{email}")]
        public Usuario GetUsuarioByEmail(string email)
        {
            var retorno = _aplication.GetUsuarioByEmail(email);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetUsuarioByDataNascimento/{dataNascimentoInicial}/{dataNascimentoFinal}")]
        public List<Usuario> GetUsuarioByDataNascimento(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            var retorno = _aplication.GetUsuarioByDataNascimento(dataNascimentoInicial, dataNascimentoFinal);
            return retorno;
        }

        [Authorize("Bearer")]
        [HttpGet("GetUsuarioByTelefone/{telefone}")]
        public Usuario GetUsuarioByTelefone(string telefone)
        {
            var retorno = _aplication.GetUsuarioByTelefone(telefone);
            return retorno;
        }
    }
}