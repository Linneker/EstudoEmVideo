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
    public class AnoLetivoRepository : RepositoryBase<AnoLetivo>, IAnoLetivoRepository
    {
        public AnoLetivoRepository(Context db) : base(db)
        {
        }

        public List<AnoLetivo> GetAnoLetivoByDiaLetivo(bool diaLetivo)
        {
            List<AnoLetivo> anoLetivos = (from al in _db.AnoLetivos
                                          where al.DiaLetivo == diaLetivo
                                          select al).AsNoTracking().ToList();
            return anoLetivos;
        }

        public Task<List<AnoLetivo>> GetAnoLetivoByDiaLetivoAsync(bool diaLetivo)
        {
            Task<List<AnoLetivo>> anoLetivos = (from al in _db.AnoLetivos
                                          where al.DiaLetivo == diaLetivo
                                          select al).AsNoTracking().ToListAsync();
            return anoLetivos;
        }
    }
}
