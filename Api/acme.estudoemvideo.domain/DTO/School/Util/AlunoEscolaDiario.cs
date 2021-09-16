using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class AlunoEscolaDiario : AbstractEntity
    {
        public Guid AlunoEscolaId { get; set; }
        public Guid DiarioId { get; set; }

        public virtual AlunoEscola AlunoEscola { get; set; }
        public virtual Diario Diario { get; set; }
    }
}
