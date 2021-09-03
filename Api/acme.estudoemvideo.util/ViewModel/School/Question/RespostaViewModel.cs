using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace acme.estudoemvideo.util.ViewModel.School.Question
{
    public class RespostaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Resposta", TITULO_MODAL = "RESPOSTA", URL_DOIS = "/Resposta/GetDadosTable", ID_TABLE = "tabela_resposta", CAMPOS_TABELA = "";

        public RespostaViewModel(): base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            PerguntasQuestionarios = new HashSet<PerguntaQuestionarioViewModel>();
        }
        public string Descricao { get; set; }
        public int Relevancia { get; set; }

        public DateTime DataInseridaResposta { get; set; }

        public Guid UsuarioId { get; set; }

        public Guid PerguntaId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        [ForeignKey("PerguntaId")]
        public virtual PerguntaViewModel Pergunta { get; set; }


        public virtual ICollection<PerguntaQuestionarioViewModel> PerguntasQuestionarios { get; set; }
    }
}
