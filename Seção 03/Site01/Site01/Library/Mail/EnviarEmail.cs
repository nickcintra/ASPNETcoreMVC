using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br/> E-mail: {1}<br/> Assunto: {2}<br/> Mensagem: {3}<br/>", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //Configurar Servidor SMTP
            SmtpClient smtp = new SmtpClient(Constats.ServidorSMTP, Constats.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constats.Usuario, Constats.Senha);

            //Mensagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("nickcintra@gmail.com");
            mensagem.To.Add("nickcintra@gmail.com");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de Contato</h1>" + conteudo;

            smtp.Send(mensagem);
        }
    }
}
