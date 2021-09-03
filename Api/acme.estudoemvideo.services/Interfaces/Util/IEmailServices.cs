using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace acme.estudoemvideo.services.Interfaces.Util
{
    public interface IEmailServices
    {
        SmtpClient ConfiguracaoServidor(Email email);
        bool ConfiguracaoCorpo(Email email);
        bool Enviar(SmtpClient client, MailMessage mail);
    }
}
