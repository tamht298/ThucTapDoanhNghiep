using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace QL_nhansu
{
    public partial class Mail : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsPhongBan pb = new QL_nhansu.Class.clsPhongBan();
        SqlConnection MyConnection;
        public Mail()
        {
            InitializeComponent();
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            MyConnection = QL_nhansu.Class.clsData.OpenSqlConnection();
            pb.LoadComboBox_PhongBan(comboBoxEx1);
        }

        private void btnattach_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(filename.ToString());
                }
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);

                MailMessage message = new MailMessage(txtFrom.Text, comboBoxEx1.Text=comboBoxEx1.SelectedValue.ToString());
                message.Subject = txtSubject.Text;
                message.Body = txtBody.Text;



                //Nếu có nhập Cc
                if (txtCc.Text != "")
                {
                    //Cắt chuỗi Cc bằng dấu ";"
                    string[] cc = txtCc.Text.Split(';');

                    foreach (var _cc in cc)
                    {
                        message.CC.Add(_cc.ToString());
                    }
                }

                //Nếu có nhập Bcc
                if (txtBcc.Text != "")
                {
                    //Cắt chuỗi Bcc bằng dấu ";"
                    string[] bcc = txtBcc.Text.Split(';');

                    foreach (var _bcc in bcc)
                    {
                        message.Bcc.Add(_bcc.ToString());
                    }
                }

                //Kiểm tra nếu có file trong listBox1
                if (listBox1.Items.Count > 0)
                {
                    foreach (var filename in listBox1.Items)
                    {
                        //Kiểm tra file có tồn tại trong ổ đĩa không
                        if (File.Exists(filename.ToString()))
                        {
                            //Thêm file đính kèm vào tin nhắn
                            message.Attachments.Add(new Attachment(filename.ToString()));
                        }
                    }
                }

                mailclient.Send(message);
                MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBcc.Text = "";
                txtBody.Text = "";
                txtPass.Text = "";
                txtSubject.Text = "";
                txtCc.Text = "";
                txtFrom.Text = "";
                comboBoxEx1.Text = "";
                listBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Error","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
        

