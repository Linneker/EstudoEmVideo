using acme.estudoemvideo.util.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Matter.Books
{
    public class ApostilaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Apostila", TITULO_MODAL = "APOSTILA", URL_DOIS = "/Apostila/GetDadosTable", ID_TABLE = "tabela_apostila", CAMPOS_TABELA = "";

        public ApostilaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }


        [NotMapped]
        public sbyte[] ApostilaDigital { get; set; }
        public string Bibliografia { get; set; }
        public Guid ArquivoId { get; set; }

        public Guid ConteudoId { get; set; }

        [ForeignKey("ConteudoId")]
        public ConteudoViewModel Conteudo { get; set; }

        [ForeignKey("ArquivoId")]
        public ArquivoViewModel Arquivo { get; set; }

    }
}
