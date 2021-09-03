using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Question
{
    public class PerguntaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Pergunta", TITULO_MODAL = "PERGUNTA", URL_DOIS = "/Pergunta/GetDadosTable", ID_TABLE = "tabela_pergunta", CAMPOS_TABELA = "";

        public PerguntaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            PerguntasQuestionarios = new HashSet<PerguntaQuestionarioViewModel>();
            Respostas = new HashSet<RespostaViewModel>();
        }

        public string Descricao { get; set; }

        public DateTime DataPergunta { get; set; }

        public virtual ICollection<PerguntaQuestionarioViewModel> PerguntasQuestionarios { get; set; }
        public virtual ICollection<RespostaViewModel> Respostas{ get; set; }

    }
}
