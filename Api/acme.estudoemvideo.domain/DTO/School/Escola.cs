using System;
using System.Collections.Generic;
using System.Text;
using acme.estudoemvideo.domain.DTO.Negocio;
using acme.estudoemvideo.domain.DTO.School.Util;

namespace acme.estudoemvideo.domain.DTO.School
{
    public class Escola : AbstractEntity
    {
        public Escola()
        {
            AlunosEscolas = new HashSet<AlunoEscola>();
            Turmas = new HashSet<Turma>();
            ProfessorEscolas = new HashSet<ProfessorEscola>();
            EnderecoEscolas = new HashSet<EnderecoEscola>();
        }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public virtual ICollection<AlunoEscola> AlunosEscolas { get; set; }
        public virtual ICollection<ProfessorEscola> ProfessorEscolas{ get; set; }
        public virtual ICollection<EnderecoEscola> EnderecoEscolas { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
