using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Matter
{
    public class ConteudoMateriaRepository : RepositoryBase<ConteudoMateria>, IConteudoMateriaRepository
    {
        public ConteudoMateriaRepository(Context db) : base(db)
        {
        }
    }
}
