using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Management.Administration
{
    public class FluxoDeCaixaReceita : AbstractEntity
    {
        public FluxoDeCaixaReceita()
        {
            FluxoDeCaixa = new FluxoDeCaixa();
            Receita = new Receita();
        }
        public DateTime DataEntrada { get; set; }

        public Guid ReceitaId { get; set; }
        public Guid FluxoDeCaixaId { get; set; }

        [ForeignKey("FluxoDeCaixaId")]
        public virtual FluxoDeCaixa FluxoDeCaixa { get; set; }
        [ForeignKey("ReceitaId")]
        public virtual Receita Receita { get; set; }
    }
}
