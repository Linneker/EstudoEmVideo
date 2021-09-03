using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Matter.Books
{
    public class Apostila : AbstractEntity
    {

        [NotMapped]
        public sbyte[] ApostilaDigital { get; set; }
        public string Bibliografia { get; set; }
        public Guid ArquivoId { get; set; }

        public Guid ConteudoId { get; set; }

        [ForeignKey("ConteudoId")]
        public Conteudo Conteudo { get; set; }

        [ForeignKey("ArquivoId")]
        public Arquivo Arquivo { get; set; }

    }
}
