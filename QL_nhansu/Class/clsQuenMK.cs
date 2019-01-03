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
    class clsQuenMK
    {
        string email = "doandungchung@gmail.com";
        string pass = "Doan@123";
        public int QuenMK(string userName, string userEmail)
        {
            if (checkUserName(userName, userEmail))
            {
                try
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential(email, pass);
                    MailMessage message = new MailMessage(email, userEmail);
                    message.Subject = "Khôi phuc mật khẩu";
                    message.Body = "Mật khẩu mới là: 123456";
                    mailclient.Send(message);
                    ResetPass(userName);
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private bool checkUserName(string userName, string userEmail)
        {
            string name = null;
            string mail = null;
            SqlConnection conn = Class.clsData.OpenSqlConnection();
            string strSql = "SELECT Usename FROM tblNguoidung WHERE Usename = '" + userName + "'";
            string strSql1 = "SELECT Email FROM tblNguoidung WHERE Email = '" + userEmail + "'";

            SqlCommand cmd = new SqlCommand(strSql);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            SqlCommand cmd1 = new SqlCommand(strSql1);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;
            try
            {
                name = (string)cmd.ExecuteScalar();
                mail = (string)cmd1.ExecuteScalar();
                if (name != null && mail != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void ResetPass(string userName)
        {
            string name = null;
            SqlConnection conn = Class.clsData.OpenSqlConnection();
            string strSql = "SELECT Usename FROM tblNguoidung WHERE Usename = '" + userName + "'";
            SqlCommand cmd = new SqlCommand(strSql);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            try
            {
                name = (string)cmd.ExecuteScalar();
                if (name != null)
                {
                    clsData kn = new clsData();
                    kn.StoreNone("proc_Taikhoan_Update", userName, "123456");
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}
