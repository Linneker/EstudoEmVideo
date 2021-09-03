using acme.estudoemvideo.util.ViewModel.User;
using acme.estudoemvideo.util.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Seguranca.Site
{
    public class PermissaoMenuViewModel : AbstractEntityViewModel
    {
        private const string URL = "/PermissaoMenu", TITULO_MODAL = "PERMISSAO MENU", URL_DOIS = "/PermissaoMenu/GetDadosTable", ID_TABLE = "tabela_permissao_menu", CAMPOS_TABELA = "";

        public PermissaoMenuViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            Menu = new MenuViewModel();
            Permissao = new PermissaoViewModel();
        }

        public Guid PermissaoId { get; set; }
        public Guid MenuId { get; set; }

        [ForeignKey("MenuId")]
        public virtual MenuViewModel Menu { get; set; }

        [ForeignKey("PermissaoId")]
        public virtual PermissaoViewModel Permissao { get; set; }
    }
}
