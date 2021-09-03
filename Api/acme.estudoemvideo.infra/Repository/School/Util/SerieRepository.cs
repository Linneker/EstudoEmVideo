using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Util
{
    public class SerieRepository : RepositoryBase<Serie>, ISerieRepository
    {
        public SerieRepository(Context db) : base(db)
        {
        }
    }
}
