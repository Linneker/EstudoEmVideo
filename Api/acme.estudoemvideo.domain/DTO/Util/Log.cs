using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Util
{
    public class Log<TEntity> : AbstractEntity where TEntity : class
    {
        public string Nome { get; set; }
        public DateTime? DataLog { get; set; }
        public string Descricao { get; set; }

        public string ObjetoJson { get; set; }
        public string ModificaoObjeto { get; set; }

        [NotMapped]
        public TEntity Objeto { get; set; }

        public virtual Usuario Usuario { get; set; }
        
    }
}
