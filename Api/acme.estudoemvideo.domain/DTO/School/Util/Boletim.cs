using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.DTO.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class Boletim : AbstractEntity
    {
        public Guid AlunoEscolaId { get; set; }
        public Guid MateriaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }
        public Guid NotaAlunoMateriaProfessorId { get; set; }
        public int TotalFaltas { get; set; }


        public virtual Materia Materia { get; set; }
        public virtual ProfessorEscola ProfessorEscola { get; set; }
        public virtual AlunoEscola AlunoEscola { get; set; }
        public virtual NotaAlunoMateriaProfessor NotaAlunoMateriaProfessor { get; set; }

    }
}
