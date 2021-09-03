using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Diary
{
    public class AnoLetivo : AbstractEntity
    {
        public AnoLetivo()
        {
            Agendas = new HashSet<Agenda>();
        }

        public DateTime Data { get; set; }
        
        public bool FeiradoNacional { get; set; }
        public bool FeiradoEstadual { get; set; }
        public bool FeiradoMunicipal { get; set; }
        public bool FeiradoEscolar { get; set; }
        public bool DiaLetivo { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }

    }
}
