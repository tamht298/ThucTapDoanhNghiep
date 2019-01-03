using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace QL_nhansu.Class
{
    class GuiOTP
    {
        string email = "doandungchung@gmail.com";
        string pass = "Doan@123";
        public string strNumber;
        public int SendOTP(string userEmail)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential(email, pass);
                MailMessage message = new MailMessage(email, userEmail);
                message.Subject = "Mã OTP";
                Random rdn = new Random();
                strNumber = (rdn.Next(100000, 999999).ToString());
                message.Body = "Mã OTP là: " + strNumber;
                mailclient.Send(message);

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}
