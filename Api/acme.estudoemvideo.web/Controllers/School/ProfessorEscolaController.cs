using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.util.Util;
using acme.estudoemvideo.util.ViewModel.School;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School
{
    public class ProfessorEscolaController : LayoutBaseController<ProfessorEscola, ProfessorEscolaViewModel>
    {
        private readonly IProfessorEscolaApplication _professorEscolaApplication;
        private readonly IMapper _mapper;
        private const string NOME_SERVICO = "Professor da Escola";
        private const string CAMINHO_SISTEMA = "/ProfessorEscola";
        private readonly IMenuApplication _menuApplication;
        private readonly IParametroAplication _parametroAplication;

        public ProfessorEscolaController(IProfessorEscolaApplication professorEscolaApplication,
            IMapper mapper, IMenuApplication menuApplication, IParametroAplication parametroAplication) : base(professorEscolaApplication,
                NOME_SERVICO, CAMINHO_SISTEMA, menuApplication, mapper)
        {
            _professorEscolaApplication = professorEscolaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
            _parametroAplication = parametroAplication;
        }
      

        //[Authorize]
        //[HttpGet]
        //public List<ProfessorEscolaViewModel> GetProfessorEscolaByEscolaId(Guid escolaId)
        //{
        //    return _mapper.Map<List<ProfessorEscolaViewModel>>(_professorEscolaApplication.GetProfessorEscolaByEscolaId(escolaId));
        //}
        [Authorize]
        [HttpGet]
        public Task<string> GetProfessorEscolaByEscolaIdAsync(Guid escolaId)
        {
            var elemento = (_professorEscolaApplication.GetProfessorEscolaByEscolaIdAsync(escolaId));
            var profesorresJsonString = JsonConvertEstudoEmVideo<List<ProfessorEscola>>.SerializeAsync(elemento.Result);
           //var profesorres = JsonConvertEstudoEmVideo<List<ProfessorEscola>>.DescerializeAsync(alunosJsonString);

            return profesorresJsonString;
        }

    }
}
