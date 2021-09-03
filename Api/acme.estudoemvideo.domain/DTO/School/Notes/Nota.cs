using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Notes
{
    public class Nota : AbstractEntity
    {
        public Nota()
        {
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessor>();
        }
        public int Numero { get; set; }
        public bool IsAprovado { get; set; }
        public bool IsRecuperacao { get; set; }
        public bool IsReprovado { get; set; }

        public ICollection<NotaAlunoMateriaProfessor> NotasAlunosMateriasProfessores { get; set; }
    }
}
