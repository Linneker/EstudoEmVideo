using acme.estudoemvideo.aplication.Interfaces.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using acme.estudoemvideo.domain.Services.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School.Notes
{
    public class NotaAlunoMateriaProfessorApplication : ApplicationBase<NotaAlunoMateriaProfessor>, INotaAlunoMateriaProfessorApplication
    {
        private readonly INotaAlunoMateriaProfessorServices _notaAlunoMateriaProfessorServices;
        public NotaAlunoMateriaProfessorApplication(INotaAlunoMateriaProfessorServices  notaAlunoMateriaProfessorServices) :base(notaAlunoMateriaProfessorServices)
        {
            _notaAlunoMateriaProfessorServices = notaAlunoMateriaProfessorServices;
        }
    }
}
