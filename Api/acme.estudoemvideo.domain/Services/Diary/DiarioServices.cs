using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Diary
{
    public class DiarioServices : ServiceBase<Diario>, IDiarioServices
    {
        private readonly IDiarioRepository _diarioRepository;

        public DiarioServices(IDiarioRepository diarioRepository):base(diarioRepository)
        {
            _diarioRepository = diarioRepository;
        }

        public List<Diario> GetDiarioByAnoLetivoId(Guid anoLetivoId)
        {
            return _diarioRepository.GetDiarioByAnoLetivoId(anoLetivoId);
        }

        public Task<List<Diario>> GetDiarioByAnoLetivoIdAsync(Guid anoLetivoId)
        {
            return _diarioRepository.GetDiarioByAnoLetivoIdAsync(anoLetivoId);
        }
    }
}
