using System;
using System.Net.Mail;
namespace EmailSending
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("liyas71996@gmail.com");




                mail.To.Add("anu.cs1995@gmail.com");
                mail.Subject = "Test Email";

                mail.Body = "Hlo ";


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("liyas71996@gmail.com", "sjlp71996");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Email Send Succesfully");
        }
    }
}


