using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Negocio
{
    public class EnderecoEmpresa : AbstractEntity
    {

        public int NumeroEmpresa { get; set; }
        public string Complemento { get; set; }

        public Guid EnderecoId { get; set; }
        public Guid EmpresaId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }
        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresa { get; set; }
    }
}
