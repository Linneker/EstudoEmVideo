using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel.Api.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.Map.Api
{
    public static class ConvertObjetoConta 
    {
        public static Conta ContaApiViewModelToConta(this ContaApiViewModel contaViewModel)
        {
            Conta conta = new Conta();
            conta.Logado = false;
            conta.Login = contaViewModel.Login;
            conta.Senha = contaViewModel.Senha;
            conta.TermoDeAceite = contaViewModel.TermoDeAceite;
            return conta;
        }
    }
}
