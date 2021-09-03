using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Util
{
    public class Bimestre : AbstractEntity
    {
        public Bimestre()
        {
            TurmaBimestres = new HashSet<TurmaBimestre>();
        }

        public string Nome { get; set; }

        public virtual ICollection<TurmaBimestre> TurmaBimestres { get; set; }
    }
}
