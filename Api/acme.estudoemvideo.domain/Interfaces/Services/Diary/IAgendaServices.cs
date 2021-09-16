using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.Diary
{
    public interface IAgendaServices : IServicesBase<Agenda>
    {
        Task<List<Agenda>> GetAgendaByProvaAsync(bool isProva);
        List<Agenda> GetAgendaByProva(bool isProva);

        Task<List<Agenda>> GetAgendaByDataAsync(DateTime dataCompromisso);
        List<Agenda> GetAgendaByData(DateTime dataCompromisso);
    }
}
