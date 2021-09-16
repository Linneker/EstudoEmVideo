using acme.estudoemvideo.domain.DTO.School.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.School.Util
{
    public interface IBoletimServices : IServicesBase<Boletim> 
    {
        List<Boletim> GetBoletinsByAlunoEscolaId(Guid alunoEscolaId);
        Task<List<Boletim>> GetBoletinsByAlunoEscolaIdAsync(Guid alunoEscolaId);

        List<Boletim> GetBoletinsByNotaAlunoMateriaProfessorId(Guid NotaAlunoMateriaProfessorId);
        Task<List<Boletim>> GetBoletinsByNotaAlunoMateriaProfessorIdAsync(Guid NotaAlunoMateriaProfessorId);

    }
}
