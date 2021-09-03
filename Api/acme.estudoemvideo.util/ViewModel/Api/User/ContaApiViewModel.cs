using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Api.User
{
    public class ContaApiViewModel
    {
        public ContaApiViewModel(string login, bool? alterarSenha, bool? contaAtiva, bool logado, string senha, bool termoDeAceite)
        {
            Login = login;
            AlterarSenha = alterarSenha;
            ContaAtiva = contaAtiva;
            Logado = logado;
            Senha = senha;
            TermoDeAceite = termoDeAceite;
        }
        public string Login { get; private set; }
        public bool? AlterarSenha { get; private set; }
        public bool? ContaAtiva { get; private set; }
        public bool Logado { get; private set; }
        public string Senha { get; private set; }
        public bool TermoDeAceite { get; set; }

    }
}
