using acme.estudoemvideo.domain.DTO.School.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.School.Util
{
    public interface IBoletimApplication: IApplicationBase<Boletim>
    {
        List<Boletim> GetBoletinsByAlunoEscolaId(Guid alunoEscolaId);
        Task<List<Boletim>> GetBoletinsByAlunoEscolaIdAsync(Guid alunoEscolaId);

        List<Boletim> GetBoletinsByNotaAlunoMateriaProfessorId(Guid notaAlunoMateriaProfessorId);
        Task<List<Boletim>> GetBoletinsByNotaAlunoMateriaProfessorIdAsync(Guid notaAlunoMateriaProfessorId);

    }
}
