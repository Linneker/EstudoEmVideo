using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class FrequenciaAlunoMateria : AbstractEntity
    {
        public Guid AlunoEscolaId { get; set; }
        public Guid MateriaId { get; set; }
        public Guid AgendaId { get; set; }

        public int QuantidadeFalta{ get; set; }
        public int QuantidadePresenca { get; set; }
        public int QuantidadeFaltaJustificada { get; set; }
        public string JustificativaFalta { get; set; }

        public AlunoEscola AlunoEscola { get; set; }
        public Materia Materia { get; set; }
        public Agenda Agenda { get; set; }
    }
}
