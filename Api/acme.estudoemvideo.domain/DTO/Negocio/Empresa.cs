using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Negocio
{
    [NotMapped]
    public abstract class Empresa : AbstractEntity
    {
        public Empresa()
        {
            EnderecosEmpresa = new HashSet<EnderecoEmpresa>();
        }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        
        public virtual ICollection<EnderecoEmpresa> EnderecosEmpresa { get; set; }
    }
}
