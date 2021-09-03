using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie
{
    public class MovieListViewModel : AbstractEntityViewModel
    {
        private const string URL = "/MovieList", TITULO_MODAL = "MOVIE LIST", URL_DOIS = "/MovieList/GetDadosTable", ID_TABLE = "tabela_movie_list", CAMPOS_TABELA = "";

        public MovieListViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA) {
            VideosMovieList = new HashSet<VideoMovieListViewModel>();
            MovieListUsuarios = new HashSet<MovieListUsuarioViewModel>();
        }

        public string NomeLista { get; set; }
        public string CaminhoLista { get; set; }

        public virtual ICollection<VideoMovieListViewModel> VideosMovieList { get; set; }
        public virtual ICollection<MovieListUsuarioViewModel> MovieListUsuarios { get; set; }
    }
}
