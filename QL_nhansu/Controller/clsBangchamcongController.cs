using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using QL_nhansu.Class;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_nhansu.Controller
{
    public class clsBangchamcongController
    {
        clsLaybangchamcong getbangchamcong = new clsLaybangchamcong();
        clsLaybangnhanvien nv = new clsLaybangnhanvien();
        public void HienthicomboboxNhanvien(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = nv.Laynhanvien();
            cmb.DisplayMember = "TenNV";
            cmb.ValueMember = "MaNV";
            cmb.DataPropertyName = "MaNV";
        }

        public void Hienthitexboxthang(DataGridViewTextBoxColumn cmb)
        {

            cmb.DataPropertyName = "Thangchamcong";
        }
        //public void Hienthitexboxthang(DataGridViewComboBoxColumn cmb)
        //{
        //    //cmb.DataSource = getbangchamcong.LayThangtrongBangchamcong();
        //    cmb.DataPropertyName = "Thangchamcong";

        //}


        public void Hienthitextboxmachamcong(DataGridViewTextBoxColumn cmb)
        {
            cmb.DataPropertyName = "Machamcong";
        }
        public void Hienthitextboxtongngay(DataGridViewTextBoxColumn cmb)
        {
            cmb.DataPropertyName = "Tongsongay";
        }

        public void Hienthitextboxngaydilam(DataGridViewTextBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngaydilam";
        }
        public void Hienthitextboxngayvang(DataGridViewTextBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngayvang";
        }




        public void Hienthicombobox1(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay1";
        }
        public void Hienthicombobox2(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay2";
        }
        public void Hienthicombobox3(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay3";
        }
        public void Hienthicombobox4(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay4";
        }
        public void Hienthicombobox5(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay5";
        }
        public void Hienthicombobox6(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay6";
        }
        public void Hienthicombobox7(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay7";
        }

        public void Hienthicombobox8(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay8";
        }
        public void Hienthicombobox9(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay9";
        }
        public void Hienthicombobox10(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay10";
        }
        public void Hienthicombobox11(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay11";
        }
        public void Hienthicombobox12(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay12";
        }
        public void Hienthicombobox13(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay13";
        }
        public void Hienthicombobox14(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay14";
        }
        public void Hienthicombobox15(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay15";
        }
        public void Hienthicombobox16(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay16";
        }
        public void Hienthicombobox17(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay17";
        }
        public void Hienthicombobox18(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay18";
        }
        public void Hienthicombobox19(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay19";
        }
        public void Hienthicombobox20(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay20";
        }
        public void Hienthicombobox21(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay21";
        }
        public void Hienthicombobox22(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay22";
        }
        public void Hienthicombobox23(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay23";
        }
        public void Hienthicombobox24(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay24";
        }
        public void Hienthicombobox25(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay25";
        }
        public void Hienthicombobox26(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay26";
        }
        public void Hienthicombobox27(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay27";
        }
        public void Hienthicombobox28(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay28";
        }
        public void Hienthicombobox29(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay29";
        }
        public void Hienthicombobox30(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay30";
        }
        public void Hienthicombobox31(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataPropertyName = "Ngay31";
        }
        public void HienthiGridtheothangnam(DataTable dt, DataGridViewX dgv, BindingNavigator bn)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                bn.BindingSource = bs;
                dgv.DataSource = bs;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

    }
}
