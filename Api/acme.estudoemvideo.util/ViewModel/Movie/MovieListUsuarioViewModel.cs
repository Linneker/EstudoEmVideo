using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie
{
    public class MovieListUsuarioViewModel : AbstractEntityViewModel
    {
        private const string URL = "/MovieListUsuario", TITULO_MODAL = "MOVIE LIST USUARIO", URL_DOIS = "/MovieListUsuario/GetDadosTable", ID_TABLE = "tabela_movie_list_usuario", CAMPOS_TABELA = "";

        public MovieListUsuarioViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }

        public bool? Download { get; set; }
        public bool? Favorito { get; set; }
        

        public virtual MovieListViewModel MovieList { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
    }
}
