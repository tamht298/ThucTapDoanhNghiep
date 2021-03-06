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
    public partial class frmTonGiao : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsTonGiao nvdn = new QL_nhansu.Class.clsTonGiao();
        public frmTonGiao()
        {
            InitializeComponent();
        }
        bool trangthai = true;

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua,btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvTonGiao);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa tôn giáo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.Xoa_TonGiao(txtMaTonGiao.Text);
                nvdn.LoadDataGridView(dgvTonGiao);
                txtMaTonGiao.Text = "";
                txtTenTonGiao.Text = "";
                


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = false;
           
            dk.Sua(btnThem, btnSua, btnLuu,btnXoa, btnThoat);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai = true;
           
            int MaTG = dk.MaTuTang(dgvTonGiao);

            if (MaTG <= 9)
            {
                txtMaTonGiao.Text = "TG" + "0" + MaTG.ToString();
            }
            else
            {
                txtMaTonGiao.Text = "TG" + MaTG.ToString();
            }
            dk.Them(btnThem, btnSua,btnLuu, btnXoa, btnThoat);
            Xoa();
           
                
           // }
        }

        private void dgvTonGiao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvTonGiao.CurrentRow.Index;
            txtMaTonGiao.Text = dgvTonGiao[0, hang].Value.ToString();
            txtTenTonGiao.Text = dgvTonGiao[1, hang].Value.ToString();
        }
        public void Xoa()
        {
          // txtMaTonGiao.Text="";
            txtTenTonGiao.Text = "";
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTonGiao.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã tôn giáo không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTonGiao.Focus();
            }

            else

                if (txtTenTonGiao.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Tên tôn giáo không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenTonGiao.Focus();
                }
                else
                {
                    if (trangthai == true)
                    {
                        nvdn.Them_TonGiao(txtMaTonGiao.Text, txtTenTonGiao.Text);
                    }
                    else
                    {
                        nvdn.Sua_TonGiao(txtMaTonGiao.Text, txtTenTonGiao.Text);
                    }
                    nvdn.LoadDataGridView(dgvTonGiao);
                    dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    txtMaTonGiao.Text = "";
                    txtTenTonGiao.Text = "";
                }
        }
    }
}