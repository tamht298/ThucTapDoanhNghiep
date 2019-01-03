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
    public partial class frmBaocaonhansu : DevComponents.DotNetBar.Office2007Form
    {
        public int chon = 0;
        public frmBaocaonhansu()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void frmBaocaonhansu_Load(object sender, EventArgs e)
        {

        }

        private void rdoKhenthuong_CheckedChanged(object sender, EventArgs e)
        {
            chon = 1;
        }

        private void rdoKyluat_CheckedChanged(object sender, EventArgs e)
        {
            chon = 2;
        }

        private void rdoChucvu_CheckedChanged(object sender, EventArgs e)
        {
            chon = 3;
        }

        private void rdoDotuoi_CheckedChanged(object sender, EventArgs e)
        {
            chon = 4;
        }

        private void rdoNghiviec_CheckedChanged(object sender, EventArgs e)
        {
            chon = 5;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            
            if (chon == 3)
            {
                Frm_BC_NhanSu_ChucVu f_Chucvu = new Frm_BC_NhanSu_ChucVu();
                f_Chucvu.ShowDialog();
            }
            if (chon == 4)
            {
                Frm_BC_Nhansu_Dotuoi f_Dotuoi = new Frm_BC_Nhansu_Dotuoi();
                f_Dotuoi.ShowDialog();
            }
        }

        

       

        private void rdoPhongban_CheckedChanged(object sender, EventArgs e)
        {
            chon = 6;
        }
    }
}