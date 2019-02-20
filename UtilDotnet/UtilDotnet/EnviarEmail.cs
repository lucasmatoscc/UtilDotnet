using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace UtilDotnet
{
    public class EnviarEmail 
    {
        public String username;
        public String password;

        public EnviarEmail(String usernameEmail, String passwordEmail) {
            this.username = usernameEmail;
            this.password = passwordEmail;
        }

        public void enviarEmail(string to, List<string> ccs, string titulo, string descEmail, byte[] bytes)
        {
            //Instância classe email
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            foreach (var item in ccs)
            {
                mail.CC.Add(item);
            }
            if (bytes != null)
                mail.Attachments.Add(new Attachment(new MemoryStream(bytes), "archive.pdf"));
            mail.From = new MailAddress(username);
            mail.Subject = titulo;
            string Body = descEmail;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //Instância smtp do servidor, neste caso o gmail.
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            (username, password);// Login e senha do e-mail.
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
