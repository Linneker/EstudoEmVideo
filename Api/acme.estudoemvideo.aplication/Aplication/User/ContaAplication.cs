using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.User
{
    public class ContaAplication : ApplicationBase<Conta>, IContaAplication
    {
        private IContaServices _contaRepository;
        public ContaAplication(IContaServices contaRepository) : base(contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public Conta GetContaByLogin(string login)
        {
            return new Conta();//_contaRepository.GetContaByLogin(login);
        }

        public Conta Login(Conta conta)
        {
            if (conta.IsValid())
            {
                var logar = _contaRepository.Login(conta);
                if (!(logar is null))
                {
                    if (logar.Logado == false)
                    {
                        return logar;
                    }
                    else
                    {
                        IList<Notification> notifications = new List<Notification>();
                        var notification = new Notification($"{EnumCodigoMensagem.CONTA_LOGADA}", "USUARIO JÁ ESTA LOGADO EM OUTRO DISPOSITIVO!");
                        notifications.Add(notification);
                        conta.AddNotifications(notifications);
                        return conta;
                    }
                }
                else
                {
                    IList<Notification> notifications = new List<Notification>();
                    var notification = new Notification($"{EnumCodigoMensagem.LOGIN_OU_SENHA_INVALIDO}", "LOGIN OU SENHA INVALIDOS!");
                    notifications.Add(notification);
                    conta.AddNotifications(notifications);
                    return conta;
                }
            }
            else
            {
                return conta;
            }

        }
    }
}
