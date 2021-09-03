using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class TurmaProfessorEscola : AbstractEntity
    {
        public Guid TurmaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }

        public Turma Turma { get; set; }
        public ProfessorEscola ProfessorEscola { get; set; }
    }
}
