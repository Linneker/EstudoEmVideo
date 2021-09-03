using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.School.Notes
{
    public class NotaAlunoMateriaProfessorServices : ServiceBase<NotaAlunoMateriaProfessor>, INotaAlunoMateriaProfessorServices
    {
        private readonly INotaAlunoMateriaProfessorRepository _notaAlunoMateriaProfessorRepository;

        public NotaAlunoMateriaProfessorServices(INotaAlunoMateriaProfessorRepository notaAlunoMateriaProfessorRepository) : base(notaAlunoMateriaProfessorRepository)
        {
            _notaAlunoMateriaProfessorRepository = notaAlunoMateriaProfessorRepository;
        }

    }
}
