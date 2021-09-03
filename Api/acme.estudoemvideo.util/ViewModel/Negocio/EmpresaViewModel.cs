using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Negocio
{
    [NotMapped]
    public abstract class EmpresaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Empresa", TITULO_MODAL = "EMPRESA", URL_DOIS = "/Empresa/GetDadosTable", ID_TABLE = "tabela_empresa", CAMPOS_TABELA = "";

        public EmpresaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            EnderecosEmpresa = new HashSet<EnderecoEmpresaViewModel>();
        }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        
        public virtual ICollection<EnderecoEmpresaViewModel> EnderecosEmpresa { get; set; }
    }
}
