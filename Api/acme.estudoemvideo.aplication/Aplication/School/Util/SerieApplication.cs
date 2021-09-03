using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School.Util
{
    public class SerieApplication : ApplicationBase<Serie>, ISerieApplication
    {
        private readonly ISerieServices _serieServices;

        public SerieApplication(ISerieServices serieServices):base(serieServices)
        {
            _serieServices = serieServices;
        }
    }
}
