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
    public partial class frmTimKiem : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsTimKiem nvdn = new QL_nhansu.Class.clsTimKiem();

        public frmTimKiem()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text.Trim() == "")
                {
                    lblKetQua.Text = "Bạn cần phải nhập từ khóa tìm kiếm!";
                    txtTimKiem.Focus();
                }
                else
                {
                    if (i == 1)
                    {
                        nvdn.LoadDataGridView_TK_MaNV(dgvTimKiem, txtTimKiem.Text.Trim());
                    }
                    if (i == 2)
                    {
                        nvdn.LoadDataGridView_TK_HoTen(dgvTimKiem, txtTimKiem.Text.Trim());

                    }
                    if (i == 3)
                    {
                        nvdn.LoadDataGridView_TK_CMND(dgvTimKiem, txtTimKiem.Text.Trim());

                    }
                    if (dgvTimKiem.RowCount == 0)
                    {
                        lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text;
                    }
                    else
                    {
                        lblKetQua.Text = "Kết quả tìm thấy " + txtTimKiem.Text + " là: " + dgvTimKiem.RowCount.ToString();
                    }
                    
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Không tìm thấy ");
                //lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text + " nào cả! ";
               lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text + " nào cả! ";
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            rdMaNV.Checked = true;
            dgvTimKiem.ReadOnly=true;
            nvdn.LoadDataGridView_TK(dgvTimKiem);
       
           

        }

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;

        }

        private void rdTenNv_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void rdCMND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text.Trim() == "")
                {
                    lblKetQua.Text = "Bạn cần phải nhập từ khóa tìm kiếm!";
                    txtTimKiem.Focus();
                }
                else
                {
                    if (i == 1)
                    {
                        nvdn.LoadDataGridView_TK_MaNV(dgvTimKiem, txtTimKiem.Text.Trim());
                    }
                    if (i == 2)
                    {
                        nvdn.LoadDataGridView_TK_HoTen(dgvTimKiem, txtTimKiem.Text.Trim());

                    }
                    if (i == 3)
                    {
                        nvdn.LoadDataGridView_TK_CMND(dgvTimKiem, txtTimKiem.Text.Trim());

                    }

                }
            }
            catch (Exception)
            {
                lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text + " nào cả! ";
            }
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();

        }

        
    }
}