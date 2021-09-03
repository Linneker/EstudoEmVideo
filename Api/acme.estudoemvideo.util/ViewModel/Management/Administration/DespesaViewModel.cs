using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Management.Administration
{
    public class DespesaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Despesa", TITULO_MODAL = "DESPESA", URL_DOIS = "/Despesa/GetDadosTable", ID_TABLE = "tabela_despesa", CAMPOS_TABELA = "";

        public DespesaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            FluxoDeCaixasDespesas = new HashSet<FluxoDeCaixaDespesaViewModel>();
        }
        public DateTime DataLancamento { get; set; }
        public DateTime DataPagamento { get; set; }

        public string Nome { get; set; }
        public decimal Juros { get; set; }
        public  decimal Valor { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal Descricao { get; set; }
        public bool Computada { get; set; }

        public ICollection<FluxoDeCaixaDespesaViewModel> FluxoDeCaixasDespesas { get; set; }
    }
}
