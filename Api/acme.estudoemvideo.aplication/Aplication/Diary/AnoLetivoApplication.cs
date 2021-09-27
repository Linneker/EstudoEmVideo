using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Diary
{
    public class AnoLetivoApplication : ApplicationBase<AnoLetivo>, IAnoLetivoApplication
    {
        private readonly IAnoLetivoServices _anoLetivoServices;

        public AnoLetivoApplication(IAnoLetivoServices anoLetivoServices):base(anoLetivoServices)
        {
            _anoLetivoServices = anoLetivoServices;
        }

        public List<AnoLetivo> GetAnoLetivoByDiaLetivo(bool diaLetivo)
        {
            return _anoLetivoServices.GetAnoLetivoByDiaLetivo(diaLetivo);
        }

        public Task<List<AnoLetivo>> GetAnoLetivoByDiaLetivoAsync(bool diaLetivo)
        {
            return _anoLetivoServices.GetAnoLetivoByDiaLetivoAsync(diaLetivo);
        }
    }
}
