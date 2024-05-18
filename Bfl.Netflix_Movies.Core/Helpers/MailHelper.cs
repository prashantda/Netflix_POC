using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Helpers
{
    public static  class MailHelper
    {

        public async static Task<int>  SendMail(string to,string? sub,string? body)
        {
            var otp = new Random().Next(100000, 999999);
            if (body == null || sub is null)
            {
                sub = $"Otp From BFL_Netflix";
                body = $"<h3>Your OTP is<h3>  <h1>   {otp}<h1>";
            }
            var from = ConfigurationManager.AppSetting["Mail:Gmail"];
            var password= ConfigurationManager.AppSetting["Mail:Password"];
            var host = "smtp.gmail.com";
            var client = new SmtpClient(host,587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(from, password);
            client.EnableSsl = true;
            var mailMessage=new MailMessage(from,to,sub,body);
            mailMessage.IsBodyHtml = true;
            await  client.SendMailAsync(mailMessage);           
                return otp;          
        }
    }
}
