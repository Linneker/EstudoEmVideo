using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.School.Matter
{
    public class MateriaApplication :ApplicationBase<Materia>, IMateriaApplication
    {
        private readonly IMateriaServices _materiaServices;

        public MateriaApplication(IMateriaServices materiaServices):base(materiaServices)
        {
            _materiaServices = materiaServices;
        }

        public List<Materia> GetMateriasByProfessorId(Guid escolaId)
        {
            return _materiaServices.GetMateriasByProfessorId(escolaId);
        }

        public Task<List<Materia>> GetMateriasByProfessorIdAsync(Guid escolaId)
        {
            return _materiaServices.GetMateriasByProfessorIdAsync(escolaId);
        }
    }
}
