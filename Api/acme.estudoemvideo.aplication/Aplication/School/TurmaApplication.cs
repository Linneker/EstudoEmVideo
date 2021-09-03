using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Services;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School
{
    public class TurmaApplication : ApplicationBase<Turma>, ITurmaApplication
    {
        private readonly ITurmaServices _turmaServices;

        public TurmaApplication(ITurmaServices repositoryBase) : base(repositoryBase)
        {
            _turmaServices = repositoryBase;
        }
    }
}
