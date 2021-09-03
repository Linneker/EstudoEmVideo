using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Question
{
    public class PerguntaRepository : RepositoryBase<Pergunta>, IPerguntaRepository
    {
        public PerguntaRepository(Context db) : base(db)
        {
        }
    }
}
