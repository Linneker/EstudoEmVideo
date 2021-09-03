using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Matter
{
    public class ConteudoServices: ServiceBase<Conteudo>, IConteudoServices
    {
        private readonly IConteudoRepository _conteudoRepository;

        public ConteudoServices(IConteudoRepository conteudoRepository):base(conteudoRepository)
        {
            _conteudoRepository = conteudoRepository;
        }
    }
}
