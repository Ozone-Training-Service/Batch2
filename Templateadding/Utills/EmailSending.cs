using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TemplateAdding.Utills
{
    public class EmailSending
    {
        public void mail(string address, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("liyas71996@gmail.com");
                mail.To.Add(address);
                mail.Subject = subject;
                mail.Body = message;

                
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("liyas71996@gmail.com", "sjlp71996");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);


            }
            catch (Exception e)
            {

            }
        }
    }
}
