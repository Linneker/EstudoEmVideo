using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel
{
    public class RespostaPadraoModels
    {
        public RespostaPadraoModels() { }
        public RespostaPadraoModels(EnumHttp codigo, string mensagem, string descricao, string status, List<Notification> notifications)
        {
            Codigo = codigo;
            Mensagem = mensagem;
            Descricao = descricao;
            Status = status;
            Notifications = notifications;
        }

        public EnumHttp Codigo { get; set; }
        public string Mensagem { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        public bool HasNotifications => Notifications.Any();
        public List<Notification> Notifications { get; set; }

    }
}
