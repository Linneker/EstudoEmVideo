using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Api.User
{
    public class LogoutViewModel
    {
        public Guid ContaId { get; set; }
        public string Login { get; set; }
        public string Ip { get; set; }

    }
}
