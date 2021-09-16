using acme.estudoemvideo.domain.DTO.School.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.School.Util
{
    public interface IBoletimRepository : IRepositoryBase<Boletim>
    {
        List<Boletim> GetBoletinsByAlunoEscolaId(Guid alunoEscolaId);
        Task<List<Boletim>> GetBoletinsByAlunoEscolaIdAsync(Guid alunoEscolaId);

        List<Boletim> GetBoletinsByNotaAlunoMateriaProfessorId(Guid NotaAlunoMateriaProfessorId);
        Task<List<Boletim>> GetBoletinsByNotaAlunoMateriaProfessorIdAsync(Guid NotaAlunoMateriaProfessorId);
    }
}
