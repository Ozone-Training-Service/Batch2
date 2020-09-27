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

                mail.From = new MailAddress("vishnukumarps2017@gmail.com");




                mail.To.Add("anu.cs1995@gmail.com");
                mail.Subject = "Test Email";
                mail.Body = "Hello ";


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("vishnukumarps2017@gmail.com", "passwoed");
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
