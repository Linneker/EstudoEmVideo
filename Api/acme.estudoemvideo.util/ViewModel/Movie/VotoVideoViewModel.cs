using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Movie
{
    public class VotoVideoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/VotoVideo", TITULO_MODAL = "VOTO VÍDEO", URL_DOIS = "/VotoVideo/GetDadosTable", ID_TABLE = "tabela_voto_video", CAMPOS_TABELA = "";


        public VotoVideoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            LikeRelevancia = 0L;
            ListaLike = new List<long>();
        }

        public long LikeRelevancia { get; set; }
        public List<long> ListaLike { get; set; }
        public string Observacao { get; set; }

        public virtual VideoViewModel Video { get; set; }
        public virtual UsuarioViewModel Usuarios { get; set; }
    }
}
