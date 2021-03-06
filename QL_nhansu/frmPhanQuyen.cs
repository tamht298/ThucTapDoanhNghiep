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
    public partial class frmPhanQuyen : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsPhanQuyen nvdn = new QL_nhansu.Class.clsPhanQuyen();
       
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        public int quyen =0;
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
           // dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvPhanQuyen);
            txtTaiKhoan.Text = dgvPhanQuyen[0, 0].Value.ToString();
            txtMatKhau.Text = dgvPhanQuyen[1, 0].Value.ToString();
            //cmbQuyen.Text = dgvPhanQuyen[2, 0].Value.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa tài khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.Xoa_TaiKhoan_PQ(txtTaiKhoan.Text);
                nvdn.LoadDataGridView(dgvPhanQuyen);
               // dk.Xoa(btnThem, btnSua, btnXoa, btnThoat);
                txtTaiKhoan.Text = dgvPhanQuyen[0, 0].Value.ToString();
                txtMatKhau.Text = dgvPhanQuyen[1, 0].Value.ToString();
                //cmbQuyen.Text = dgvPhanQuyen[2, 0].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Nhapdulieu() == true)
            {
                if (quyen == 2)
                {
                    nvdn.Them_TaiKhoan_PQ(txtTaiKhoan.Text, txtMatKhau.Text, quyen);
                }
                if (quyen == 1)
                {
                    nvdn.Them_TaiKhoan_PQ(txtTaiKhoan.Text, txtMatKhau.Text, quyen);
                }
                if (quyen == 0)
                {
                    nvdn.Them_TaiKhoan_PQ(txtTaiKhoan.Text, txtMatKhau.Text, quyen);
                }
                //dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                nvdn.LoadDataGridView(dgvPhanQuyen); 
            }
            else
            {
                MessageBoxEx.Show(" Không phân quyền được", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }

        
        }
        bool Nhapdulieu()
        {
            bool ok = false;
            if (dk.KiemTraMa(dgvPhanQuyen, txtTaiKhoan.Text) == true)
            {
                MessageBoxEx.Show("Tên đăng nhập đã có người sử dụng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
            else
                if (txtTaiKhoan.Text.Trim() == ""||txtMatKhau.Text.Length>10)
                {
                    MessageBoxEx.Show("Tên đăng nhập không được trống và <10 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Focus();
                }
                else
                {
                    if (txtMatKhau.Text.Trim() == "" || txtMatKhau.Text.Length > 20)
                    {
                        MessageBoxEx.Show("Mật khẩu không được trống và <20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau.Focus();
                    }
                    else
                    {
                        ok = true;


                    }
                }
            return ok;

        }


        private void dgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvPhanQuyen.CurrentRow.Index;
            txtTaiKhoan.Text = dgvPhanQuyen[0, hang].Value.ToString();
            txtMatKhau.Text = dgvPhanQuyen[1, hang].Value.ToString();
            //cmbQuyen.Text = dgvPhanQuyen[2, hang].Value.ToString();

        }

        private void rdadmin_CheckedChanged(object sender, EventArgs e)
        {
            quyen = 2;
        }

        private void rdTruongphong_CheckedChanged(object sender, EventArgs e)
        {
            quyen = 1;
        }

        private void rdNhanvien_CheckedChanged(object sender, EventArgs e)
        {
            quyen = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ( nhapsua()==true)
            {
                if (quyen == 2)
                {
                    nvdn.Sua_TaiKhoan_PQ(txtTaiKhoan.Text, txtMatKhau.Text, quyen);
                }
                if (quyen == 1)
                {
                    nvdn.Sua_TaiKhoan_PQ(txtTaiKhoan.Text, txtMatKhau.Text, quyen);
                }
                if (quyen == 0)
                {
                    nvdn.Sua_TaiKhoan_PQ(txtTaiKhoan.Text, txtMatKhau.Text, quyen);
                }
                //dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                nvdn.LoadDataGridView(dgvPhanQuyen);
            }
            else
            {
                MessageBoxEx.Show(" Không phân quyền được", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        bool nhapsua()
        {
            bool kt = false;
            if (txtMatKhau.Text.Trim() == "" || txtMatKhau.Text.Length > 20)
            {
                MessageBoxEx.Show("Mật khẩu không được trống và <20 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else 
            {
                kt = true;
            }
            return kt;

        }


        }

       
    
}