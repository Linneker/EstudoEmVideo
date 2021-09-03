using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.User
{
    public class EnderecoUsuario : AbstractEntity
    {
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Guid UsuarioId { get; set; }
        public Guid EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

    }
}
