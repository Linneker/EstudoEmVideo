using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.School.Matter
{
    public class MateriaServices : ServiceBase<Materia>, IMateriaServices
    {
        private readonly IMateriaRepository _materiaRepository;

        public MateriaServices(IMateriaRepository materiaRepository) : base(materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        public List<Materia> GetMateriasByProfessorId(Guid professorId)
        {
            return _materiaRepository.GetMateriasByProfessorId(professorId);
        }

        public Task<List<Materia>> GetMateriasByProfessorIdAsync(Guid professorId)
        {
            return _materiaRepository.GetMateriasByProfessorIdAsync(professorId);
        }
    }
}
