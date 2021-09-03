using acme.estudoemvideo.domain.DTO.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.School
{
    public interface IProfessorEscolaServices : IServicesBase<ProfessorEscola>
    {
        List<ProfessorEscola> GetProfessorEscolaByEscolaId(Guid escolaId);
        Task<List<ProfessorEscola>> GetProfessorEscolaByEscolaIdAsync(Guid escolaId);

    }
}
