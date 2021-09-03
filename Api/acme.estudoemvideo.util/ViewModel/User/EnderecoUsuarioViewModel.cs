using acme.estudoemvideo.util.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.User
{
    public class EnderecoUsuarioViewModel : AbstractEntityViewModel
    {
        private const string URL = "/EnderecoUsuario", TITULO_MODAL = "ENDERECO USUARIO", URL_DOIS = "/EnderecoUsuario/GetDadosTable", ID_TABLE = "tabela_endereco_usuario", CAMPOS_TABELA = "";
        public EnderecoUsuarioViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }
        public int Numero { get; set; }


        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
    }
}
