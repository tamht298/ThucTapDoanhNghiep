using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu
{
    public partial class Frm_BC_NhanSu_ChucVu : Form
    {
        Class.clsReport nvrp = new Class.clsReport();
        public Frm_BC_NhanSu_ChucVu()
        {
            InitializeComponent();
        }

        private void Frm_BC_NhanSu_ChucVu_Load(object sender, EventArgs e)
        {
            nvrp.LoadComboBox_BCNS_Chucvu(CboChucvu);
        }

      

       

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            CrystalReport_BC_ChucVu bc = new CrystalReport_BC_ChucVu();
            nvrp.loaddg_THEO_CHUCVU(CryView_BC_NhanSu_ChucVu, bc, CboChucvu.SelectedValue.ToString());
        }

       
        

    }
}
