using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Question
{
    public class PerguntaQuestionario : AbstractEntity
    {
        public DateTime DataVinculo { get; set; }
        
        public Guid QuestionarioId { get; set; }
        public Guid PerguntaId { get; set; }
        public Guid RespostaId { get; set; }

        [ForeignKey("QuestionarioId")]
        public virtual Questionario Questionario { get; set; }
        [ForeignKey("PerguntaId")]
        public virtual Pergunta Pergunta { get; set; }
        [ForeignKey("RespostaId")]
        public virtual Resposta Resposta { get; set; }
    }
}
