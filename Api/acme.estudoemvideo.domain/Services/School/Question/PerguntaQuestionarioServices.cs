using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.domain.Interfaces.Services.School.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Question
{
    public class PerguntaQuestionarioServices: ServiceBase<PerguntaQuestionario>, IPerguntaQuestionarioServices
    {
        private readonly IPerguntaQuestionarioRepository _perguntaQuestionarioRepository;

        public PerguntaQuestionarioServices(IPerguntaQuestionarioRepository perguntaQuestionarioRepository):base(perguntaQuestionarioRepository)
        {
            _perguntaQuestionarioRepository = perguntaQuestionarioRepository;
        }
    }
}
