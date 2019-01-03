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
    class clsTonGiao
    {
        clsData kn = new clsData();

        public void Them_TonGiao(string MaTG, string TenTG)
        {
            kn.StoreNone("proc_Tongiao_Insert", MaTG, TenTG);
        }
        public void Sua_TonGiao(string MaTG, string TenTG)
        {
            kn.StoreNone("proc_Tongiao_Update", MaTG, TenTG);
        }
        public void Xoa_TonGiao(string MaTG)
        {
            kn.StoreNone("proc_Tongiao_Delete", MaTG);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblTongiao", dgv);
        }
    }
}
