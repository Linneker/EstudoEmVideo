using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Management.Administration
{
    public class FluxoDeCaixa : AbstractEntity
    {
        public FluxoDeCaixa()
        {
            FluxoDeCaixasReceitas = new HashSet<FluxoDeCaixaReceita>();
            FluxoDeCaixasDespesas = new HashSet<FluxoDeCaixaDespesa>();
        }
        public DateTime DataProcessamento { get; set; }
        public decimal SaldoOperacional { get; set; }
        public decimal SaldoFinalCaixa { get; set; }
        public decimal SaldoInicial { get; set; }

        public virtual ICollection<FluxoDeCaixaReceita> FluxoDeCaixasReceitas { get; set; }
        public virtual ICollection<FluxoDeCaixaDespesa> FluxoDeCaixasDespesas { get; set; }


    }
}
