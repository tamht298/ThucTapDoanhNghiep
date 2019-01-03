using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

using System.Globalization;


namespace QL_nhansu.Class
{
    class clsChucVu
    {
        clsData kn = new clsData();
        //public clsChucVu()
        //{
        //    kn = new clsData(@".\SQLEXPRESS", "Quanlynhansu");
        //}
        public void ThemCV(string Macv, string Tencv, decimal Heso, string Ghichu)
        {
            kn.StoreNone("proc_Chucvu_Insert", Macv, Tencv,Heso, Ghichu);
        }
        public void SuaCV(string Macv, string Tencv, decimal Heso, string Ghichu)
        {
            kn.StoreNone("proc_Chucvu_Update", Macv, Tencv ,Heso,Ghichu);
        }
        public void XoaCV(string Macv)
        {
            kn.StoreNone("proc_Chucvu_Delete", Macv);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Machucvu,Tenchucvu,Hesochucvu,Ghichu FROM tblChucvu", dgv);
        }
        
    }
}
