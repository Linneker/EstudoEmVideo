using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Util
{
    public class SerieServices: ServiceBase<Serie>, ISerieServices
    {
        private readonly ISerieRepository _serieRepository;

        public SerieServices(ISerieRepository serieRepository):base(serieRepository)
        {
            _serieRepository = serieRepository;
        }
    }
}
