using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Matter
{
    public class ConteudoMateriaServices: ServiceBase<ConteudoMateria>, IConteudoMateriaServices
    {
        private readonly IConteudoMateriaRepository _conteudoMateriaRepository;

        public ConteudoMateriaServices(IConteudoMateriaRepository conteudoMateriaRepository):base(conteudoMateriaRepository)
        {
            _conteudoMateriaRepository = conteudoMateriaRepository;
        }
    }
}
