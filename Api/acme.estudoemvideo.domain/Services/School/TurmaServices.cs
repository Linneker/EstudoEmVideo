using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School
{
    public class TurmaServices: ServiceBase<Turma>, ITurmaServices
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaServices(ITurmaRepository turmaRepository):base(turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }
    }
}
