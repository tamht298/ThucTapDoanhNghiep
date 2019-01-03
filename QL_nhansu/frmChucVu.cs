using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Globalization;


namespace QL_nhansu
{
    public partial class frmChucVu : DevComponents.DotNetBar.Office2007Form
    {
       
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsChucVu nvdn = new QL_nhansu.Class.clsChucVu();
        bool Trangthai = true;

        public frmChucVu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Trangthai = true;   
            int MaChucVu = dk.MaTuTang(dgvChucVu);
                if (MaChucVu <= 9)
                {
                    txtMaChucVu.Text = "CV" + "0" + MaChucVu.ToString();
                }
                else
                {
                    txtMaChucVu.Text = "CV" + MaChucVu.ToString();
                }
               
                        
                        dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    
            txtTenChucVu.Text = "";
            txtGhiChu.Text = "";
            txtHeso.Text="";
                  
                
        }

        

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvChucVu);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa chức vụ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaCV(txtMaChucVu.Text);
                nvdn.LoadDataGridView(dgvChucVu);
                Xoa();
              
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai = false;
           
                   
                    dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                
               
            
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvChucVu.CurrentRow.Index;
            txtMaChucVu.Text = dgvChucVu[0, hang].Value.ToString();
           
            txtTenChucVu.Text = dgvChucVu[1, hang].Value.ToString();
            txtHeso.Text = dgvChucVu[2, hang].Value.ToString();
            txtGhiChu.Text = dgvChucVu[3, hang].Value.ToString();
          
        }

        public void Xoa()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtGhiChu.Text = "";
            txtHeso.Text="";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
        if (txtMaChucVu.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Mã chức vụ không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaChucVu.Focus();
                }

                else
                
                    if (txtTenChucVu.Text.Trim() == "")
                    {
                        MessageBoxEx.Show("Tên chức vụ không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenChucVu.Focus();
                    }
                    else
                        if (txtHeso.Text.Trim() == "" || Convert.ToDecimal(txtHeso.Text) < 0 || Convert.ToDecimal(txtHeso.Text) > 2)
                        {
                            MessageBoxEx.Show("Hệ số không được trống và >0 và <2 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtHeso.Focus();
                        }
                        else
                        {
                            if (Trangthai == true)
                            {
                                nvdn.ThemCV(txtMaChucVu.Text, txtTenChucVu.Text, decimal.Parse(txtHeso.Text), txtGhiChu.Text);
                            }
                            else
                            {
                                nvdn.SuaCV(txtMaChucVu.Text, txtTenChucVu.Text, decimal.Parse(txtHeso.Text), txtGhiChu.Text);
                            }
                            nvdn.LoadDataGridView(dgvChucVu);
                            dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                            Xoa();
                        }

        }

        private void txtHeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtHeso);

        }


       
       

    }
}