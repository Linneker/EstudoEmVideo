using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Diary
{
    public interface IAnoLetivoRepository : IRepositoryBase<AnoLetivo>
    {
        Task<List<AnoLetivo>> GetAnoLetivoByDiaLetivoAsync(bool diaLetivo);
        List<AnoLetivo> GetAnoLetivoByDiaLetivo(bool diaLetivo);
    }
}
