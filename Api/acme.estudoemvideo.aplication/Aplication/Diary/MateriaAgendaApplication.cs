using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.Diary
{
    public class MateriaAgendaApplication : ApplicationBase<MateriaAgenda>, IMateriaAgendaApplication
    {
        private readonly IMateriaAgendaServices _materiaAgendaServices;

        public MateriaAgendaApplication(IMateriaAgendaServices materiaAgendaServices):base(materiaAgendaServices)
        {
            _materiaAgendaServices = materiaAgendaServices;
        }
    }
}
