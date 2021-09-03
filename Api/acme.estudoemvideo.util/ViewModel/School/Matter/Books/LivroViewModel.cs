using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Matter.Books
{
    public class LivroViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Livro", TITULO_MODAL = "LIVRO", URL_DOIS = "/Livro/GetDadosTable", ID_TABLE = "tabela_livro", CAMPOS_TABELA = "";

        public LivroViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        [NotMapped]
        public sbyte[] LivroDigital { get; set; }

        public string Bibliografia { get; set; }

        public Guid ArquivoId { get; set; }
        public Guid ConteudoId { get; set; }

        [ForeignKey("ConteudoId")]
        public ConteudoViewModel Conteudo { get; set; }
        public Arquivo Arquivo { get; set; }
    }
}
