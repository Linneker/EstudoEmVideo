using acme.estudoemvideo.util.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Negocio
{
    public class EnderecoEmpresaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/EnderecoEmpresa", TITULO_MODAL = "ENDERECO EMPRESA", URL_DOIS = "/EnderecoEmpresa/GetDadosTable", ID_TABLE = "tabela_endereco_empresa", CAMPOS_TABELA = "";

        public EnderecoEmpresaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }
        
        public int NumeroEmpresa { get; set; }


        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual EmpresaViewModel Empresa { get; set; }
    }
}
