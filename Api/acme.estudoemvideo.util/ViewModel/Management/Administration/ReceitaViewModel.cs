using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Management.Administration
{
    public class ReceitaViewModel :AbstractEntityViewModel
    {
        private const string URL = "/Receita", TITULO_MODAL = "RECEITA", URL_DOIS = "/Receita/GetDadosTable", ID_TABLE = "tabela_receita", CAMPOS_TABELA = "";

        public ReceitaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
                FluxoDeCaixasReceitas = new HashSet<FluxoDeCaixaReceitaViewModel>();
        }
        public DateTime DataRecebimento { get; set; }
        public decimal Valor { get; set; }
        public decimal Juros { get; set; }
        public DateTime DataPrevistaRecebiento { get; set; }
        public decimal ValorJuros { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public bool Recebido { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
        public ICollection<FluxoDeCaixaReceitaViewModel> FluxoDeCaixasReceitas { get; set; }
    }
}
