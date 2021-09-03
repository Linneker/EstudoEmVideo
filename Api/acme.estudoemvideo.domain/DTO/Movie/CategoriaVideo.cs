using acme.estudoemvideo.domain.DTO.Movie.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie
{
    public class CategoriaVideo : AbstractEntity
    {
        public DateTime? DataCadastro { get; set; }

        public Guid VideoId { get; set; }
        public Guid CategoriaId { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }
    }
}
