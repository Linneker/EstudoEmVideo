using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Question;
using acme.estudoemvideo.domain.Interfaces.Services.School.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Question
{
    public class RespostaServices: ServiceBase<Resposta>, IRespostaServices
    {
        private readonly IRespostaRepository _respostaRepository;

        public RespostaServices(IRespostaRepository respostaRepository):base(respostaRepository)
        {
            _respostaRepository = respostaRepository;
        }
    }
}
