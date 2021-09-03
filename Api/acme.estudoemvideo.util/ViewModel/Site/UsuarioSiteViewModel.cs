using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Site
{
    public class UsuarioSiteViewModel
    {
        public UsuarioSiteViewModel()
        {
            Conta = new ContaSiteViewModel();
        }

        public UsuarioSiteViewModel(string nome, string cpf, string email, string telefone, DateTime dataDeNascimento, ContaSiteViewModel conta)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            DataDeNascimento = dataDeNascimento;
            Conta = conta;
        }

        public string Nome { get;  set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public ContaSiteViewModel Conta { get; set; }
        
    }
}
