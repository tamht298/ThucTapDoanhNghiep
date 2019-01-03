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
    public partial class Frm_BC_Nhansu_Dotuoi : Form
    {
        Class.clsReport nvrp = new Class.clsReport();
        public Frm_BC_Nhansu_Dotuoi()
        {
            InitializeComponent();
        }

        private void Frm_BC_Nhansu_Dotuoi_Load(object sender, EventArgs e)
        {
            for (int i = 18; i <= 65; i++)
            {
                cmbFrom.Items.Add(i.ToString());
                CmbTo.Items.Add(i.ToString());
            }
            cmbFrom.SelectedItem = "18";
            CmbTo.SelectedItem = "18";

        }
        //Download source code FREE tai Sharecode.vn

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
             //CrystalReport_BC_Dotuoi bc = new CrystalReport_BC_Dotuoi();
            //nvrp.loaddg_THEO_DOTUOI(CryView_BC_Dotuoi, bc, int.Parse(cmbFrom.SelectedText.ToString()),int.Parse(CmbTo.SelectedText.ToString()));
            //nvrp.loaddg_THEO_DOTUOI(CryView_BC_Dotuoi, bc, int.Parse(cmbFrom.SelectedItem.ToString()), int.Parse(CmbTo.SelectedItem.ToString()));
        
        }
    }
}
