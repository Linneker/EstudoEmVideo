using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.School.Matter
{
    public interface IMateriaServices : IServicesBase<Materia>
    {
        List<Materia> GetMateriasByProfessorId(Guid professorId);
        Task<List<Materia>> GetMateriasByProfessorIdAsync(Guid professorId);
    }
}
