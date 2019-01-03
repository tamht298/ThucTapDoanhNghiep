using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.Controls;

using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_nhansu.Class
{
    class clsKyLuat
    {
        clsData kn = new clsData();

        public void ThemKyLuat(string Makl,string Manv,string LyDo, string HinhThuc, DateTime Ngaykl)
        {
            kn.StoreNone("proc_Kyluat_Insert", Makl,Manv,LyDo,HinhThuc,Ngaykl);
        }
        public void SuaKyLuat(string Makl,string Manv ,string LyDo, string HinhThuc,DateTime Ngaykl)
        {
            kn.StoreNone("proc_Kyluat_Update", Makl,Manv,LyDo,HinhThuc,Ngaykl);
        }
        public void XoaKyLuat(string Makl, string Manv)
        {
            kn.StoreNone("proc_Kyluat_Delete", Makl, Manv);
        }
        //--------------------------
        public void LoadDataGridView_PhongBan(DataGridViewX dgvPhongBan)
        {
            kn.LoadDGV("SELECT Maphongban,Tenphongban FROM tblPhongban", dgvPhongBan);
        }
        public void LoadDataGidView_NhanVien(DataGridViewX dgvNhanVien, string Mapb)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,Ngayvaolam FROM tblNhanvien WHERE Maphongban='" + Mapb + "'", dgvNhanVien);
        }
        //Load dgvNhanSu theo txtTimKiem
        public void LoadDataGridView_TimKiem_NhanVien(DataGridViewX dgvNhanVien, string manv)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,Ngayvaolam,Maphongban as 'Mã phòng ban' FROM tblNhanvien WHERE MaNV='" + manv + "'", dgvNhanVien);
        }
        public void LoadDataGridView_KyLuat(DataGridViewX dgvKyLuat, string Manv)
        {
            kn.LoadDGV("SELECT * FROM tblKyluatphat WHERE MaNV='" + Manv + "'", dgvKyLuat);
        }

        public int DemDong()
        {
            kn.Open_DB();
            string sql = "SELECT * FROM tblKyluatphat";
            SqlDataAdapter da = new SqlDataAdapter(sql, kn._sqlConn1);
            DataTable t = new DataTable();
            da.Fill(t);
            return t.Rows.Count;

        }

    }
}
