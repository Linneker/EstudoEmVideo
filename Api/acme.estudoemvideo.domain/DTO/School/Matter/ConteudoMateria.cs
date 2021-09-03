using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Matter
{
    public class ConteudoMateria : AbstractEntity
    {
        public ConteudoMateria()
        {
         
        }
        public DateTime DataAtribuicao { get; set; }

        public Guid ConteudoId { get; set; }
        public Guid MateriaId { get; set; }


        [ForeignKey("MateriaId")]
        public virtual Materia Materia { get; set; }


        [ForeignKey("ConteudoId")]
        public virtual Conteudo Conteudo { get; set; }
    }
}
