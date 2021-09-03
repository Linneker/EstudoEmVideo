using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Seguranca.Site
{
    public class PermissaoMenu : AbstractEntity
    {
        public PermissaoMenu()
        {
        
        }

        public Guid PermissaoId { get; set; }
        public Guid MenuId { get; set; }

        [ForeignKey("MenuId")]
        public virtual Menu Menu { get; set; }

        [ForeignKey("PermissaoId")]
        public virtual Permissao Permissao { get; set; }

        public bool? Add { get; set; }
        public bool? Read { get; set; }
        public bool? Delete { get; set; }
        public bool? Update { get; set; }

    }
}
