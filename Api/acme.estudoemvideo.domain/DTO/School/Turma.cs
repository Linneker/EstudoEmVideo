using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School
{
    public class Turma : AbstractEntity
    {
        public Turma()
        {
            TurmasAlunosEscolas = new HashSet<TurmaAlunoEscola>();
            TurmaProfessorEscolas = new HashSet<TurmaProfessorEscola>();
            TurmaBimestres = new HashSet<TurmaBimestre>();
            TurmaMaterias = new HashSet<TurmaMateria>();
        }

        public string Nome { get; set; }

        public EnumPeriodo Periodo { get; set; }
        
        public Guid SerieId { get; set; }
        public Guid EscolaId { get; set; }

        public virtual Escola Escola { get; set; }
        
        public virtual Serie Serie { get; set; }

        public virtual ICollection<TurmaAlunoEscola> TurmasAlunosEscolas { get; set; }
        public virtual ICollection<TurmaProfessorEscola> TurmaProfessorEscolas { get; set; }
        public virtual ICollection<TurmaBimestre> TurmaBimestres { get; set; }
        public virtual ICollection<TurmaMateria> TurmaMaterias { get; set; }

    }
}
