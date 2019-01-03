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

namespace QL_nhansu
{
    public partial class frmDoiMatKhau : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsThemUser nvdn = new QL_nhansu.Class.clsThemUser();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
           
            
            nvdn.LoadDataGridView_User(dgvUser);
            nvdn.LoadComboBox_User(cbTenDangNhap);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvUser.CurrentRow.Index;
            cbTenDangNhap.Text = dgvUser[0, hang].Value.ToString();
            txtMatKhauCu.Text = dgvUser[1, hang].Value.ToString();
            txtMatKhauMoi.Text = txtMatKhauCu.Text;
      
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matkhau = "";
            try
            {
                SqlConnection sqlConn = Class.clsData.OpenSqlConnection();
                string sqlMatKhau = "SELECT Pass FROM tblNguoidung WHERE Usename='" + cbTenDangNhap.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlMatKhau);
               cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConn;
                matkhau = (string)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            if (txtMatKhauCu.Text != matkhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
                txtMatKhauCu.Focus();
            }
            else
            {
                if (txtMatKhauMoi.Text.Trim() == "" || txtMatKhauMoi.Text.Length > 20)
                {
                    MessageBoxEx.Show("Mật khẩu mới không được trống hoặc >20 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauMoi.Focus();
                }
                else
                {
                    nvdn.SuaTK1(cbTenDangNhap.Text.ToString(), txtMatKhauMoi.Text.ToString());
                    nvdn.LoadDataGridView_User(dgvUser);
                    //txtMatKhauMoi.Enabled = false;
                    //txtMatKhauCu.Enabled = false;
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauCu.Text = "";
                    txtMatKhauMoi.Text = "";
                }

            }
        }


    }

}