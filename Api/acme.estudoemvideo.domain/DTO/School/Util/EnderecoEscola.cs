using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class EnderecoEscola : AbstractEntity
    {
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Guid EnderecoId { get; set; }
        public Guid EscolaId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }
        [ForeignKey("EscolaId")]
        public virtual Escola Escola{ get; set; }
    }
}
