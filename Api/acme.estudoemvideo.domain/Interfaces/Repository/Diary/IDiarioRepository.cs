using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Diary
{
    public interface IDiarioRepository : IRepositoryBase<Diario>
    {
        List<Diario> GetDiarioByAnoLetivoId(Guid anoLetivoId);
        Task<List<Diario>> GetDiarioByAnoLetivoIdAsync(Guid anoLetivoId);
    }
}
