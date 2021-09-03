using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Management.Administration
{
    public class FluxoDeCaixaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/FluxoDeCaixa", TITULO_MODAL = "FLUXO DE CAIXA", URL_DOIS = "/FluxoDeCaixa/GetDadosTable", ID_TABLE = "tabela_fluxo_de_caixa", CAMPOS_TABELA = "";

        public FluxoDeCaixaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            FluxoDeCaixasReceitas = new HashSet<FluxoDeCaixaReceitaViewModel>();
            FluxoDeCaixasDespesas = new HashSet<FluxoDeCaixaDespesaViewModel>();
        }
        public DateTime DataProcessamento { get; set; }
        public decimal SaldoOperacional { get; set; }
        public decimal SaldoFinalCaixa { get; set; }
        public decimal SaldoInicial { get; set; }

        public ICollection<FluxoDeCaixaReceitaViewModel> FluxoDeCaixasReceitas { get; set; }
        public ICollection<FluxoDeCaixaDespesaViewModel> FluxoDeCaixasDespesas { get; set; }


    }
}
