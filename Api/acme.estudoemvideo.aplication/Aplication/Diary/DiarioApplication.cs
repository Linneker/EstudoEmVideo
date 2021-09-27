using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Diary
{
    public class DiarioApplication : ApplicationBase<Diario>, IDiarioApplication
    {
        private readonly IDiarioServices _diarioServices;

        public DiarioApplication(IDiarioServices diarioServices):base(diarioServices)
        {
            _diarioServices = diarioServices;
        }

        public List<Diario> GetDiarioByAnoLetivoId(Guid anoLetivoId)
        {
            return _diarioServices.GetDiarioByAnoLetivoId(anoLetivoId);
        }

        public Task<List<Diario>> GetDiarioByAnoLetivoIdAsync(Guid anoLetivoId)
        {
            return _diarioServices.GetDiarioByAnoLetivoIdAsync(anoLetivoId);
        }
    }
}
