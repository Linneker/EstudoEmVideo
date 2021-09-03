using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Question
{
    public class Pergunta : AbstractEntity
    {
        public Pergunta()
        {
            PerguntasQuestionarios = new HashSet<PerguntaQuestionario>();
            Respostas = new HashSet<Resposta>();
        }

        public string Descricao { get; set; }

        public DateTime DataPergunta { get; set; }

        public virtual ICollection<PerguntaQuestionario> PerguntasQuestionarios { get; set; }
        public virtual ICollection<Resposta> Respostas{ get; set; }

    }
}
