using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Util
{
    public class BimestreServices: ServiceBase<Bimestre>, IBimestreServices
    {
        private readonly IBimestreRepository bimestreRepository;

        public BimestreServices(IBimestreRepository bimestreRepository):base(bimestreRepository)
        {
            this.bimestreRepository = bimestreRepository;
        }
    }
}
