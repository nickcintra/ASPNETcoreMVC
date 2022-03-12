using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class Constats
    {

        //POP3, IMAP - Ler nsagens de e-mail
        //SMTP - Enviar e-mail
        

        //Autenticação- Gmail
        public readonly static string Usuario = "nickcintra@gmail.com";
        public readonly static string Senha = "cassialinda456123";

        //Servido SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;
    }
}
