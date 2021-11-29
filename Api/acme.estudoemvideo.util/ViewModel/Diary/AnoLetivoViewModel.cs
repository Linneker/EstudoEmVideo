using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Diary
{
    public class AnoLetivoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/AnoLetivo", TITULO_MODAL = "ANO LETIVO", URL_DOIS = "/AnoLetivo/GetDadosTable", ID_TABLE = "tabela_endereco_ano_letivo", CAMPOS_TABELA = "";
        public AnoLetivoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, new List<string> {
            "{ data: 'ano' }", "{ data: 'mes' }","{ data: 'dia' }","{ data: 'feiradoNacional' }","{ data: 'feiradoEstadual' }",
            "{ data: 'feiradoMunicipal' }","{ data: 'feiradoEscolar' }","{ data: 'diaLetivo' }",
            "{ data: 'feriadoFixo',render: function(data, type) { if (data === 1) { return 'Sim'; } if (data === 0) { return 'Não';}}}",
            "{data: 'status',render: function (data, type) {if (data === 0) {return 'Ativo';}if (data === 1) {return 'Inativo';}}}"
        })
        {

        }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }

        public bool FeiradoNacional { get; set; }
        public bool FeiradoEstadual { get; set; }
        public bool FeiradoMunicipal { get; set; }
        public bool FeiradoEscolar { get; set; }
        public bool DiaLetivo { get; set; }
        public bool FeriadoFixo { get; set; }

    }
}
