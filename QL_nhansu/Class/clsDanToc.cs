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
    class clsDanToc
    {
        clsData kn = new clsData();

        public void Them_DanToc(string MaDT, string TenDT)
        {
            kn.StoreNone("proc_Dantoc_Insert", MaDT, TenDT);
        }
        public void Sua_DanToc(string MaDT, string TenDT)
        {
            kn.StoreNone("proc_Dantoc_Update", MaDT, TenDT);
        }
        public void Xoa_DanToc(string MaDT)
        {
            kn.StoreNone("proc_Dantoc_Delete", MaDT);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblDantoc", dgv);
        }
    }
}
