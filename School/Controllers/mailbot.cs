using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace School.Controllers
{
    public class mailbot
    {
        public mailbot()
        {

        }

        public static void send(string Email, string caption, string text)
        {

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("dbschool.krigin.psu@gmail.com", "DB School");
            // кому отправляем
            MailAddress to = new MailAddress(Email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = caption;
            // текст письма
            m.Body = text;
            //"<h2>Вы были зарегестрированы в DB School</h2><p>Это автоматическое сообщение о регистрации вашей почты в приложении DB School</p>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("dbschool.krigin.psu@gmail.com", "Q2PrsWeU");
            smtp.EnableSsl = true;
            smtp.Send(m);


        }
    }
}
