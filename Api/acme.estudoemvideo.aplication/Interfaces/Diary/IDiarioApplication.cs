using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Diary
{
    public interface IDiarioApplication : IApplicationBase<Diario>
    {
        List<Diario> GetDiarioByAnoLetivoId(Guid anoLetivoId);
        Task<List<Diario>> GetDiarioByAnoLetivoIdAsync(Guid anoLetivoId);
    }
}
