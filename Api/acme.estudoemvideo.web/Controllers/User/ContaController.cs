using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.services.Services.Security.User;
using acme.estudoemvideo.util.Map.Site;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Api.User;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.User;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace acme.estudoemvideo.web.Controllers.User
{
    public class ContaController : LayoutBaseController<Conta,ContaViewModel>
    {
        private IMemoryCache _cache;
        private readonly IContaAplication _contaApplication;
        private readonly IMapper _mapper;
        private const string NOME_SISTEMA = "CONTA";
        private const string CAMINHO_PADRAO = "/Conta";
        private readonly IMenuApplication _menuApplication;
        private readonly IParametroAplication _parametroAplication;
        private readonly IPermissaoMenuApplication _permissaoMenuApplication;
        public ContaController(IContaAplication 
            contaApplication, IMapper mapper, IMenuApplication menuApplication,
            IMemoryCache cache,
            IParametroAplication parametroAplication,
            IPermissaoMenuApplication permissaoMenuApplication) :base(contaApplication, NOME_SISTEMA, CAMINHO_PADRAO, menuApplication,mapper)
        {
            _contaApplication = contaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
            _cache = cache;
            _parametroAplication = parametroAplication;
            _permissaoMenuApplication = permissaoMenuApplication;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            LoginViewModel loginViewModel = new LoginViewModel();
            _cache.Dispose();
            return View(loginViewModel);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string login, string senha, bool continuarLogado = false, string returnUrl = "")
        {
            if (string.IsNullOrEmpty(returnUrl))
                returnUrl = "../Usuario/Index";

            var json = "";
            Conta contaRetorno = _contaApplication.Login(new Conta(senha,login));
            ContaViewModel conta = new ContaViewModel();
            try
            {
                if (contaRetorno.HasNotifications) {
                    if(contaRetorno.Notifications.Where(t=>t.Key.Equals("LOGIN_OU_SENHA_INVALIDO")).Any())
                        json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "AVISO!", Msg = "Login ou Senha Invalido!" });
                    else
                        json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "AVISO!", Msg = contaRetorno.Notifications.Select(T=>T.Mensagem).FirstOrDefault()});
                    return View();
                }
                conta = contaRetorno.ContaToContaViewModel();
            }
            catch (Exception e)
            {
                json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "AVISO!", Msg = "Login ou Senha Invalido!" });
                return View();
            }
            if (conta.Status.Equals(EnumStatus.Ativo))
            {
                if (conta.Login == "" || conta.Login == null)
                {
                    json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "AVISO!", Msg = "Login ou Senha Invalido!" });
                }
                else
                {
                    if (conta.Logado)
                    {
                        json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "Usuario Logado", Msg = "Esse Usuario Ja esta logado. Caso não seja você por favor entre em contato eisindico.acmesistemas.com.br/help ou ligue: (35) 99920-6354." });
                    }
                    else
                    {
                        conta.Logado = true;
                        bool atualizado = true;//_contaAplication.Update(conta);
                        conta.DataModificacao = DateTime.Now;
                        conta.Login = login;
                        if (conta.Login != "" && conta.Login != null && atualizado)
                        {
                            json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = false, Titulo = "Usuario", Msg = "Usuario Logado Com Sucesso!" });
                            conta.Usuario.Contas = null;
                            PermissaoContaViewModel permissaoConta = conta.PermissoesContas.Where(t => t.ContaId == conta.Id).First<PermissaoContaViewModel>();
                            permissaoConta.Conta.PermissoesContas = null;
                            permissaoConta.Permissao.PermissoesContas = null;
                            SessionExtensions.SetObject<PermissaoContaViewModel>(HttpContext.Session, "Conta", permissaoConta);
                            SessionExtensions.SetObject<List<Parametro>>(HttpContext.Session, "Parametro", _parametroAplication.GetAll());

                            var permissao = new AutorizacaoConta(_contaApplication, _permissaoMenuApplication, login, senha);
                            List<Claim> claims = new List<Claim>(){
                                new Claim(ClaimTypes.Name, conta.Usuario.Nome),
                                new Claim(ClaimTypes.NameIdentifier, conta.Usuario.Id.ToString()),
                                new Claim(ClaimTypes.Role, permissao.Permissoes.FirstOrDefault().Nome),
                                new Claim(ClaimTypes.Email, conta.Usuario.Email),
                                new Claim("Login", conta.Login),
                                new Claim("Read", permissaoConta.Read.ToString()),
                                new Claim("Delete", permissaoConta.Delete.ToString()),
                                new Claim("Insert", permissaoConta.Add.ToString()),
                                new Claim("Update", permissaoConta.Update.ToString()),
                            };

                            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                            AuthenticationProperties authenticationProperties = new AuthenticationProperties
                            {
                                AllowRefresh = true,
                                IsPersistent = continuarLogado,
                                RedirectUri = returnUrl
                            };
                            SessionExtensions.SetObject<List<PermissaoViewModel>>(HttpContext.Session, "Permissoes", _mapper.Map<List<PermissaoViewModel>>(permissao.Permissoes));
                            SessionExtensions.SetObject<List<MenuViewModel>>(HttpContext.Session, "Menu", _mapper.Map<List<MenuViewModel>>(permissao.Menus));

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);

                            return RedirectToLocal(returnUrl);

                        }
                        else
                        {
                            if (atualizado)
                            {
                                json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "AVISO!", Msg = "Login ou Senha Invalido!" });
                            }
                            else
                            {
                                json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "AVISO!", Msg = "Foram encontrados alguns problemas por favor entre em contato eisindico.acmesistemas.com.br/help ou ligue: (35) 99920-6354.!" });
                            }
                        }

                    }
                }
            }
            else
            {
                json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "Usuario Inativo", Msg = "Usuario Inativo!" });
            }
            return View();
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl))
            {
                if (Url.IsLocalUrl(returnUrl))
                {
                    string[] dado = returnUrl.Trim().Split('/');
                    return RedirectToAction(dado[2], dado[1]);
                }
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            else
            {
                return RedirectToAction("Index", "Usuario");
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Logout(string login)
        {
            var json = "";
            var conta = _contaApplication.GetContaByLogin(login);
            if (conta.Status.Equals(EnumStatus.Ativo))
            {
                if (conta.Logado)
                {
                    SessionExtensions.Remove<ContaViewModel>(HttpContext.Session, "Conta");
                    SessionExtensions.Remove<List<PermissaoViewModel>>(HttpContext.Session, "Permissoes");
                    SessionExtensions.Remove<List<MenuViewModel>>(HttpContext.Session, "Menu");
                    conta.Logado = false;
                    conta.DataModificacao = DateTime.Now;
                    _contaApplication.Update(conta,NOME_SISTEMA);
                    json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = false, Titulo = "Sucesso!", Msg = "Até mais, volte sempre!" });

                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    return RedirectToLocal("/Conta/Login");
                }
                else
                {
                    try
                    {
                        SessionExtensions.Remove<ContaViewModel>(HttpContext.Session, "Conta");
                        SessionExtensions.Remove<List<PermissaoViewModel>>(HttpContext.Session, "Permissoes");
                        SessionExtensions.Remove<List<MenuViewModel>>(HttpContext.Session, "Menu");
                    }
                    catch { }
                    conta.Login = login;
                    if (conta.Login != "" && conta.Login != null)
                    {
                        json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "Usuario", Msg = "Usuario não esta mais logado no sistema!" });
                    }
                }
            }
            else
            {
                json = JsonConvert.SerializeObject(new ResponseViewModel { Erro = true, Titulo = "Usuario Inativo", Msg = "Usuario Inativo!" });
            }

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToLocal("/Conta/Login");
        }



    }
}
