using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.User
{
    public class EnderecoServices: ServiceBase<Endereco>, IEnderecoServices
    {
        private IEnderecoRepository _enderecoRepository;

        public EnderecoServices(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public Endereco GetEnderecoByCep(string cep)
        {
            return _enderecoRepository.GetEnderecoByCep(cep);
        }
    }
}
