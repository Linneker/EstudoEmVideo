using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Diary
{
    public interface IAnoLetivoApplication : IApplicationBase<AnoLetivo>
    {
        Task<List<AnoLetivo>> GetAnoLetivoByDiaLetivoAsync(bool diaLetivo);
        List<AnoLetivo> GetAnoLetivoByDiaLetivo(bool diaLetivo);

    }
}
