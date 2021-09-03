using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class MenuViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Menu", TITULO_MODAL = "Menu", URL_DOIS = "/Menu/GetDadosTable", ID_TABLE = "tabela_menu", CAMPOS_TABELA = "";


        public MenuViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            PermissoesMenus = new HashSet<PermissaoMenuViewModel>();
        }
        [Required(ErrorMessage = "Informe o nome do Menu")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe um Caminho para Menu")]
        [Display(Name = "Caminho")]
        public string Caminho { get; set; }

        [Required(ErrorMessage = "Informe uma Descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o icone para menu ")]
        [Display(Name = "Icone")]
        public string Icone { get; set; }

        [Required(ErrorMessage = "Informe o posicao do menu")]
        [Display(Name = "Posição")]
        public int Posicao { get; set; }

        [Required(ErrorMessage = "Informe o menu principal")]
        [Display(Name = "Menu principal")]
        public Guid MenuIdPai { get; set; }

        [Required(ErrorMessage = "Informe a Permissao")]
        [Display(Name = "Permissões Menu")]
        public virtual ICollection<PermissaoMenuViewModel> PermissoesMenus { get; set; }

    }
}
