using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.Util
{
    public class EnderecoApplication: ApplicationBase<Endereco>, IEnderecoApplication
    {
        private readonly IEnderecoServices _enderecoServices;

        public EnderecoApplication(IEnderecoServices enderecoServices):base(enderecoServices)
        {
            _enderecoServices = enderecoServices;
        }

        public Endereco GetEnderecoByCep(string cep)
        {
            return _enderecoServices.GetEnderecoByCep(cep);
        }
 
    }
}
