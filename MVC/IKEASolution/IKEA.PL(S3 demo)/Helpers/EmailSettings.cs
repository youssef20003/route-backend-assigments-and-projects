using System.Net;
using System.Net.Mail;
using IKEA.DAL.Models;

namespace IKEA.PL_S3_demo_.Helpers
{
    public class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            var Client = new SmtpClient("smtp.gmail.com" , 587);
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential("ym05914@gmail.com", "xjjh ijdz qyyq coep");
            Client.Send("ym05914@gmail.com" , email.To,email.Subject,email.Body);
        }
    }
}
