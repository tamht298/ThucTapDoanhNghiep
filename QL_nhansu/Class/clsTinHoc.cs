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
    class clsTinHoc
    {
        clsData kn = new clsData();
        
        public void Them_TinHoc(string MaTH, string TenTH)
        {
            kn.StoreNone("proc_Tinhoc_Insert", MaTH, TenTH);
        }
        public void Sua_TinHoc(string MaTH, string TenTH)
        {
            kn.StoreNone("proc_Tinhoc_Update", MaTH, TenTH);
        }
        public void Xoa_TinHoc(string MaTH)
        {
            kn.StoreNone("proc_Tinhoc_Delete", MaTH);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblTinhoc", dgv);
        }
    }
}
