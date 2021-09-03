using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Management.Administration
{
    public class FluxoDeCaixaDespesaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/FluxoDeCaixaDespesa", TITULO_MODAL = "FLUXO DE CAIXA DESPESA", URL_DOIS = "/FluxoDeCaixaDespesa/GetDadosTable", ID_TABLE = "tabela_fluxo_de_caixa_despesa", CAMPOS_TABELA = "";

        public FluxoDeCaixaDespesaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            FluxoDeCaixa = new FluxoDeCaixaViewModel();
            Despesa = new DespesaViewModel();
        }

        public DateTime DataBaixa { get; set; }

        public virtual FluxoDeCaixaViewModel FluxoDeCaixa { get; set; }
        public virtual DespesaViewModel Despesa { get; set; }
    }
}
