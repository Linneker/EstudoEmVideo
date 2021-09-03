using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.School.Matter
{
    public class MateriaRepository : RepositoryBase<Materia>, IMateriaRepository
    {
        public MateriaRepository(Context db) : base(db)
        {
        }

        public List<Materia> GetMateriasByProfessorId(Guid professorId)
        {
            List<Materia> query = (from materia in _db.Materias
                                   join professor in _db.MateriaProfessorEscolas on materia.Id equals professor.MateriaId
                                   where professor.ProfessorEscolaId.Equals(professorId)
                                   select materia).AsNoTracking().ToList();
            return query;
        }

        public Task<List<Materia>> GetMateriasByProfessorIdAsync(Guid professorId)
        {
            var query = (from materia in _db.Materias
                                   join professor in _db.MateriaProfessorEscolas on materia.Id equals professor.MateriaId
                                   where professor.ProfessorEscolaId.Equals(professorId)
                                   select materia).AsNoTracking().AsQueryable().ToListAsync();
            return query;
        }
    }
}
