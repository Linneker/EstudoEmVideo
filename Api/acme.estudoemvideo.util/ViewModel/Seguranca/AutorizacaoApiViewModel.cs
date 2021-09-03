using System.ComponentModel.DataAnnotations;

namespace acme.estudoemvideo.util.ViewModel.Seguranca
{
    public class AutorizacaoApiViewModel : AbstractEntityViewModel
    {
        private const string URL = "/AutorizacaoApi", TITULO_MODAL = "AUTORIZAÇÃO", URL_DOIS = "/AutorizacaoApi/GetDadosTable", ID_TABLE = "tabela_autorizacao_api", CAMPOS_TABELA = "";

        public AutorizacaoApiViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public string AccessKey { get; set; }
       [Display(Name ="CNPJ da Empresa")]
        public string CnpjEmpresa { get; set; }
    }
}
