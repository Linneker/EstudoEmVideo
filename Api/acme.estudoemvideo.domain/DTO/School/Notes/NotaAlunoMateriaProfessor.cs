using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Notes
{
    public class NotaAlunoMateriaProfessor :AbstractEntity
    {
        public NotaAlunoMateriaProfessor()
        {
            NotaAlunoMateriaConteudos = new HashSet<NotaAlunoMateriaConteudo>();
        }

        public Guid NotaId { get; set; }
        public Guid AlunoEscolaId { get; set; }
        public Guid MateriaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }
        
        public virtual Nota Nota { get; set; }
        public virtual AlunoEscola AlunoEscola { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual ProfessorEscola ProfessorEscola { get; set; }
        
        public virtual ICollection<NotaAlunoMateriaConteudo> NotaAlunoMateriaConteudos { get; set; }
    }
}
