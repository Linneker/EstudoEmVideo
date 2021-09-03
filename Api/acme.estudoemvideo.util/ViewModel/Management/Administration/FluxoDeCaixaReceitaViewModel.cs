using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Management.Administration
{
    public class FluxoDeCaixaReceitaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/FluxoDeCaixaReceita", TITULO_MODAL = "FLUXO DE CAIXA RECEITA", URL_DOIS = "/FluxoDeCaixaReceita/GetDadosTable", ID_TABLE = "tabela_fluxo_de_caixa_receita", CAMPOS_TABELA = "";

        public FluxoDeCaixaReceitaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            FluxoDeCaixa = new FluxoDeCaixaViewModel();
            Receita = new ReceitaViewModel();
        }
        public DateTime DataEntrada { get; set; }

        public virtual FluxoDeCaixaViewModel FluxoDeCaixa { get; set; }
        public virtual ReceitaViewModel Receita { get; set; }
    }
}
