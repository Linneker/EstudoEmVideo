using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie
{
    public class VideoMovieList : AbstractEntity
    {
        public DateTime? DataLigacao { get; set; }

        public Guid MovieListId { get; set; }
        public Guid VideoId { get; set; }

        [ForeignKey("MovieListId")]
        public virtual MovieList MovieList { get; set; }
        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }
    }
}
