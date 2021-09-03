using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Question
{
    public class PerguntaQuestionarioViewModel : AbstractEntityViewModel
    {
        private const string URL = "/PerguntaQuestionario", TITULO_MODAL = "PERGUNTA QUESTIONARIO", URL_DOIS = "/PerguntaQuestionario/GetDadosTable", ID_TABLE = "tabela_pergunta_questionario", CAMPOS_TABELA = "";

        public PerguntaQuestionarioViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public DateTime DataVinculo { get; set; }
        
        public Guid QuestionarioId { get; set; }
        public Guid PerguntaId { get; set; }
        public Guid RespostaId { get; set; }

        [ForeignKey("QuestionarioId")]
        public virtual QuestionarioViewModel Questionario { get; set; }
        [ForeignKey("PerguntaId")]
        public virtual PerguntaViewModel Pergunta { get; set; }
        [ForeignKey("RespostaId")]
        public virtual RespostaViewModel Resposta { get; set; }
    }
}
