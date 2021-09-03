using acme.estudoemvideo.domain.DTO.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO
{
    [NotMapped]
    public  class AbstractEntity : NotificationBase
    {
        public AbstractEntity()
        {
            if (DataCriacao is null)
            {
                DataCriacao = DateTime.Now;
                Id = Guid.NewGuid();
            }
            else
                DataModificacao = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataInativacao { get; set; }

        public EnumStatus Status { get; set; }
        [NotMapped]
        public virtual string BotaoEditarDeletarVizualizar { get; set; }

        [NotMapped]
        public virtual string BotaoEditarEDeletar { get; set; }
        [NotMapped]
        public virtual string BotaoEditar { get; set; }
        [NotMapped]
        public virtual string BotaoDeletar { get; set; }
        [NotMapped]
        public string BotaoVizualizar { get; set; }
    }
}
