using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Site
{
    public class PermissaoContaSiteViewModel
    {
        public Guid PermissaoId { get; set; }
        public DateTime DataAtribuicao { get; set; }
        public bool PermissaoValida { get; set; }
        public bool Delete { get; set; }
        public bool Update { get; set; }
        public bool Add { get; set; }
        public bool Read { get; set; }

    }
}
