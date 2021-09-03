using acme.estudoemvideo.util.ViewModel.School.Matter.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class ArquivoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Arquivo", TITULO_MODAL="ARQUIVO", URL_DOIS= "/Arquivo/GetDadosTable", ID_TABLE="tabela_arquivo", CAMPOS_TABELA="";

        public ArquivoViewModel():base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            Apostilas = new HashSet<ApostilaViewModel>();
            Livros = new HashSet<LivroViewModel>();
        }

        public string NomeArquivoSalvo { get; set; }
        public string NomeArquivo { get; set; }
        public string Url { get; set; }
        public string HashArquivo { get; set; }

        public virtual ICollection<ApostilaViewModel> Apostilas { get; set; }
        public virtual ICollection<LivroViewModel> Livros { get; set; }

    }
}
