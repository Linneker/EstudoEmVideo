using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.School.Matter
{
    public interface IMateriaApplication : IApplicationBase<Materia>
    {
        List<Materia> GetMateriasByProfessorId(Guid escolaId);
        Task<List<Materia>> GetMateriasByProfessorIdAsync(Guid escolaId);

    }
}
