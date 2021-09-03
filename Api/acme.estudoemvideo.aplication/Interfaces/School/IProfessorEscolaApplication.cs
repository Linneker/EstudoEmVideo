using acme.estudoemvideo.domain.DTO.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.School
{
    public interface IProfessorEscolaApplication : IApplicationBase<ProfessorEscola>
    {
        List<ProfessorEscola> GetProfessorEscolaByEscolaId(Guid escolaId);
        Task<List<ProfessorEscola>> GetProfessorEscolaByEscolaIdAsync(Guid escolaId);

    }
}
