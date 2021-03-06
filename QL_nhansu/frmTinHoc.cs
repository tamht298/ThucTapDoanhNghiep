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
    public partial class frmTinHoc : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsTinHoc nvdn = new QL_nhansu.Class.clsTinHoc();
        public frmTinHoc()
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
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa tin học", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.Xoa_TinHoc(txtMaTinHoc.Text);
                nvdn.LoadDataGridView(dgvTinHoc);
                Xoa();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = false;
                   
                    dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
              
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai = true;
            int MaTH = dk.MaTuTang(dgvTinHoc);

             if (MaTH <= 9)
            {
                txtMaTinHoc.Text = "TH" + "0" + MaTH.ToString();
            }
            else
            {
                txtMaTinHoc.Text = "TH" + MaTH.ToString();
            }
          
                    dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
              
                txtTenTinHoc.Text = "";
               
           
        }

        private void frmTinHoc_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvTinHoc);
        }

        private void dgvTinHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvTinHoc.CurrentRow.Index;
            txtMaTinHoc.Text = dgvTinHoc[0, hang].Value.ToString();
            txtTenTinHoc.Text = dgvTinHoc[1, hang].Value.ToString();
            
        }
        public void Xoa()
        {
            txtMaTinHoc.Text = "";
            txtTenTinHoc.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
              if (txtMaTinHoc.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã tin học không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTinHoc.Focus();
            }

            else

                  if (txtTenTinHoc.Text.Trim() == "")
                  {
                      MessageBoxEx.Show("Tên tin học không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      txtTenTinHoc.Focus();
                  }
                  else
                  {
                      if (trangthai == true)
                      {
                          nvdn.Them_TinHoc(txtMaTinHoc.Text, txtTenTinHoc.Text);
                      }
                      else
                      {
                          nvdn.Sua_TinHoc(txtMaTinHoc.Text, txtTenTinHoc.Text);
                      }
                      nvdn.LoadDataGridView(dgvTinHoc);
                      dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                      Xoa();
                  }
        }
    }
}