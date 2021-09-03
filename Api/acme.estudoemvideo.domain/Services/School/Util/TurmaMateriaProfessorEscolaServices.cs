using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Util
{
    public class TurmaMateriaProfessorEscolaServices: ServiceBase<TurmaProfessorEscola>, ITurmaMateriaProfessorEscolaServices
    {
        private readonly ITurmaMateriaProfessorEscolaRepository _turmaMateriaProfessorEscolaRepository;

        public TurmaMateriaProfessorEscolaServices(ITurmaMateriaProfessorEscolaRepository turmaMateriaProfessorEscolaRepository):base(turmaMateriaProfessorEscolaRepository)
        {
            _turmaMateriaProfessorEscolaRepository = turmaMateriaProfessorEscolaRepository;
        }
    }
}
