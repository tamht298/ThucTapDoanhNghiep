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
    class clsPhanQuyen
    {
        public string Quyen;
        public string LayTT(string TenDN)
        {
            SqlConnection conn = Class.clsData.OpenSqlConnection();
            string strSql = "SELECT Chophepthaotac FROM tblNguoidung WHERE Usename='" + TenDN+ "' ";
            SqlCommand cmd = new SqlCommand(strSql);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            Quyen = (string)cmd.ExecuteScalar();

            return Quyen ;
           
        }
        clsData kn = new clsData();

        public void Them_TaiKhoan_PQ(string TenDN, string Matkhau, int Quyen)
        {
            kn.StoreNone("proc_Taikhoan_Insert", TenDN, Matkhau, Quyen);
        }
        public void Sua_TaiKhoan_PQ(string TenDN, string matkhau, int Quyen)
        {
            kn.StoreNone("proc_Taikhoan_PQ_Update", TenDN, matkhau, Quyen);
        }
        public void Xoa_TaiKhoan_PQ(string TenDN)
        {
            kn.StoreNone("proc_Taikhoan_Delete", TenDN);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblNguoidung", dgv);
        }

    }
}
