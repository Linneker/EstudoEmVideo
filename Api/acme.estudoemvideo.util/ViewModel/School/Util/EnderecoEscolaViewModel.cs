using acme.estudoemvideo.util.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class EnderecoEscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/EnderecoEscola", TITULO_MODAL = "ENDEREÇO ESCOLA", URL_DOIS = "/EnderecoEscola/GetDadosTable", ID_TABLE = "tabela_endereco_escola", CAMPOS_TABELA = "";

        public EnderecoEscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        
        }

        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Guid EnderecoId { get; set; }
        public Guid EscolaId { get; set; }

        public virtual EnderecoViewModel Endereco { get; set; }
        
        public virtual EscolaViewModel Escola { get; set; }
    }
}
