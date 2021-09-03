using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Management.Administration
{
    public class Receita :AbstractEntity
    {
        public Receita()
        {
            FluxoDeCaixasReceitas = new HashSet<FluxoDeCaixaReceita>();
        }
        public DateTime DataRecebimento { get; set; }
        public decimal Valor { get; set; }
        public decimal Juros { get; set; }
        public DateTime DataPrevistaRecebiento { get; set; }
        public decimal ValorJuros { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public bool Recebido { get; set; }

        public Guid UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<FluxoDeCaixaReceita> FluxoDeCaixasReceitas { get; set; }
    }
}
