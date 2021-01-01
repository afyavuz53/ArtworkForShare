using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Helper
{
    public static class MailHelper
    {
        public static bool SendActivationCode(string userName, string eMail, Guid code)
        {            
            MailMessage msg = new MailMessage();
            msg.To.Add(eMail);
            msg.Subject = "ArtworkForShare";
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<!DOCTYPE html><html><head><title>Artwork4Share</title></head><body><h2>Merhaba {0} sitemize hoşgeldin</h2><p>Hesabınızı aktifleştirmek için lütfen <a href='http://localhost:51680/Account/ActivationUser/{1}'>buraya</a> tıklayınız</p></body></html>", userName, code);
            msg.From = new MailAddress("Guid34Coder@outlook.com", "Artwork4Share");

            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            NetworkCredential network = new NetworkCredential("Guid34Coder@outlook.com", "Coder159");
            client.Credentials = network;
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool RecoverPasswordMail(string userName, string eMail,int id)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(eMail);
            msg.Subject = "ArtworkForShare";
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<!DOCTYPE html><html><head><title>Artwork4Share</title></head><body><h2>Merhaba {0}</h2><p>Şifrenizi yenilemek için <a href='http://localhost:51680/Account/ResetPassword/{1}'>buraya</a> tıklayınız</p></body></html>", userName,id);
            msg.From = new MailAddress("Guid34Coder@outlook.com", "Artwork4Share");

            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            NetworkCredential network = new NetworkCredential("Guid34Coder@outlook.com", "Coder159");
            client.Credentials = network;
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
