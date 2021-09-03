using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Seguranca.Site
{
    public class PermissaoConta : AbstractEntity
    {

        public PermissaoConta()
        {
        }
        public PermissaoConta(Guid contaId)
        {
            DataAtribuicao = DateTime.Now;
            PermissaoValida = true;
            PermissaoId = Guid.Parse("822A23FB-F110-45C6-AFDC-5CBD7A04FC52"); ;
            ContaId = contaId;
        }
        public PermissaoConta(Guid contaId, bool permissaoValida)
        {
            DataAtribuicao = DateTime.Now;
            PermissaoValida = permissaoValida;
            PermissaoId = Guid.Parse("822A23FB-F110-45C6-AFDC-5CBD7A04FC52");
            ContaId = contaId;
        }
        public PermissaoConta(Guid permissaoId, Guid contaId, bool permissaoValida)
        {
            DataAtribuicao = DateTime.Now;
            PermissaoValida = permissaoValida;
            PermissaoId = permissaoId;
            ContaId = contaId;
        }
        public PermissaoConta(Guid permissaoId, Guid contaId, bool permissaoValida, DateTime dataAtribuicao)
        {
            DataAtribuicao = dataAtribuicao;
            PermissaoValida = permissaoValida;
            PermissaoId = permissaoId;
            ContaId = contaId;
        }



        public DateTime DataAtribuicao { get; set; }
        public bool PermissaoValida { get; set; }

        [NotMapped]
        public string Url { get; set; }
        public Guid PermissaoId { get; set; }
        public Guid ContaId { get; set; }
        public bool? Delete { get; set; }
        public bool? Update { get; set; }
        public bool? Add { get; set; }
        public bool? Read { get; set; }

        [ForeignKey("ContaId")]
        public virtual Conta Conta { get; set; }
        [ForeignKey("PermissaoId")]
        public virtual Permissao Permissao { get; set; }

    }
}