using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace acme.estudoemvideo.domain.DTO.School.Question
{
    public class Resposta : AbstractEntity
    {
        public Resposta()
        {
            PerguntasQuestionarios = new HashSet<PerguntaQuestionario>();
        }
        public string Descricao { get; set; }
        public int Relevancia { get; set; }

        public DateTime DataInseridaResposta { get; set; }

        public Guid UsuarioId { get; set; }

        public Guid PerguntaId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        [ForeignKey("PerguntaId")]
        public virtual Pergunta Pergunta { get; set; }


        public virtual ICollection<PerguntaQuestionario> PerguntasQuestionarios { get; set; }
    }
}
