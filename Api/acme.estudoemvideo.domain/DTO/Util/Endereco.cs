using acme.estudoemvideo.domain.DTO.Negocio;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.User;
using System.Collections.Generic;

namespace acme.estudoemvideo.domain.DTO.Util
{
   public class Endereco : AbstractEntity
    {
        public Endereco()
        {
            EnderecoEmpresas = new HashSet<EnderecoEmpresa>();
            EnderecoUsuarios = new HashSet<EnderecoUsuario>();
            EnderecoEscolas = new HashSet<EnderecoEscola>();
        }

        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }

        public virtual ICollection<EnderecoEscola> EnderecoEscolas { get; set; }
        public virtual ICollection<EnderecoEmpresa> EnderecoEmpresas { get; set; }
        public virtual ICollection<EnderecoUsuario> EnderecoUsuarios { get; set; }
    }
}
