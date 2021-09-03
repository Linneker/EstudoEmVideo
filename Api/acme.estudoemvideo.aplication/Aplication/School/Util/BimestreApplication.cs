using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School.Util
{
    public class BimestreApplication : ApplicationBase<Bimestre>, IBimestreApplication
    {
        private readonly IBimestreServices _bimestreServices;

        public BimestreApplication(IBimestreServices bimestreServices):base(bimestreServices)
        {
            _bimestreServices = bimestreServices;
        }
    }
}
