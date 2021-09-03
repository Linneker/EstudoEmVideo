using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.School
{
    public class ProfessorEscolaRepository : RepositoryBase<ProfessorEscola>, IProfessorEscolaRepository
    {
        public ProfessorEscolaRepository(Context db) : base(db)
        {
        }

        public List<ProfessorEscola> GetProfessorEscolaByEscolaId(Guid escolaId)
        {
            List<ProfessorEscola> professorEscolas = (from prfEscola in _db.ProfessorEscolas
                                                      where prfEscola.EscolaId.Equals(escolaId)
                                                      select prfEscola).Include(t => t.Usuario).ThenInclude(t => t.Contas).ToList();
            return professorEscolas;
        }

        public Task<List<ProfessorEscola>> GetProfessorEscolaByEscolaIdAsync(Guid escolaId)
        {
            Task<List<ProfessorEscola>> professorEscolas = (from prfEscola in _db.ProfessorEscolas
                                                      where prfEscola.EscolaId.Equals(escolaId)
                                                      select prfEscola).Include(t=>t.Usuario).ThenInclude(t=>t.Contas).ToListAsync();
            return professorEscolas;
        }
    }
}
