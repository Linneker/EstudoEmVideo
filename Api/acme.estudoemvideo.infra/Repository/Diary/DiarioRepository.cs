using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Diary
{
    public class DiarioRepository : RepositoryBase<Diario>, IDiarioRepository
    {
        public DiarioRepository(Context db) : base(db)
        {
        }

        public List<Diario> GetDiarioByAnoLetivoId(Guid anoLetivoId)
        {
            List<Diario> diarios = (from diario in _db.Diarios
                                    where diario.AnoLetivoId.Equals(anoLetivoId)
                                    select diario).Include(t => t.ProfessoresEscolassDiarios)
                                     .Include(t => t.AlunoEscolasDiarios).ToList();
            return diarios;
        }

        public Task<List<Diario>> GetDiarioByAnoLetivoIdAsync(Guid anoLetivoId)
        {
            Task<List<Diario>> diarios = (from diario in _db.Diarios
                                    where diario.AnoLetivoId.Equals(anoLetivoId)
                                    select diario).Include(t => t.ProfessoresEscolassDiarios)
                                     .Include(t => t.AlunoEscolasDiarios).ToListAsync();
            return diarios;
        }
    }
}
