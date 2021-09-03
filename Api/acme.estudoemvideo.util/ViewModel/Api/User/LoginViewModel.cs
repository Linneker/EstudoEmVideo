using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Api.User
{
    public class LoginViewModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool ContinuarLogado { get; set; }
        public string Ip { get; set; }
    }
}
