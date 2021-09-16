using acme.estudoemvideo.aplication.Interfaces.School.Notes;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.util.ViewModel.School.Notes;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Notes
{
    public class NotaController : LayoutBaseController<Nota, NotaViewModel>
    {
        private readonly INotaApplication _notaApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "NOTA";
        private const string CAMINHO = "/Nota";
        private readonly IMenuApplication _menuApplication;

        public NotaController(INotaApplication notaApplication, IMapper mapper, IMenuApplication menuApplication) : base(notaApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _notaApplication = notaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }
      
    }
}
