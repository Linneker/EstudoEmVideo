using acme.estudoemvideo.util.ViewModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie
{
    public class VideoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Video", TITULO_MODAL = "VIDEO", URL_DOIS = "/Video/GetDadosTable", ID_TABLE = "tabela_video", CAMPOS_TABELA = "";

        public VideoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            MovieListVideos = new HashSet<VideoMovieListViewModel>();
            CategoriasVideos = new HashSet<CategoriaVideoViewModel>();
        }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Arquivo")]
        public string NomeArquivo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public string Caminho { get; set; }
        [Display(Name = "Popularidade")]
        public EnumPopularidadeViewModel? EnumPopularidade { get; set; }
        public long? Visualizacao { get; set; }
        [Display(Name = "Popularidade")]
        public decimal? PopularidadeEmNumero { get; set; }

        [NotMapped]
        public sbyte[] VideoByte { get; set; }

        public virtual ICollection<VideoMovieListViewModel> MovieListVideos { get; set; }
        public virtual ICollection<CategoriaVideoViewModel> CategoriasVideos { get; set; }

    }
}
