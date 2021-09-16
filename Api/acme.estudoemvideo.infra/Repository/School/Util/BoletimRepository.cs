using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.School.Util
{
    public class BoletimRepository : RepositoryBase<Boletim>, IBoletimRepository
    {
        public BoletimRepository(Context db) : base(db)
        {
        }

        public List<Boletim> GetBoletinsByAlunoEscolaId(Guid alunoEscolaId)
        {
            List<Boletim> boletins = (from blts in _db.Boletins
                                      where blts.AlunoEscolaId.Equals(alunoEscolaId)
                                      select blts).Include(t => t.Materia)
                                      .Include(t => t.NotaAlunoMateriaProfessor)
                                      .Include(t => t.AlunoEscola).ThenInclude(t => t.Usuario)
                                      .Include(t => t.ProfessorEscola).ThenInclude(t => t.Usuario).AsNoTracking().ToList();
            return boletins;
        }

        public Task<List<Boletim>> GetBoletinsByAlunoEscolaIdAsync(Guid alunoEscolaId)
        {
           Task<List<Boletim>> boletins = (from blts in _db.Boletins
                                      where blts.AlunoEscolaId.Equals(alunoEscolaId)
                                      select blts).Include(t => t.Materia)
                                                .Include(t => t.NotaAlunoMateriaProfessor)
                                                .Include(t => t.AlunoEscola).ThenInclude(t => t.Usuario)
                                                .Include(t => t.ProfessorEscola).ThenInclude(t => t.Usuario).AsNoTracking().ToListAsync();
            return boletins;
        }

        public List<Boletim> GetBoletinsByNotaAlunoMateriaProfessorId(Guid notaAlunoMateriaProfessorId)
        {
            List<Boletim> boletins = (from blts in _db.Boletins
                                            where blts.NotaAlunoMateriaProfessorId.Equals(notaAlunoMateriaProfessorId)
                                            select blts).Include(t => t.Materia)
                                                       .Include(t => t.NotaAlunoMateriaProfessor)
                                                       .Include(t => t.AlunoEscola).ThenInclude(t => t.Usuario)
                                                       .Include(t => t.ProfessorEscola).ThenInclude(t => t.Usuario).AsNoTracking().ToList();
            return boletins;
        }

        public Task<List<Boletim>> GetBoletinsByNotaAlunoMateriaProfessorIdAsync(Guid notaAlunoMateriaProfessorId)
        {
            Task<List<Boletim>> boletins = (from blts in _db.Boletins
                                            where blts.NotaAlunoMateriaProfessorId.Equals(notaAlunoMateriaProfessorId)
                                            select blts).Include(t => t.Materia)
                                                     .Include(t => t.NotaAlunoMateriaProfessor)
                                                     .Include(t => t.AlunoEscola).ThenInclude(t => t.Usuario)
                                                     .Include(t => t.ProfessorEscola).ThenInclude(t => t.Usuario).AsNoTracking().ToListAsync();
            return boletins;
        }
    }
}
