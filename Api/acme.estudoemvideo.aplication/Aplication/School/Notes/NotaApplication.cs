using acme.estudoemvideo.aplication.Interfaces.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School.Notes
{
    public class NotaApplication : ApplicationBase<Nota>, INotaApplication
    {
        private readonly INotaServices _notaServices;

        public NotaApplication(INotaServices notaServices):base(notaServices)
        {
            _notaServices = notaServices;
        }
    }
}
