using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class Serie : AbstractEntity
    {
        public Serie()
        {
            Turmas = new HashSet<Turma>();
        }
        public string Nome { get; set; }

        
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
