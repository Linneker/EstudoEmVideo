using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class MateriaProfessorEscola : AbstractEntity
    {
        public Guid MateriaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }
        
        public Materia Materia { get; set; }
        public ProfessorEscola ProfessorEscola { get; set; }

    }
}
