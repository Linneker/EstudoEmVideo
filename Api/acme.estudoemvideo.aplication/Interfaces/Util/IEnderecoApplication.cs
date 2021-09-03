using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Interfaces.Util
{
    public interface IEnderecoApplication: IApplicationBase<Endereco>
    {
        Endereco GetEnderecoByCep(string cep);
    }
}
