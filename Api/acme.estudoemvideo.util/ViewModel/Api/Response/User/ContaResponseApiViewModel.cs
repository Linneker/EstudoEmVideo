using acme.estudoemvideo.domain.DTO.Notificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Api.Response.User
{
    public class ContaResponseApiViewModel
    {
        public ContaResponseApiViewModel(Guid id, bool? contaAtiva, bool logado, string login, bool termoDeAceite, ICollection<PermissaoResponseApiViewModel> permissoes,List<Notification> notification)
        {
            Id = id;
            ContaAtiva = contaAtiva;
            Logado = logado;
            Login = login;
            TermoDeAceite = termoDeAceite;
            Permissoes = permissoes;
            Notifications = notification;
        }
        public ContaResponseApiViewModel(bool? contaAtiva, bool logado, string login, bool termoDeAceite, ICollection<PermissaoResponseApiViewModel> permissoes, List<Notification> notification)
        {
            Id = Guid.NewGuid();
            ContaAtiva = contaAtiva;
            Logado = logado;
            Login = login;
            TermoDeAceite = termoDeAceite;
            Permissoes = permissoes;
            Notifications = notification;
        }
        public Guid Id { get; set; }
        public bool? ContaAtiva { get; set; }
        public bool Logado { get; set; }
        public string Login { get; set; }
        public bool TermoDeAceite { get; set; }

        public virtual ICollection<PermissaoResponseApiViewModel> Permissoes { get; set; }

        public bool HasNotification => Notifications.Any();
        public List<Notification> Notifications { get; set; }
    }
}
