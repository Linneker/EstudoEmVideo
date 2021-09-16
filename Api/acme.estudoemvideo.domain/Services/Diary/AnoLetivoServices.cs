using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Diary
{
    public class AnoLetivoServices : ServiceBase<AnoLetivo>, IAnoLetivoServices
    {
        private readonly IAnoLetivoRepository _anoLetivoRepository;

        public AnoLetivoServices(IAnoLetivoRepository anoLetivoRepository):base(anoLetivoRepository)
        {
            _anoLetivoRepository = anoLetivoRepository;
        }

        public List<AnoLetivo> GetAnoLetivoByDiaLetivo(bool diaLetivo)
        {
            return _anoLetivoRepository.GetAnoLetivoByDiaLetivo(diaLetivo);
        }

        public Task<List<AnoLetivo>> GetAnoLetivoByDiaLetivoAsync(bool diaLetivo)
        {
            return _anoLetivoRepository.GetAnoLetivoByDiaLetivoAsync(diaLetivo);
        }
    }
}
