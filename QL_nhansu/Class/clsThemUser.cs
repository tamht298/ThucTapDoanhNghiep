using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;


namespace QL_nhansu.Class
{
    class clsThemUser
    {
        clsData kn = new clsData();
        //public clsThemUser()
        //{
        //    kn = new clsData(".", "MW&S");
        //}
        public void LoadComboBox_User(ComboBox cbUser)
        {
            kn.LoadDataComboBox("tblNguoidung", "Usename", cbUser);
        }
        
        public void LoadDataGridView_User(DataGridViewX dgv)
        {
            kn.LoadDGV("select Usename,'******' as Pass, Email from tblNguoidung", dgv);
        }
        //thu tuc xu ly du lieu
        public void SuaTK(string Tendangnhap, string matkhau,string Email)
        {
            kn.StoreNone("proc_Taikhoan_Update", Tendangnhap, matkhau,Email );
        }
        public void SuaTK1(string Tendangnhap, string matkhau)
        {
            kn.StoreNone("proc_Taikhoan_Update", Tendangnhap, matkhau);
        }


        public void XoaTK(string Tendangnhap)
        {
            kn.StoreNone("proc_Taikhoan_Delete", Tendangnhap);
        }
        public void NhapTK(string Tendangnhap, string matkhau,string Email)
        {
            kn.StoreNone("proc_Taikhoan_Insert", Tendangnhap, matkhau,Email);
        }
    }
}
