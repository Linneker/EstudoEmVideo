using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class TurmaMateria : AbstractEntity
    {
        public Guid TurmaId { get; set; }
        public Guid MateriaId { get; set; }

        public Turma Turma { get; set; }
        public Materia Materia { get; set; }
    }
}
