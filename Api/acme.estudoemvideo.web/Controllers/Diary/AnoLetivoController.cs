using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.util.ViewModel.Diary;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.Diary
{
    public class AnoLetivoController : LayoutBaseController<AnoLetivo, AnoLetivoViewModel>
    {
        private readonly IAnoLetivoApplication _anoLetivoApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "AnoLetivo";
        private const string CAMINHO = "/AnoLetivo";
        private readonly IMenuApplication _menuApplication;
        public AnoLetivoController(IAnoLetivoApplication anoLetivoApplication, IMapper mapper, IMenuApplication menuApplication) :base(anoLetivoApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _anoLetivoApplication = anoLetivoApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

    }
}
