using acme.estudoemvideo.util.ViewModel.Negocio;
using acme.estudoemvideo.util.ViewModel.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School
{
    public class EscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Escola", TITULO_MODAL = "ESCOLA", URL_DOIS = "/Escola/GetDadosTable", ID_TABLE = "tabela_escola", CAMPOS_TABELA = "";

        public EscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            AlunosEscolas = new HashSet<AlunoEscolaViewModel>();
            Turmas = new HashSet<TurmaViewModel>();
            ProfessorEscolas = new HashSet<ProfessorEscolaViewModel>();
            EnderecoEscolas = new HashSet<EnderecoEscolaViewModel>();
        }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public virtual ICollection<AlunoEscolaViewModel> AlunosEscolas { get; set; }
        public virtual ICollection<ProfessorEscolaViewModel> ProfessorEscolas{ get; set; }
        public virtual ICollection<EnderecoEscolaViewModel> EnderecoEscolas { get; set; }
        public virtual ICollection<TurmaViewModel> Turmas { get; set; }
    }
}
