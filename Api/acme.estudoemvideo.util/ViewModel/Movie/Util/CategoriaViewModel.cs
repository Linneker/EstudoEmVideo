using acme.estudoemvideo.util.ViewModel.Enum;
using acme.estudoemvideo.util.ViewModel.Movie;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie.Util
{
    public class CategoriaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Categoria", TITULO_MODAL = "CATEGORIA", URL_DOIS = "/Categoria/GetDadosTable", ID_TABLE = "tabela_categoria", CAMPOS_TABELA = "";

        public CategoriaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            CategoriasVideos = new HashSet<CategoriaVideoViewModel>();
        }
        public string Nome { get; set; }
        public EnumTipoCategoriaViewModel Tipo { get; set; }
        
        public virtual ICollection<CategoriaVideoViewModel> CategoriasVideos { get; set; }
    }
}
