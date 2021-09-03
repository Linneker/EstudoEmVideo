using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Diary
{
    public class AnoLetivoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/AnoLetivo", TITULO_MODAL = "ANO LETIVO", URL_DOIS = "/AnoLetivo/GetDadosTable", ID_TABLE = "tabela_endereco_ano_letivo", CAMPOS_TABELA = "";

        public AnoLetivoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {

        }
        public DateTime Data { get; set; }
        
        public bool FeiradoNacional { get; set; }
        public bool FeiradoEstadual { get; set; }
        public bool FeiradoMunicipal { get; set; }
        public bool FeiradoEscolar { get; set; }
        public bool DiaLetivo { get; set; }

    }
}
