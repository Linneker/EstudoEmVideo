using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Seguranca;
using acme.estudoemvideo.services.Services.Security.User;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Seguranca;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace acme.estudoemvideo.web.Controllers.Security
{
    public class AutorizacaoApiController : LayoutBaseController<AutorizacaoApi, AutorizacaoApiViewModel>
    {
        private readonly IAutorizacaoApiAplication _autorizacaoApiAplication;
        private readonly IMenuApplication _menuApplication;
        private const string NOME_METODO = "AUTORIZAÇÃO API";
        private const string CAMINHO_PADRAO = "/AutorizacaoApi";
        private readonly IMapper _mapper;
        private IWebHostEnvironment _appEnvironment;
        private readonly ILogger<AutorizacaoApi> _logger;

        public AutorizacaoApiController(IAutorizacaoApiAplication autorizacaoApiAplication, IMenuApplication menuApplication, IMapper mapper,
            IWebHostEnvironment appEnvironment, ILogger<AutorizacaoApi> logger) : base(autorizacaoApiAplication, NOME_METODO, CAMINHO_PADRAO, menuApplication, mapper)
        {
            _autorizacaoApiAplication = autorizacaoApiAplication;
            _menuApplication = menuApplication;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
            _logger = logger;
        }

        public override IActionResult Index()
        {
            List<AutorizacaoApiViewModel> autorizacoes = _mapper.Map<List<AutorizacaoApiViewModel>>(_autorizacaoApiAplication.GetAll());
            return View(autorizacoes);
        }

        [AllowAnonymous]
        [HttpPost]
        public RespostaPadraoModels CadastroAutorizacao(AutorizacaoApiViewModel cnpj)
        {
            cnpj.AccessKey = new AutorizacaoConta().GeraKey(cnpj.CnpjEmpresa);
            var retornoo = _mapper.Map<RespostaPadraoModels>(_autorizacaoApiAplication.Add(_mapper.Map<AutorizacaoApi>(cnpj), NOME_METODO));
            return retornoo;
        }

    }
}
