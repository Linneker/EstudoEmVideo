using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace acme.estudoemvideo.infra.Repository.Diary
{
    public class AgendaRepository : RepositoryBase<Agenda>, IAgendaRepository
    {
        public AgendaRepository(Context db) : base(db)
        {
        }

        public List<Agenda> GetAgendaByData(DateTime dataCompromisso)
        {
            List<Agenda> agendas = (from dtComp in _db.Agendas
                                    where dtComp.DataCompromisso == dataCompromisso
                                    select dtComp).AsNoTracking().ToList();
            return agendas;
        }

        public Task<List<Agenda>> GetAgendaByDataAsync(DateTime dataCompromisso)
        {
            Task<List<Agenda>> agendas = (from dtComp in _db.Agendas
                                    where dtComp.DataCompromisso == dataCompromisso
                                    select dtComp).AsNoTracking().ToListAsync();
            return agendas;
        }

        public List<Agenda> GetAgendaByProva(bool isProva)
        {
            List<Agenda> agendas = (from dtComp in _db.Agendas
                                          where dtComp.Prova == isProva
                                          select dtComp).AsNoTracking().ToList();
            return agendas;
        }

        public Task<List<Agenda>> GetAgendaByProvaAsync(bool isProva)
        {
            Task<List<Agenda>> agendas = (from dtComp in _db.Agendas
                                          where dtComp.Prova == isProva
                                          select dtComp).AsNoTracking().ToListAsync();
            return agendas;
        }
    }
}
