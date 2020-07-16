using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.Logic
{
    public class FindLoveFeature
    {
        private string m_LoveMatchMail;
        public string FindLoveMatch(User i_LoggedInUser)
        {
            string result = null;

            Random rnd = new Random();
            int num1 = rnd.Next(1, 20);
            int num2 = rnd.Next(1, 20);


            User MatchTinderfriend = i_LoggedInUser.Friends[num1].Friends[num2];

            while (MatchTinderfriend.Gender == i_LoggedInUser.Gender)
            {
                num1 = rnd.Next(1, 20);
                num2 = rnd.Next(1, 20);
                MatchTinderfriend = i_LoggedInUser.Friends[num1].Friends[num2];
            }

            m_LoveMatchMail = MatchTinderfriend.Email;
            result = MatchTinderfriend.PictureLargeURL;
            return result;

        }
        public void SendMail(User i_LoggedInUser)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(@"facebookuserEranHarel@gmail.com");
            mail.Subject = "Hey! Facebook sending mail feature";
            mail.To.Add(m_LoveMatchMail);
            mail.Body = string.Format(@"Hey, {0} Interested in starting a conversation with you!! ", i_LoggedInUser.Name);
            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential(@"facebookuserEranHarel@gmail.com", "Fb123456");
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);
        }

    }
}
