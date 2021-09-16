using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.Diary
{
    public class MateriaAgendaServices: ServiceBase<MateriaAgenda>, IMateriaAgendaServices
    {
        private readonly IMateriaAgendaRepository _materiaAgendaRepository;

        public MateriaAgendaServices(IMateriaAgendaRepository materiaAgendaRepository):base(materiaAgendaRepository)
        {
            _materiaAgendaRepository = materiaAgendaRepository;
        }
    }
}
