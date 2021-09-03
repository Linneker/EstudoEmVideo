using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Seguranca.Site
{
    public class Permissao : AbstractEntity
    {
        public Permissao()
        {
            PermissoesContas = new HashSet<PermissaoConta>();
        }

        public Permissao(string nome, int nivel)
        {
            Nome = nome;
            Nivel = nivel;
            PermissoesContas = new HashSet<PermissaoConta>();
        }

        public string Nome {get;set;}
        public int Nivel { get; set; }

        public virtual ICollection<PermissaoConta> PermissoesContas { get; set; }
    }
}
