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
    public class AlunoEscolaRepository : RepositoryBase<AlunoEscola>, IAlunoEscolaRepository
    {
        public AlunoEscolaRepository(Context db) : base(db)
        {
        }

        public List<AlunoEscola> GetAlunoEscolaByDataMatricula(DateTime dataMatricula)
        {
            var query = (from ae in _db.AlunoEscolas
                         where ae.DataAlunoEscola == dataMatricula
                         select ae).AsNoTracking().ToList<AlunoEscola>();
            return query;
        }
        public Task<List<AlunoEscola>> GetAlunoEscolaByDataMatriculaAsync(DateTime dataMatricula)
        {
            var query = (from ae in _db.AlunoEscolas
                         where ae.DataAlunoEscola == dataMatricula
                         select ae).AsNoTracking().ToListAsync<AlunoEscola>();
            return query;
        }

        public List<AlunoEscola> GetAlunoEscolaByEscolaId(Guid escolaId)
        {
            var query = (from ae in _db.AlunoEscolas
                         where ae.EscolaId.Equals(escolaId)
                         select ae).AsNoTracking().ToList();
            return query;
        }

        public Task<List<AlunoEscola>> GetAlunoEscolaByEscolaIdAsync(Guid escolaId)
        {
            var query = (from ae in _db.AlunoEscolas
                         where ae.EscolaId.Equals(escolaId)
                         select ae).Include(t=>t.Aluno).ThenInclude(t=>t.Contas).AsNoTracking().ToListAsync<AlunoEscola>();
            return query;
        }

        public List<AlunoEscola> GetAlunoEscolaByMatricula(long matricula)
        {
            var query = (from alEsc in _db.AlunoEscolas
                         join aluno in _db.Usuarios on alEsc.Aluno.Id equals aluno.Id
                         join escola in _db.Escolas on alEsc.Escola.Id equals escola.Id
                         where alEsc.Matricula == matricula
                         select alEsc).AsNoTracking().ToList<AlunoEscola>();
            return query;
        }
        public Task<List<AlunoEscola>> GetAlunoEscolaByMatriculaAsync(long matricula)
        {
            var query = (from alEsc in _db.AlunoEscolas
                         join aluno in _db.Usuarios on alEsc.Aluno.Id equals aluno.Id
                         join escola in _db.Escolas on alEsc.Escola.Id equals escola.Id
                         where alEsc.Matricula == matricula
                         select alEsc).AsNoTracking().ToListAsync<AlunoEscola>();
            return query;
        }
    }
}
