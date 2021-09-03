using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace acme.estudoemvideo.util.Map.Site
{
    public static class ContaMap
    {
        public static ContaViewModel ContaToContaViewModel(this Conta conta)
        {
            List<NotificationBaseViewModel> notifications = new List<NotificationBaseViewModel>();
            if (conta.HasNotifications)
            {
                foreach (var not in conta.Notifications)
                {
                    NotificationBaseViewModel notificationBase = new NotificationBaseViewModel();
                    notificationBase.AddNotification(not.Key, not.Mensagem);
                    notifications.Add(notificationBase);
                }
            }
            ContaViewModel contaViewModel = new ContaViewModel()
            {
                AlterarSenha = conta.AlterarSenha,
                BotaoDeletar = conta.BotaoDeletar,
                BotaoEditar = conta.BotaoEditar,
                BotaoEditarDeletarVizualizar = conta.BotaoEditarDeletarVizualizar,
                BotaoEditarEDeletar = conta.BotaoEditarEDeletar,
                BotaoVizualizar = conta.BotaoVizualizar,
                ContaAtiva = conta.ContaAtiva,
                DataCriacao = conta.DataCriacao,
                DataInativacao = conta.DataInativacao,
                DataModificacao = conta.DataModificacao,
                Id = conta.Id,
                Logado = conta.Logado,
                Login = conta.Login,
                Senha = conta.Senha,
                Status = conta.Status,
                TermoDeAceite = conta.TermoDeAceite,
                UsuarioId = conta.UsuarioId
            };
            if (!(conta.Usuario is null))
            {
                contaViewModel.Usuario = new UsuarioViewModel();
                contaViewModel.Usuario.BotaoDeletar = conta.Usuario.BotaoDeletar;
                contaViewModel.Usuario.BotaoEditar = conta.Usuario.BotaoEditar;
                contaViewModel.Usuario.BotaoEditarDeletarVizualizar = conta.Usuario.BotaoEditarDeletarVizualizar;
                contaViewModel.Usuario.BotaoEditarEDeletar = conta.Usuario.BotaoEditarEDeletar;
                contaViewModel.Usuario.BotaoVizualizar = conta.Usuario.BotaoVizualizar;
                contaViewModel.Usuario.Cpf = conta.Usuario.Cpf;
                contaViewModel.Usuario.DadosModificado = conta.Usuario.DadosModificado;
                contaViewModel.Usuario.DataCriacao = conta.Usuario.DataCriacao;
                contaViewModel.Usuario.DataDeNascimento = conta.Usuario.DataDeNascimento;
                contaViewModel.Usuario.DataInativacao = conta.Usuario.DataInativacao;
                contaViewModel.Usuario.DataModificacao = conta.Usuario.DataModificacao;
                contaViewModel.Usuario.Email = conta.Usuario.Email;
                contaViewModel.Usuario.Id = conta.Usuario.Id;
                contaViewModel.Usuario.Nome = conta.Usuario.Nome;
                contaViewModel.Usuario.Status = conta.Usuario.Status;
                contaViewModel.Usuario.Telefone = conta.Usuario.Telefone;
                if (conta.Usuario.EnderecoUsuarios.Any())
                {
                    foreach (var endUsuario in conta.Usuario.EnderecoUsuarios)
                    {
                        EnderecoUsuarioViewModel usuarioViewModel = new EnderecoUsuarioViewModel();
                        usuarioViewModel.Numero = endUsuario.Numero;
                        usuarioViewModel.Endereco.Bairro = endUsuario.Endereco.Bairro;
                        usuarioViewModel.Endereco.Cep = endUsuario.Endereco.Cep;
                        usuarioViewModel.Endereco.Cidade = endUsuario.Endereco.Cidade;
                        usuarioViewModel.Endereco.DataCriacao = endUsuario.Endereco.DataCriacao;
                        usuarioViewModel.Endereco.DataInativacao = endUsuario.Endereco.DataInativacao;
                        usuarioViewModel.Endereco.DataModificacao = endUsuario.Endereco.DataModificacao;
                        usuarioViewModel.Endereco.Estado = endUsuario.Endereco.Estado;
                        usuarioViewModel.Endereco.Id = endUsuario.Endereco.Id;
                        usuarioViewModel.Endereco.Pais = endUsuario.Endereco.Pais;
                        usuarioViewModel.Endereco.Rua = endUsuario.Endereco.Rua;
                        usuarioViewModel.Endereco.Status = endUsuario.Endereco.Status;
                        contaViewModel.Usuario.EnderecoUsuarios.Add(usuarioViewModel);
                    }

                }
                if (conta.PermissoesContas.Any())
                {
                    foreach (var perm in conta.PermissoesContas)
                    {
                        PermissaoContaViewModel permissaoContaViewModel = new PermissaoContaViewModel();
                        permissaoContaViewModel.Add = perm.Add;
                        permissaoContaViewModel.ContaId = perm.ContaId;
                        permissaoContaViewModel.DataAtribuicao = perm.DataAtribuicao;
                        permissaoContaViewModel.DataCriacao = perm.DataCriacao;
                        permissaoContaViewModel.DataInativacao = perm.DataInativacao;
                        permissaoContaViewModel.DataModificacao = perm.DataModificacao;
                        permissaoContaViewModel.Delete = perm.Delete;
                        permissaoContaViewModel.Id = perm.Id;
                        permissaoContaViewModel.Permissao = new PermissaoViewModel();
                        permissaoContaViewModel.Permissao.Id =  perm.Permissao.Id;
                        permissaoContaViewModel.Permissao.DataCriacao = perm.Permissao.DataCriacao;
                        permissaoContaViewModel.Permissao.DataInativacao = perm.Permissao.DataInativacao;
                        permissaoContaViewModel.Permissao.DataModificacao = perm.Permissao.DataModificacao;
                        permissaoContaViewModel.Permissao.Nivel = perm.Permissao.Nivel;
                        permissaoContaViewModel.Permissao.Nome = perm.Permissao.Nome;
                        permissaoContaViewModel.Permissao.Status = perm.Permissao.Status;
                        permissaoContaViewModel.PermissaoId = perm.PermissaoId;
                        permissaoContaViewModel.PermissaoValida = perm.PermissaoValida;
                        permissaoContaViewModel.Read = perm.Read;
                        permissaoContaViewModel.Status = perm.Status;
                        permissaoContaViewModel.Update = perm.Update;
                        permissaoContaViewModel.Url = perm.Url;
                        permissaoContaViewModel.Conta = contaViewModel;
                        contaViewModel.PermissoesContas.Add(permissaoContaViewModel);
                    }

                }
            }
            return contaViewModel;
        }
        public static Conta ContaViewModelToConta(this ContaViewModel conta)
        {
            return new Conta();
        }
    }
}
