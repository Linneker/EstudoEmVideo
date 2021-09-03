using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School.Matter
{
    public class ConteudoApplication : ApplicationBase<Conteudo>, IConteudoApplication
    {
        private readonly IConteudoServices _conteudoServices;

        public ConteudoApplication(IConteudoServices conteudoServices) : base(conteudoServices)
        {
            _conteudoServices = conteudoServices;
        }

    }
}
