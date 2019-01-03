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

using System.Security.Cryptography;
namespace QL_nhansu
{
    public partial class frmThemNguoiDung : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsThemUser nvdn = new QL_nhansu.Class.clsThemUser();
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();

        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            nvdn.LoadDataGridView_User(dgvNguoiDung);

            txtTenDangNhap.Text = dgvNguoiDung[0, 0].Value.ToString();
            txtMatKhau1.Text = dgvNguoiDung[1, 0].Value.ToString();
            txtMatKhau2.Text = txtMatKhau1.Text;
            txtmail.Text = dgvNguoiDung[2,0].Value.ToString();
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvNguoiDung.CurrentRow.Index;
            txtTenDangNhap.Text = dgvNguoiDung[0, hang].Value.ToString();
            txtMatKhau1.Text = dgvNguoiDung[1, hang].Value.ToString();
            txtMatKhau2.Text = txtMatKhau1.Text;
            txtmail.Text = dgvNguoiDung[2, hang].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản " + txtTenDangNhap.Text + " Không ?", "Xóa người dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaTK(txtTenDangNhap.Text.ToString().Trim());
                nvdn.LoadDataGridView_User(dgvNguoiDung);
                txtTenDangNhap.Text = dgvNguoiDung[1, 0].Value.ToString();
                txtMatKhau1.Text = dgvNguoiDung[2, 0].Value.ToString();
                txtMatKhau2.Text = txtMatKhau1.Text;
                txtmail.Text = dgvNguoiDung[2,0].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xoa(); 
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dk.KiemTraMa(dgvNguoiDung, txtTenDangNhap.Text) == true)
            {
                MessageBoxEx.Show("Tên đăng nhập đã có người sử dụng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else
                if (txtTenDangNhap.Text.Trim() == "" || txtTenDangNhap.Text.Length > 10)
                {
                    MessageBoxEx.Show("Tên đăng nhập không được trống và <10 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                }
                else
                    if (txtMatKhau1.Text.Trim() == "" || txtMatKhau1.Text.Length > 20)
                    {
                        MessageBoxEx.Show("Mật khẩu không được trống và >20 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau1.Focus();
                    }
                    else
                        if (txtMatKhau2.Text.Trim() == "")
                        {
                            MessageBoxEx.Show("Mật khẩu nhập lại không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatKhau2.Focus();
                        }
                        else
                        {
                            if (txtMatKhau1.Text.ToUpper() != txtMatKhau2.Text.ToUpper())
                            {
                                MessageBoxEx.Show("Mật khẩu nhập lại không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMatKhau2.Focus();
                            }
                            else
                            {
                    
                    
                                nvdn.NhapTK(txtTenDangNhap.Text, txtMatKhau2.Text,txtmail.Text);
                                nvdn.LoadDataGridView_User(dgvNguoiDung);
                                Xoa();
                            }
                        }
        }
        public void Xoa()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau1.Text = "";
            txtMatKhau2.Text = "";
            txtmail.Text = "";
        }

   
    }
}