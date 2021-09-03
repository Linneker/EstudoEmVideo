using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace acme.estudoemvideo.infra.Repository.Util
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(Context db) : base(db)
        {
        }

        public Endereco GetEnderecoByCep(string cep)
        {
            var endereco = (from endCep in _db.Enderecos
                            where endCep.Cep.Equals(cep)
                            select endCep).FirstOrDefault();
            return endereco;
        }
    }
}
