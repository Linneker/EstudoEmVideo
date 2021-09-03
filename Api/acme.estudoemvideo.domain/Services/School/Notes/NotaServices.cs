using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Notes
{
    public class NotaServices: ServiceBase<Nota>, INotaServices
    {
        private readonly INotaRepository _notaRepository;

        public NotaServices(INotaRepository notaRepository):base(notaRepository)
        {
            _notaRepository = notaRepository;
        }
    }
}
