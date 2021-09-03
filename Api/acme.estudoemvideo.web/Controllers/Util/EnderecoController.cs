using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Util
{
    public class EnderecoController : LayoutBaseController<Endereco,EnderecoViewModel>
    {
        private readonly IMapper _mapper;
        private const string NOME_SERVICO = "USUARIO";
        private const string CAMINHO_SISTEMA = "/Usuario";
        private readonly IMenuApplication _menuApplication;
        private readonly IParametroAplication _parametroAplication;
        private readonly IPermissaoMenuApplication _permissaoMenuApplication;
        private readonly IEnderecoApplication _enderecoAplication;
        public EnderecoController(IEnderecoApplication enderecoAplication,IMapper mapper, IMenuApplication menuApplication, 
            IParametroAplication parametroAplication, 
            IPermissaoMenuApplication permissaoMenuApplication):base(enderecoAplication,NOME_SERVICO,CAMINHO_SISTEMA,menuApplication,mapper)
        {
            _mapper = mapper;
            _menuApplication = menuApplication;
            _parametroAplication = parametroAplication;
            _permissaoMenuApplication = permissaoMenuApplication;
        }

        public override IActionResult Index()
        {
            return View();
        }
    }
}
