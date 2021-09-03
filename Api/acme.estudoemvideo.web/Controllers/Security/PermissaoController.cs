using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Security
{
    public class PermissaoController : LayoutBaseController<Permissao,PermissaoViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IPermissaoAplication _permissaoAplication;
        private readonly IMenuApplication _menuApplication;
        private const string NOME_SERVICO = "PERMISSAO";
        private const string CAMINHO = "/permissao";

        public PermissaoController(IMapper mapper, IPermissaoAplication permissaoAplication, IMenuApplication menuApplication):base(permissaoAplication,NOME_SERVICO,CAMINHO,menuApplication,mapper)
        {
            _mapper = mapper;
            _permissaoAplication = permissaoAplication;
            _menuApplication = menuApplication;
        }

        public override IActionResult Index()
        {
            List<PermissaoViewModel> permissoes = _mapper.Map<List<PermissaoViewModel>>(_permissaoAplication.GetAll());
            return View(permissoes);
        }
    }
}
