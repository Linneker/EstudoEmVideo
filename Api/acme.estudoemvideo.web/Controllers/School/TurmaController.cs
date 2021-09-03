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
    public class TurmaController : LayoutBaseController<Turma,TurmaViewModel>
    {
        private readonly ITurmaApplication _turmaApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "TURMA";
        private const string CAMINHO = "/Turma";
        private readonly IMenuApplication _menuApplication;

        public TurmaController(ITurmaApplication turmaApplication, IMapper mapper, IMenuApplication menuApplication):
            base(turmaApplication,NOME_METODO,CAMINHO,menuApplication,mapper)
        {
            _turmaApplication = turmaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

       

    }
}
