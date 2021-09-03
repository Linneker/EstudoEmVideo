using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Seguranca.Site
{
    public class PermissaoContaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/PermissaoConta", TITULO_MODAL = "PERMISSAO CONTA", URL_DOIS = "/PermissaoConta/GetDadosTable", ID_TABLE = "tabela_permissao_conta", CAMPOS_TABELA = "";

        public PermissaoContaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }
        public PermissaoContaViewModel(Guid contaId) : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            DataAtribuicao = DateTime.Now;
            PermissaoValida = true;
            PermissaoId = Guid.Parse("822A23FB-F110-45C6-AFDC-5CBD7A04FC52"); ;
            ContaId = contaId;
        }
        public PermissaoContaViewModel(Guid contaId, bool permissaoValida) : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            DataAtribuicao = DateTime.Now;
            PermissaoValida = permissaoValida;
            PermissaoId = Guid.Parse("822A23FB-F110-45C6-AFDC-5CBD7A04FC52");
            ContaId = contaId;
        }
        public PermissaoContaViewModel(Guid permissaoId, Guid contaId, bool permissaoValida) : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            DataAtribuicao = DateTime.Now;
            PermissaoValida = permissaoValida;
            PermissaoId = permissaoId;
            ContaId = contaId;
        }
        public PermissaoContaViewModel(Guid permissaoId, Guid contaId, bool permissaoValida, DateTime dataAtribuicao) : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
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
        public virtual ContaViewModel Conta { get; set; }
        [ForeignKey("PermissaoId")]
        public virtual PermissaoViewModel Permissao { get; set; }

    }
}
