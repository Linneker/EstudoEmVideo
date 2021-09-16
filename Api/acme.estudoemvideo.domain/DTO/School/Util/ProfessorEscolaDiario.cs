using acme.estudoemvideo.domain.DTO.Diary;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class ProfessorEscolaDiario : AbstractEntity
    {
        public Guid ProfessorEscolaId { get; set; }
        public Guid DiarioId { get; set; }

        public virtual ProfessorEscola ProfessorEscola { get; set; }
        public virtual Diario Diario { get; set; }
    }
}
