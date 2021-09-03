using System;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Seguranca;
using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using acme.estudoemvideo.util.ViewModel.Seguranca;

namespace acme.estudoemvideo.api.Controllers.Seguranca
{
    [ApiController]
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    public class AutorizacaoApiController : LayoutBaseController<AutorizacaoApi, AutorizacaoApiViewModel>
    {
        private readonly IAutorizacaoApiAplication _autorizacaoApiAplication;
        private IMapper _mapper;
        private const string NOME_SERVICO = "AUTORIZAÇÃO API";
        public AutorizacaoApiController(IAutorizacaoApiAplication autorizacaoApiAplication, IMapper mapper):base(autorizacaoApiAplication,mapper, NOME_SERVICO)
        {
            _autorizacaoApiAplication = autorizacaoApiAplication;
            _mapper = mapper;
        }


        [AllowAnonymous]
        [HttpPost("Autenticar")]
        public  object Post(
            [FromBody]AutorizacaoApi usuario,
            [FromServices]SigningConfigurations signingConfigurations,
            [FromServices]TokenConfigurations tokenConfigurations)
        {
            bool credenciaisValidas = false;
            if (usuario != null)
            {
                var usuarioBase =  _autorizacaoApiAplication.GetAutorizacaoByAccessKey(usuario.AccessKey);
                credenciaisValidas = (usuarioBase != null &&
                    usuario.AccessKey == usuarioBase.AccessKey &&
                    usuario.CnpjEmpresa == usuarioBase.CnpjEmpresa);
            }

            if (credenciaisValidas)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity("" + usuario.Id, "Autorizacao"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, ""+usuario.Id)
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao +
                    TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK"
                };
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Falha na autenticacao"
                };
            }
        }
    }
}