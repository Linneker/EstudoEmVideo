using acme.estudoemvideo.domain.DTO.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.School
{
    public interface IProfessorEscolaRepository : IRepositoryBase<ProfessorEscola>
    {
        List<ProfessorEscola> GetProfessorEscolaByEscolaId(Guid escolaId);
        Task<List<ProfessorEscola>> GetProfessorEscolaByEscolaIdAsync(Guid escolaId);
    }
}
