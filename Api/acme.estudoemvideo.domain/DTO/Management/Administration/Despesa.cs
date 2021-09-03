using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Management.Administration
{
    public class Despesa : AbstractEntity
    {
        public Despesa()
        {
            FluxoDeCaixasDespesas = new HashSet<FluxoDeCaixaDespesa>();
        }
        public DateTime DataLancamento { get; set; }
        public DateTime DataPagamento { get; set; }

        public string Nome { get; set; }
        public decimal Juros { get; set; }
        public  decimal Valor { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal Descricao { get; set; }
        public bool Computada { get; set; }

        public Guid UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        
        public virtual ICollection<FluxoDeCaixaDespesa> FluxoDeCaixasDespesas { get; set; }
    }
}
