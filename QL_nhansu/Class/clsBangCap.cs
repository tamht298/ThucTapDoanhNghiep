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
    class clsBangCap
    {
        clsData kn = new clsData();

        public void Them_BangCap(string MaBC, string TenBC)
        {
            kn.StoreNone("proc_Bangcap_Insert", MaBC, TenBC);
        }
        public void Sua_BangCap(string MaBC, string TenBC)
        {
            kn.StoreNone("proc_Bangcap_Update", MaBC, TenBC);
        }
        public void Xoa_BangCap(string MaBC)
        {
            kn.StoreNone("proc_Bangcap_Delete", MaBC);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblBangcap", dgv);
        }
    }
}
