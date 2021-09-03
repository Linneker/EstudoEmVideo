using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Question
{
    public class Questionario : AbstractEntity
    {
        public Questionario()
        {
            PerguntasQuestionarios = new HashSet<PerguntaQuestionario>();
        }

        public int TotalPerguntas { get; set; }
        public Guid UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public virtual ICollection<PerguntaQuestionario> PerguntasQuestionarios { get; set; }
    }
}
