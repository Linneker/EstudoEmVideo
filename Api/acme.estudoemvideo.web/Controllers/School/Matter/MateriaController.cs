using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.util.ViewModel.School.Matter;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Matter
{
    public class MateriaController : LayoutBaseController<Materia, MateriaViewModel>
    {
        private readonly IMateriaApplication _materiaApplication;
        private readonly IMapper _mapper;
        private readonly IMenuApplication _menuApplication;
        private const string NOME_METODO = "MATERIA";
        private const string CAMINHO = "/Materia";
        public MateriaController(IMateriaApplication materiaApplication, IMenuApplication menuApplication, IMapper mapper) : base(materiaApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _materiaApplication = materiaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }

        [Authorize]
        [HttpGet]
        public async Task<List<Materia>> GetMateriasByProfessorId(string professorId)
        {
            string[] professores = professorId.Split(",");
            List<Materia> materias = null;
            foreach (var professor in professores)
            {
                if (materias == null)
                    materias = await _materiaApplication.GetMateriasByProfessorIdAsync(Guid.Parse(professor));
                else
                {
                    var mats = await _materiaApplication.GetMateriasByProfessorIdAsync(Guid.Parse(professor));
                    foreach (var mat in mats)
                    {
                        materias.Add(mat);
                    }
                }

            }

            var elementos =  materias.GroupBy(t => new { 
                t.Id,
                t.Nome
            }).Select(t=>new Materia{ 
                Id = t.Key.Id,
                Nome = t.Key.Nome
            }).ToList();
            return elementos;
        }
    }
}
