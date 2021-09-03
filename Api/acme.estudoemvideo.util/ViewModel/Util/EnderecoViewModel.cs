using acme.estudoemvideo.util.ViewModel.Negocio;
using acme.estudoemvideo.util.ViewModel.User;
using System.Collections.Generic;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class EnderecoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Endereco", TITULO_MODAL = "ENDERECO", URL_DOIS = "/Endereco/GetDadosTable", ID_TABLE = "tabela_endereco", CAMPOS_TABELA = "";


        public EnderecoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            EnderecoEmpresas = new HashSet<EnderecoEmpresaViewModel>();
            EnderecoUsuarios = new HashSet<EnderecoUsuarioViewModel>();
        }

        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }

        public virtual ICollection<EnderecoEmpresaViewModel> EnderecoEmpresas { get; set; }
        public virtual ICollection<EnderecoUsuarioViewModel> EnderecoUsuarios { get; set; }
    }
}
