using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class TurmaAlunoEscola : AbstractEntity
    {
        public Guid TurmaId { get; set; }
        public Guid AlunoEscolaId { get; set; }

        public virtual Turma Turma { get; set; }
        public virtual AlunoEscola AlunoEscola { get; set; }
    }
}
