using acme.estudoemvideo.util.ViewModel.Movie.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie
{
    public class CategoriaVideoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/CategoriaVideo", TITULO_MODAL = "CATEGORIA VIDEO", URL_DOIS = "/CategoriaVideo/GetDadosTable", ID_TABLE = "tabela_categoria_video", CAMPOS_TABELA = "";

        public CategoriaVideoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }

        public DateTime? DataCadastro { get; set; }

        public virtual VideoViewModel Video { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
    }
}
