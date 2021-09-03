using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Seguranca.Site
{
    public class PermissaoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Permissao", TITULO_MODAL = "PERMISSAO", URL_DOIS = "/Permissao/GetDadosTable", ID_TABLE = "tabela_permissao", CAMPOS_TABELA = "";

        public PermissaoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            PermissoesContas = new HashSet<PermissaoContaViewModel>();
        }
        public string Nome {get;set;}
        public int Nivel { get; set; }

        public virtual ICollection<PermissaoContaViewModel> PermissoesContas { get; set; }
    }
}
