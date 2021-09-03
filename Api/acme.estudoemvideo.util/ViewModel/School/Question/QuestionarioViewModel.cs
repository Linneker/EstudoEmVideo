using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Question
{
    public class QuestionarioViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Questionario", TITULO_MODAL = "QUESTIONARIO", URL_DOIS = "/Questionario/GetDadosTable", ID_TABLE = "tabela_questionario", CAMPOS_TABELA = "";

        public QuestionarioViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            PerguntasQuestionarios = new HashSet<PerguntaQuestionarioViewModel>();
        }

        public int TotalPerguntas { get; set; }
        public Guid UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public virtual ICollection<PerguntaQuestionarioViewModel> PerguntasQuestionarios { get; set; }
    }
}
