using acme.estudoemvideo.domain.DTO.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie
{
    public class Video : AbstractEntity
    {
        public Video()
        {
            MovieListVideos = new HashSet<VideoMovieList>();
            CategoriasVideos = new HashSet<CategoriaVideo>();
            VotoVideos = new HashSet<VotoVideo>();
        }

        public string Nome { get; set; }

        public string NomeArquivo { get; set; }
        public string Descricao { get; set; }
        public string Caminho { get; set; }
        public EnumPopularidade? EnumPopularidade { get; set; }
        public long? Visualizacao { get; set; }
        public decimal? PopularidadeEmNumero { get; set; }

        [NotMapped]
        public sbyte[] VideoByte { get; set; }

        public virtual ICollection<VideoMovieList> MovieListVideos { get; set; }
        public virtual ICollection<CategoriaVideo> CategoriasVideos { get; set; }
        public virtual ICollection<VotoVideo> VotoVideos { get; set; }
    }
}
