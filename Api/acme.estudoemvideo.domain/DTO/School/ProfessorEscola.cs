using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School
{
    public class ProfessorEscola : AbstractEntity
    {
        public ProfessorEscola()
        {
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessor>();
            TurmaProfessorEscolas = new HashSet<TurmaProfessorEscola>();
            MateriasProfessores = new HashSet<MateriaProfessorEscola>();
            ProfessoresEscolassDiarios = new HashSet<ProfessorEscolaDiario>();
            Boletins = new HashSet<Boletim>();
        }

        public int PopularidadeProfessor { get; set; }
        
        public Guid UsuarioId { get; set; }
        public Guid EscolaId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("EscolaId")]
        public virtual Escola Escola { get; set; }
        public virtual ICollection<NotaAlunoMateriaProfessor> NotasAlunosMateriasProfessores { get; set; }
        public virtual ICollection<TurmaProfessorEscola> TurmaProfessorEscolas { get; set; }
        public virtual ICollection<MateriaProfessorEscola> MateriasProfessores { get; set; }
        public virtual ICollection<ProfessorEscolaDiario> ProfessoresEscolassDiarios { get; set; }
        public virtual ICollection<Boletim> Boletins { get; set; }
    }
}
