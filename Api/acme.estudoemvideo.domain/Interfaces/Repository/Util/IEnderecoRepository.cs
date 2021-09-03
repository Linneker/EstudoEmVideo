using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Util
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        Endereco GetEnderecoByCep(string cep);
    }
}
