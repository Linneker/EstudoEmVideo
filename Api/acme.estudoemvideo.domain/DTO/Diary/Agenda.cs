using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Diary
{
    public class Agenda : AbstractEntity
    {
        public Agenda() {
            MateriasAgendas = new HashSet<MateriaAgenda>();
            FrequenciasAlunosMaterias = new HashSet<FrequenciaAlunoMateria>();
        }

        public string Compromisso{ get; set; }
        public DateTime DataCompromisso { get; set; }

        public bool Prova { get; set; }
        
        public Guid UsuarioId { get; set; }
        public Guid AnoLetivoId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("AnoLetivoId")]
        public virtual AnoLetivo AnoLetivo { get; set; }

        public virtual ICollection<MateriaAgenda> MateriasAgendas { get; set; }
        public virtual ICollection<FrequenciaAlunoMateria> FrequenciasAlunosMaterias { get; set; }

    }
}
