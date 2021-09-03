using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Site
{
    public class ContaSiteViewModel
    {
        public ContaSiteViewModel()
        {
            PermissaoConta = new PermissaoContaSiteViewModel();
        }

        public ContaSiteViewModel(string login, bool? alterarSenha, bool? contaAtiva, bool logado, string senha, bool termoDeAceite)
        {
            Login = login;
            AlterarSenha = alterarSenha;
            ContaAtiva = contaAtiva;
            Logado = logado;
            Senha = senha;
            TermoDeAceite = termoDeAceite;
        }
        public string Login { get; set; }
        public bool? AlterarSenha { get; set; }
        public bool? ContaAtiva { get; set; }
        public bool Logado { get; set; }
        public string Senha { get; set; }
        public bool TermoDeAceite { get; set; }

        public PermissaoContaSiteViewModel PermissaoConta { get; set; }
    }
}
