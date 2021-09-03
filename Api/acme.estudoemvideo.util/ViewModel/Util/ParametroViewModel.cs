using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class ParametroViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Parametro", TITULO_MODAL = "PARAMETRO", URL_DOIS = "/Parametro/GetDadosTable", ID_TABLE = "tabela_parametro", CAMPOS_TABELA = "";

        public ParametroViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public bool? Ativo { get; set; }

    }
}
