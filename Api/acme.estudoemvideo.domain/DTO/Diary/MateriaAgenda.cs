using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Diary
{
    public class MateriaAgenda : AbstractEntity
    {
        public DateTime DataCadastro { get; set; }
        public Guid MateriaId { get; set; }
        public Guid AgendaId { get; set; }

        [ForeignKey("MateriaId")]
        public virtual Materia Materia{get;set;}
        [ForeignKey("AgendaId")]
        public virtual Agenda Agenda { get; set; }
    }
}
