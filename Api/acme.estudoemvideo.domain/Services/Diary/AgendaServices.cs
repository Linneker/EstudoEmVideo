using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Diary
{
    public class AgendaServices : ServiceBase<Agenda>, IAgendaServices
    {
        private readonly IAgendaRepository _agendaRepository;

        public AgendaServices(IAgendaRepository agendaRepository):base(agendaRepository)
        {
            _agendaRepository = agendaRepository;
        }

        public List<Agenda> GetAgendaByData(DateTime dataCompromisso)
        {
            return _agendaRepository.GetAgendaByData(dataCompromisso);
        }

        public Task<List<Agenda>> GetAgendaByDataAsync(DateTime dataCompromisso)
        {
            return _agendaRepository.GetAgendaByDataAsync(dataCompromisso); 
        }

        public List<Agenda> GetAgendaByProva(bool isProva)
        {
            return _agendaRepository.GetAgendaByProva(isProva);
        }

        public Task<List<Agenda>> GetAgendaByProvaAsync(bool isProva)
        {
            return _agendaRepository.GetAgendaByProvaAsync(isProva);
        }
    }
}
