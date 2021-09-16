using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Matter
{
    public class Materia : AbstractEntity
    {

        public Materia()
        {
            ConteudosMaterias = new HashSet<ConteudoMateria>();
            MateriasAgendas = new HashSet<MateriaAgenda>();
            FrequenciasAlunosMaterias = new HashSet<FrequenciaAlunoMateria>();
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessor>();
            TurmaMaterias = new HashSet<TurmaMateria>();
            MateriasProfessores = new HashSet<MateriaProfessorEscola>();
            Boletins = new HashSet<Boletim>();
        }
        public string Nome { get; set; }

        public virtual ICollection<ConteudoMateria> ConteudosMaterias { get; set; }
        public virtual ICollection<MateriaAgenda> MateriasAgendas { get; set; }
        public virtual ICollection<FrequenciaAlunoMateria> FrequenciasAlunosMaterias { get; set; }
        public virtual ICollection<NotaAlunoMateriaProfessor> NotasAlunosMateriasProfessores { get; set; }
        public virtual ICollection<TurmaMateria> TurmaMaterias { get; set; }
        public virtual ICollection<MateriaProfessorEscola> MateriasProfessores { get; set; }
        public virtual ICollection<Boletim> Boletins { get; set; }
    }
}
