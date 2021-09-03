using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.School.Matter
{
    public interface IMateriaRepository : IRepositoryBase<Materia>
    {
        List<Materia> GetMateriasByProfessorId(Guid escolaId);
        Task<List<Materia>> GetMateriasByProfessorIdAsync(Guid escolaId);
    }
}
