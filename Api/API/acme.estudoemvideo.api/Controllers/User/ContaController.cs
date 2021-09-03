using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Api.Response.User;
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
    public class ContaController : LayoutBaseController<Conta, ContaViewModel>
    {
        private readonly IContaAplication _aplication;
        private const string NOME_METODO = "CONTA";
        private IMapper _mapper;
        public ContaController(IContaAplication contaAplication, IMapper mapper) : base(contaAplication, mapper, NOME_METODO)
        {
            _aplication = contaAplication;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpPost("Login")]
        public ContaResponseApiViewModel Login(LoginViewModel loginViewModel)
        {
            Conta conta = new Conta();
            conta.Senha = loginViewModel.Senha;
            conta.Login = loginViewModel.Login;
            var contaResposta = _aplication.Login(conta);
            if (contaResposta.HasNotifications)
            {
                ContaResponseApiViewModel contaResponseApiViewModel = new ContaResponseApiViewModel(
                 contaResposta.ContaAtiva, contaResposta.Logado, contaResposta.Login, contaResposta.TermoDeAceite,
                 null,contaResposta.Notifications.ToList());
                return contaResponseApiViewModel;
            }
            else
            {
                ICollection<PermissaoResponseApiViewModel> permissaoResponseApiViewModels = new HashSet<PermissaoResponseApiViewModel>();
                foreach (var permissoesContas in contaResposta.PermissoesContas)
                {
                    PermissaoResponseApiViewModel permissaoResponseApiViewModel = new PermissaoResponseApiViewModel(
                        permissoesContas.Permissao.Nome, permissoesContas.Permissao.Nivel,
                        permissoesContas.Delete, permissoesContas.Update, permissoesContas.Add, permissoesContas.Read);
                    permissaoResponseApiViewModels.Add(permissaoResponseApiViewModel);
                }
                ContaResponseApiViewModel contaResponseApiViewModel = new ContaResponseApiViewModel(contaResposta.Id,
                    contaResposta.ContaAtiva, contaResposta.Logado, contaResposta.Login, contaResposta.TermoDeAceite,
                    permissaoResponseApiViewModels,null);
                return contaResponseApiViewModel;
            }
        }

        [Authorize("Bearer")]
        [HttpPost("Logout")]
        public RespostaPadraoModels Logout(LogoutViewModel logoutViewModel)
        {
            RespostaPadraoModels respostaPadrao = null;
            var conta = _aplication.GetById(logoutViewModel.ContaId);
            conta.Logado = false;
            conta.DataModificacao = DateTime.Now;
            if (conta.Login == logoutViewModel.Login)
            {
                respostaPadrao = _mapper.Map<RespostaPadraoModels>(_aplication.Update(conta, "CONTA"));
                return respostaPadrao;
            }
            else
            {
                respostaPadrao = new RespostaPadraoModels(EnumHttp.INFORMACOES_ERRADAS, "LOGIN INVALIDO", "Login informado é invalido", EnumLog.WARNING.ToString(),new List<Notification> { new Notification($"{(int)EnumCodigoMensagem.INFORMACAO_INVALIDA}","Login invalido") });
                return respostaPadrao;
            }
        }

        //[Authorize("Bearer")]
        //[HttpGet]
        //public async Task<Conta> RecuperarSenha(string email, string senha)
        //{
        //    return new Conta();
        //}

        //[Authorize("Bearer")]
        //[HttpPut]
        //public async Task<Conta> AlterarSenha([FromBody]Conta conta)
        //{
        //    return new Conta();
        //}

    }
}