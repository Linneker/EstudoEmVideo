using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Diary
{
    public class AgendaApplication :ApplicationBase<Agenda>, IAgendaApplication
    {
        private readonly IAgendaServices _agendaServices;

        public AgendaApplication(IAgendaServices agendaServices):base(agendaServices)
        {
            _agendaServices = agendaServices;
        }

        public List<Agenda> GetAgendaByData(DateTime dataCompromisso)
        {
            return _agendaServices.GetAgendaByData(dataCompromisso);
        }

        public Task<List<Agenda>> GetAgendaByDataAsync(DateTime dataCompromisso)
        {
            return _agendaServices.GetAgendaByDataAsync(dataCompromisso);
        }

        public List<Agenda> GetAgendaByProva(bool isProva)
        {
            return _agendaServices.GetAgendaByProva(isProva);
        }

        public Task<List<Agenda>> GetAgendaByProvaAsync(bool isProva)
        {
            return _agendaServices.GetAgendaByProvaAsync(isProva);
        }
    }
}
