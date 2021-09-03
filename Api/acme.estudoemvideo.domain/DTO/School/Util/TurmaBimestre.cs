using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class TurmaBimestre : AbstractEntity
    {
        public Guid BimestreId { get; set; }
        public Guid TurmaId { get; set; }

        public virtual Turma Turma { get; set; }
        public virtual Bimestre Bimestre { get; set; }

    }
}
