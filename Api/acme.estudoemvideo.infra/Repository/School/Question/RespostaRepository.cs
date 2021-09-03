using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Question
{
    public class RespostaRepository : RepositoryBase<Resposta>, IRespostaRepository
    {
        public RespostaRepository(Context db) : base(db)
        {
        }
    }
}
