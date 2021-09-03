using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Question
{
    public class PerguntaQuestionarioRepository : RepositoryBase<PerguntaQuestionario>, IPerguntaQuestionarioRepository
    {
        public PerguntaQuestionarioRepository(Context db) : base(db)
        {
        }
    }
}
