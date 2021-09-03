using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.services.Interfaces.Util;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace acme.estudoemvideo.services.Services.Util
{
    public class EmailServices : IEmailServices
    {
        public EmailServices()
        {
        }

        public SmtpClient ConfiguracaoServidor(Email email)
        {
            SmtpClient client = new SmtpClient();
            client.Host = email.Host;
            client.Port = email.Porta;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            client.Credentials = new System.Net.NetworkCredential("recent:acme.sistemas.ltda@gmail.com", @"[{<<@Cm&$!StE/\/\a2L+d#>>}]");
            return client;
        }

        public bool Enviar(SmtpClient client, MailMessage mail)
        {
            bool enviado = false;
            try
            {
                client.Send(mail);
                enviado = true;
            }
            catch (System.Exception erro)
            {
                return enviado;
            }
            finally
            {
                mail = null;
            }
            return enviado;
        }

        public bool ConfiguracaoCorpo(Email email)
        {
            SmtpClient client = ConfiguracaoServidor(email);
            MailMessage mail = new MailMessage();

            if (email.Anexo.Length != 0)
            {
                foreach (var anexo in email.Anexo)
                {
                    Attachment anexar = new Attachment(anexo);
                    mail.Attachments.Add(anexar);
                }
            }

            mail.Sender = new System.Net.Mail.MailAddress(email.EmailEnviador, "Acme Sistema");
            mail.From = new MailAddress(email.EmailEnvio, "Acme Sistemas");
            mail.To.Add(new MailAddress(email.EmailDestino, email.NomeEnviador));
            mail.Subject = email.Titulo;
            mail.Body = email.Texto;
            mail.IsBodyHtml = email.TextHtml;
            mail.Priority = MailPriority.High;
            return Enviar(client, mail);
        }

    }
}
