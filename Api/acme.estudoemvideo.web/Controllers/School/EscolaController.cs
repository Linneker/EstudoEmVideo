using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.util.ViewModel.School;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School
{
    public class EscolaController : LayoutBaseController<Escola,EscolaViewModel>
    {
        private readonly IEscolaApplication _escolaApplication;
        private readonly IMapper _mapper;
        private const string NOME_SERVICO = "USUARIO";
        private const string CAMINHO_SISTEMA = "/Usuario";
        private readonly IMenuApplication _menuApplication;
        private readonly IParametroAplication _parametroAplication;

        public EscolaController(IEscolaApplication aplicationBase,IMenuApplication menuApplication, IMapper mapper, IParametroAplication parametroAplication) : base(aplicationBase, NOME_SERVICO, CAMINHO_SISTEMA, menuApplication, mapper)
        {
            _escolaApplication = aplicationBase;
            _mapper = mapper;
            _menuApplication = menuApplication;
            _parametroAplication = parametroAplication;
        }

        public override IActionResult Index()
        {
            return View(new List<EscolaViewModel>());
        }
    }
}
