using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.util.ViewModel.School.Matter;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Matter
{
    public class ConteudoController : LayoutBaseController<Conteudo,ConteudoViewModel>
    {
        private readonly IConteudoApplication _conteudoApplication;
        private readonly IMapper _mapper;
        private readonly IMenuApplication _menuApplication;
        private const string NOME_METODO = "CONTEUDO";
        private const string CAMINHO = "/Conteudo";

        public ConteudoController(IConteudoApplication conteudoApplication, IMapper mapper, IMenuApplication menuApplication)
            :base(conteudoApplication,NOME_METODO,CAMINHO,menuApplication,mapper)
        {
            _conteudoApplication = conteudoApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

    }
}
