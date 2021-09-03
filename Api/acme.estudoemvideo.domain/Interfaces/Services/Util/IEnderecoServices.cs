using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Interfaces.Services.Util
{
    public interface IEnderecoServices: IServicesBase<Endereco>
    {
        Endereco GetEnderecoByCep(string cep);
    }
}
