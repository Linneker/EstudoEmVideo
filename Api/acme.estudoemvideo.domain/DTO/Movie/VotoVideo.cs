using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie
{
    public class VotoVideo : AbstractEntity
    {
        public VotoVideo()
        {
            LikeRelevancia = 0L;
            ListaLike = new List<long>();
        }

        public long LikeRelevancia { get; set; }
        [NotMapped]
        public List<long> ListaLike { get; set; }
        public string Observacao { get; set; }
        public long QuantidadeLike { get; set; }
        public Guid VideoId { get; set; }
        public Guid UsuarioId { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuarios { get; set; }
    }
}
