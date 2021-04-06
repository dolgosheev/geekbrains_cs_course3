﻿using System.Net;
using System.Net.Mail;

namespace Lesson1
{
    public static class MailSettings
    {
        private static readonly string _pass = "<YOUR PASSWORD HERE>";

        public static string Mail = "<YOU MAIL HERE>@gmail.com";
        public static string Name = "<YOU NAME HERE>";

        public static SmtpClient Prepared = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(Mail, _pass)
        };
    }
}