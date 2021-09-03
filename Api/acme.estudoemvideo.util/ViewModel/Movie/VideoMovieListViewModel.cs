using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie
{
    public class VideoMovieListViewModel : AbstractEntityViewModel
    {
        private const string URL = "/VideoMovieList", TITULO_MODAL = "VÍDEO MOVIE LIST", URL_DOIS = "/VideoMovieList/GetDadosTable", ID_TABLE = "tabela_video_movie_list", CAMPOS_TABELA = "";

        public VideoMovieListViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }

        public DateTime? DataLigacao { get; set; }

        public virtual MovieListViewModel MovieList { get; set; }
        public virtual VideoViewModel Video { get; set; }
    }
}
