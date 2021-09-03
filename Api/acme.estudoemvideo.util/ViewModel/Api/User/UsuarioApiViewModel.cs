using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Api.User
{
    public class UsuarioApiViewModel
    {
        public UsuarioApiViewModel(string nome, string cpf, string email, string telefone, DateTime dataDeNascimento, ContaApiViewModel conta)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            DataDeNascimento = dataDeNascimento;
            Conta = conta;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataDeNascimento { get; private set; }

        public ContaApiViewModel Conta { get; private set; }
    }
}
