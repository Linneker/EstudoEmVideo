using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie
{
    public class MovieListUsuario : AbstractEntity
    {
        public bool? Download { get; set; }
        public bool? Favorito { get; set; }

        public Guid MovieListId { get; set; }
        public Guid UsuarioId { get; set; }

        [ForeignKey("MovieListId")]
        public virtual MovieList MovieList { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
    }
}
