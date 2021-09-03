using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Matter
{
    public class ConteudoRepository : RepositoryBase<Conteudo>, IConteudoRepository
    {
        public ConteudoRepository(Context db) : base(db)
        {
        }
    }
}
