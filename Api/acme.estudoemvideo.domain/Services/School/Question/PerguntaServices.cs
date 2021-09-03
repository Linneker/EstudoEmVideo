using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.domain.Interfaces.Services.School.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Question
{
    public class PerguntaServices: ServiceBase<Pergunta>, IPerguntaServices
    {
        private readonly IPerguntaRepository _perguntaRepository;

        public PerguntaServices(IPerguntaRepository perguntaRepository):base(perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }
    }
}
