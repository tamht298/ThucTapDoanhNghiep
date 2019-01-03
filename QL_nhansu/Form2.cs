using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_nhansu
{
    public partial class Form2 : Form
    {
        Class.clsReport bc = new QL_nhansu.Class.clsReport();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bc.LoadComboBox_BCNV_DONVI(cbDonvi);
        }

        private void btnLayds_Click(object sender, EventArgs e)
        {
            CrystalReport2 rp = new CrystalReport2();
            bc.loaddg_NHANVIEN_DONVI(CryView, rp, cbDonvi.SelectedValue.ToString());
        }
    }
}
