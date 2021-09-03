using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Util
{
    public class Menu : AbstractEntity
    {
        public Menu()
        {
            PermissoesMenus = new HashSet<PermissaoMenu>();
        }

        public string Nome { get; set; }
        public string Caminho { get; set; }
        public string Descricao { get; set; }
        public string Icone { get; set; }
        public int Posicao { get; set; }
        public Guid MenuIdPai { get; set; }

        public virtual ICollection<PermissaoMenu> PermissoesMenus { get; set; }
    }
}
