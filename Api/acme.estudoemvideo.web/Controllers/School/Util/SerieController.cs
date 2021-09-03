using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.School.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Util
{
    public class SerieController : LayoutBaseController<Serie,SerieViewModel>
    {
        private readonly ISerieApplication _serieApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "SERIE";
        private const string CAMINHO = "/Serie";
        private readonly IMenuApplication _menuApplication;

        public SerieController(ISerieApplication aplicationBase, 
            IMenuApplication menuApplication, IMapper mapper) : base(aplicationBase, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _serieApplication = aplicationBase;
            _menuApplication = menuApplication;
            _mapper = mapper;
        }
      
    }
}
