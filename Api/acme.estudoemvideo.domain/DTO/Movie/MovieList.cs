using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie
{
    public class MovieList : AbstractEntity
    {

        public MovieList() {
            VideosMovieList = new HashSet<VideoMovieList>();
            MovieListUsuarios = new HashSet<MovieListUsuario>();
        }

        public string NomeLista { get; set; }
        public string CaminhoLista { get; set; }

        public virtual ICollection<VideoMovieList> VideosMovieList { get; set; }
        public virtual ICollection<MovieListUsuario> MovieListUsuarios { get; set; }
    }
}
