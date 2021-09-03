using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Management.Administration
{
    public class FluxoDeCaixaDespesa : AbstractEntity
    {
        public FluxoDeCaixaDespesa()
        {
            FluxoDeCaixa = new FluxoDeCaixa();
            Despesa = new Despesa();
        }

        public DateTime DataBaixa { get; set; }

        public Guid FluxoDeCaixaId { get; set; }
        public Guid DespesaId { get; set; }

        [ForeignKey("FluxoDeCaixaId")]
        public virtual FluxoDeCaixa FluxoDeCaixa { get; set; }
        [ForeignKey("DespesaId")]
        public virtual Despesa Despesa { get; set; }
    }
}
