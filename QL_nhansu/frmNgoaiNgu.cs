using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu
{
    public partial class frmNgoaiNgu : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsNgoaiNgu nvdn = new QL_nhansu.Class.clsNgoaiNgu();
        public frmNgoaiNgu()
        {
            InitializeComponent();
        }
        bool trangthai = true;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa ngoại ngữ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.Xoa_NgoaiNgu(txtMaNgoaiNgu.Text);
                nvdn.LoadDataGridView(dgvNgoaiNgu);
                Xoa();


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          trangthai=false;
                   
                    dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai=true;
            int MaNN = dk.MaTuTang(dgvNgoaiNgu);

            if (MaNN <= 9)
            {
                txtMaNgoaiNgu.Text = "NN" + "0" + MaNN.ToString();
            }
            else
            {
                txtMaNgoaiNgu.Text = "NN" + MaNN.ToString();
            }

                  
                    dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);

                    txtTenNgoaiNgu.Text = "";
                
            
        }

        private void dgvNgoaiNgu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvNgoaiNgu.CurrentRow.Index;
            txtMaNgoaiNgu.Text = dgvNgoaiNgu[0, hang].Value.ToString();
            txtTenNgoaiNgu.Text = dgvNgoaiNgu[1, hang].Value.ToString();
        }

        private void frmNgoaiNgu_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvNgoaiNgu);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNgoaiNgu.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã ngoại ngữ không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNgoaiNgu.Focus();
            }
            else
            
                if (txtTenNgoaiNgu.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Tên ngoại ngữ không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenNgoaiNgu.Focus();
                }
                else
                {
                    if (trangthai == true)
                    {
                        nvdn.Them_NgoaiNgu(txtMaNgoaiNgu.Text, txtTenNgoaiNgu.Text);
                    }
                    else
                    {
                        nvdn.Sua_NgoaiNgu(txtMaNgoaiNgu.Text, txtTenNgoaiNgu.Text);
                    }
                    nvdn.LoadDataGridView(dgvNgoaiNgu);
                    dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    Xoa();
                    }

        }
        public void Xoa()
        {
            txtMaNgoaiNgu.Text = "";
            txtTenNgoaiNgu.Text = "";
        }
    }
}