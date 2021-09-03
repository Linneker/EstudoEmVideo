using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Util
{
    public class TurmaAlunoEscolaServices : ServiceBase<TurmaAlunoEscola>, ITurmaAlunoEscolaServices
    {
        private readonly ITurmaAlunoEscolaRepository _turmaAlunoEscolaRepository;

        public TurmaAlunoEscolaServices(ITurmaAlunoEscolaRepository turmaAlunoEscolaRepository):base(turmaAlunoEscolaRepository)
        {
            _turmaAlunoEscolaRepository = turmaAlunoEscolaRepository;
        }
    }
}
