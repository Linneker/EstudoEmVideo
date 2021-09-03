using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.User.Validation
{
    public static class ContaValidation
    {
        public static IList<Notification> GetNotifications(this Conta conta)
        {
            List<Notification> validations = new List<Notification>();
            if (!(conta is null))
            {
                Notification loginNotificationNull = new Notification(conta.Login.IsNull().Mensagem($"{(int)EnumCodigoMensagem.NULL}"), conta.Login.IsNull().Mensagem("Login não preenchido"));
                Notification loginNotificationMaximo = new Notification(conta.Login.Length.MaxLength(250).Mensagem($"{(int)EnumCodigoMensagem.MAXLENGTH}"), conta.Login.Length.MaxLength(250).Mensagem("Tamanho maximo do login excedido"));
                Notification loginNotificationMinimo = new Notification(conta.Login.Length.MinLength(5).Mensagem($"{(int)EnumCodigoMensagem.MINLENGTH}"), conta.Login.Length.MinLength(5).Mensagem("Tamanho minimo do login excedido"));
                Notification senhaNotificationNull = new Notification(conta.Senha.IsNull().Mensagem($"{(int)EnumCodigoMensagem.NULL}"), conta.Senha.IsNull().Mensagem("Senha não preenchida"));
                if (senhaNotificationNull.Key != "50")
                {
                    Notification logoNotificationMinimo = new Notification(conta.Senha.Length.MinLength(5).Mensagem($"{(int)EnumCodigoMensagem.MINLENGTH}"), conta.Senha.Length.MaxLength(5).Mensagem($"Senha muito pequena!"));
                }
                if (!(string.IsNullOrEmpty(loginNotificationNull.Key)))
                {
                    validations.Add(loginNotificationNull);
                }
                if (!(string.IsNullOrEmpty(loginNotificationMaximo.Key)))
                {
                    validations.Add(loginNotificationMaximo);
                }
                if (!(string.IsNullOrEmpty(loginNotificationMinimo.Key)))
                {
                    validations.Add(loginNotificationMinimo);
                }
            }
            else
            {
                Notification condominioNotificationNull = new Notification($"{(int)EnumCodigoMensagem.NULL}", "conta não preenchido");
                validations.Add(condominioNotificationNull);
            }

            return validations;
        }

    }

}
