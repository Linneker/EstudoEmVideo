using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.domain.Interfaces.Services.School.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Question
{
    public class QuestionarioServices: ServiceBase<Questionario>, IQuestionarioServices
    {
        private readonly IQuestionarioRepository _questionarioRepository;

        public QuestionarioServices(IQuestionarioRepository questionarioRepository):base(questionarioRepository)
        {
            _questionarioRepository = questionarioRepository;
        }
    }
}
