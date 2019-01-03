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
    public partial class frmThongBaoChuyenNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsLayphongban tolamviec = new QL_nhansu.Class.clsLayphongban();
        Class.clsChuyenNhanVien nvdn = new QL_nhansu.Class.clsChuyenNhanVien();
        public string  chuyen ="";
        public string maphong = null;
        public string mato = null;
        public string machucvu = null;


        public frmThongBaoChuyenNhanVien()
        {
            InitializeComponent();
        }
        
        private void frmThongBaoChuyenNhanVien_Load(object sender, EventArgs e)
        {
            nvdn.LoadComboBox_PhongBan(cmbPhongBan);
            nvdn.LoadComboBox_ChucVu(cmbChucVu);
            //nvdn.LoadComboBox_ToLamViec(cmbTo, cmbPhongBan.SelectedValue.ToString());
            //cmbTo.DataSource = tolamviec.Laytolamviec(cmbPhongBan.SelectedValue.ToString());
            //cmbTo.DisplayMember = "Tento";
            //cmbTo.ValueMember = "Mato";
           
            
        }

      

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            chuyen = "1";
            maphong = cmbPhongBan.SelectedValue.ToString();
            machucvu = cmbChucVu.SelectedValue.ToString();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            chuyen ="0";
            this.Close();

        }

        
    }
}