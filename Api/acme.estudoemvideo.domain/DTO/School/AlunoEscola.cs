using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School
{
    public class AlunoEscola : AbstractEntity
    {
        
        public AlunoEscola()
        {
            FrequenciasAlunosMaterias = new HashSet<FrequenciaAlunoMateria>();
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessor>();
            TurmasAlunosEscolas = new HashSet<TurmaAlunoEscola>();

        }
        public DateTime DataAlunoEscola { get; set; }
        public DateTime DataMatriculaAlunoNaEscola { get; set; }
        public long Matricula { get; set; }
        
        public Guid UsuarioId { get; set; }
        public Guid EscolaId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Aluno { get; set; }
        [ForeignKey("EscolaId")]
        public virtual Escola Escola { get; set; }

        public virtual ICollection<FrequenciaAlunoMateria> FrequenciasAlunosMaterias { get; set; }
        public virtual ICollection<NotaAlunoMateriaProfessor> NotasAlunosMateriasProfessores { get; set; }
        public virtual ICollection<TurmaAlunoEscola> TurmasAlunosEscolas { get; set; }

    }
}
