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
    class clsNgoaiNgu
    {
        clsData kn = new clsData();

        public void Them_NgoaiNgu(string MaNN, string TenNN)
        {
            kn.StoreNone("proc_Ngoaingu_Insert", MaNN, TenNN);
        }
        public void Sua_NgoaiNgu(string MaNN, string TenNN)
        {
            kn.StoreNone("proc_Ngoaingu_Update", MaNN, TenNN);
        }
        public void Xoa_NgoaiNgu(string MaNN)
        {
            kn.StoreNone("proc_Ngoaingu_Delete", MaNN);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblNgoaingu", dgv);
        }
    }
}
