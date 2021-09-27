using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Diary
{
    public class Diario : AbstractEntity
    {
        public Diario() {
            AlunoEscolasDiarios = new HashSet<AlunoEscolaDiario>();
            ProfessoresEscolassDiarios = new HashSet<ProfessorEscolaDiario>();
        }
        public Guid AnoLetivoId { get; set; }
        
        public virtual AnoLetivo AnoLetivo { get; set; }
        public virtual ICollection<AlunoEscolaDiario> AlunoEscolasDiarios { get; set; }
        public virtual ICollection<ProfessorEscolaDiario> ProfessoresEscolassDiarios { get; set; }

    }
}
