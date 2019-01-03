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
    public partial class frmPhongBan : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsPhongBan nvdn = new QL_nhansu.Class.clsPhongBan();
        public frmPhongBan()
        {
            InitializeComponent();
        }

                bool trangthai = true;

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua,btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvPhongBan);
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa phòng ban", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaPB(txtMaPhongBan.Text);
                nvdn.LoadDataGridView(dgvPhongBan);
                txtMaPhongBan.Text = dgvPhongBan[0, 0].Value.ToString();
                txtTenPhongBan.Text = dgvPhongBan[1, 0].Value.ToString();
                txtMoTa.Text = dgvPhongBan[2, 0].Value.ToString();
                txtmail.Text = dgvPhongBan[3, 0].Value.ToString();
                //dk.Xoa(btnThem, btnSua, btnXoa, btnThoat);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvPhongBan.CurrentRow.Index;
            txtMaPhongBan.Text = dgvPhongBan[0, hang].Value.ToString();
            txtTenPhongBan.Text = dgvPhongBan[1, hang].Value.ToString();

            txtMoTa.Text = dgvPhongBan[2, hang].Value.ToString();
            txtmail.Text = dgvPhongBan[3, hang].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai=true;
            int MaPB = dk.MaTuTang(dgvPhongBan);

            if (MaPB <= 9)
            {
                txtMaPhongBan.Text = "PB" + "0" + MaPB.ToString();
            }
            else
            {
                txtMaPhongBan.Text = "PB" + MaPB.ToString();
            }
               
              dk.Them(btnThem, btnSua,btnLuu, btnXoa, btnThoat);
              txtTenPhongBan.Text = "";
              txtMoTa.Text = "";
            }

                   
        private void btnLuu_Click(object sender, EventArgs e)
        {
        
         if (txtMaPhongBan.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Mã phòng ban không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPhongBan.Focus();
                }

                else

             if (txtTenPhongBan.Text.Trim() == "")
             {
                 MessageBoxEx.Show("Tên phòng ban không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtTenPhongBan.Focus();
             }
             else
             {
                 if (trangthai == true)
                 {
                     nvdn.ThemPB(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMoTa.Text,txtmail.Text);
                 }
                 else
                 {
                     nvdn.SuaPB(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMoTa.Text,txtmail.Text);
                 }
                 nvdn.LoadDataGridView(dgvPhongBan);
                 dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                 Xoa();
             }
        }

        public void Xoa()
        {
            txtMaPhongBan.Text = "";
            txtTenPhongBan.Text = "";
            txtMoTa.Text = "";
        }
      

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            trangthai = false;

            dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    
        }
        
    }
    
}