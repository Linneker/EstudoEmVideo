using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Util
{
    public class Competencia: AbstractEntity
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
    }
}
