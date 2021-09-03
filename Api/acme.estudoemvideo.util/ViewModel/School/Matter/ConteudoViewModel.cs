using acme.estudoemvideo.util.ViewModel.School.Matter.Books;
using acme.estudoemvideo.util.ViewModel.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Matter
{
    public class ConteudoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Conteudo", TITULO_MODAL = "CONTEUDO", URL_DOIS = "/Conteudo/GetDadosTable", ID_TABLE = "tabela_conteudo", CAMPOS_TABELA = "";

        public ConteudoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            ConteudosMaterias = new HashSet<ConteudoMateriaViewModel>();
            Apostilas = new HashSet<ApostilaViewModel>();
            Livros = new HashSet<LivroViewModel>();
            NotaAlunoMateriaConteudos = new HashSet<NotaAlunoMateriaConteudoViewModel>();
        }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<ConteudoMateriaViewModel> ConteudosMaterias { get; set; }
        public virtual ICollection<LivroViewModel> Livros { get; set; }
        public virtual ICollection<ApostilaViewModel> Apostilas { get; set; }
        public virtual ICollection<NotaAlunoMateriaConteudoViewModel> NotaAlunoMateriaConteudos { get; set; }

    }
}
