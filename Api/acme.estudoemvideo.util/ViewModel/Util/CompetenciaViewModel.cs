using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class CompetenciaViewModel: AbstractEntityViewModel
    {
        private const string URL = "/Competencia", TITULO_MODAL = "COMPETENCIA", URL_DOIS = "/Competencia/GetDadosTable", ID_TABLE = "tabela_competencia", CAMPOS_TABELA = "";
        public CompetenciaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
    }
}
