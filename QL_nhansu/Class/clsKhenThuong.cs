using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QL_nhansu.Class
{
    class clsKhenThuong
    {
        clsData kn=new clsData();
        //Goi cac thu tuc trong csdl
        public void ThemKhenThuong(string Makt,string Manv,  string LyDo, string HinhThuc,DateTime Ngaykt )
        {
            kn.StoreNone("proc_Khenthuong_Insert", Makt,Manv, LyDo,HinhThuc,Ngaykt);
        }
        public void SuaKhenThuong(string Makt, string Manv,string LyDo,string HinhThuc,DateTime Ngaykt)
        {
            kn.StoreNone("proc_Khenthuong_Update", Makt,Manv, LyDo,HinhThuc,Ngaykt);
        }
        public void XoaKhenThuong(string Makt, string Manv)
        {
            kn.StoreNone("proc_Khenthuong_Delete", Makt, Manv);
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
        public void LoadDataGridView_KhenThuong(DataGridViewX dgvKhenThuong, string Manv)
        {
            kn.LoadDGV("SELECT * FROM tblKhenthuong WHERE MaNV='" + Manv + "'", dgvKhenThuong);
        }
        public void LoadDataGridView_KhenThuong_KT(DataGridViewX dgvKhenThuong)
        {
            kn.LoadDGV("SELECT * FROM tblKhenthuong" , dgvKhenThuong);
        }
        public int DemDong()
        {
            kn.Open_DB();
            string sql = "SELECT * FROM tblKhenthuong";
            SqlDataAdapter da = new SqlDataAdapter(sql, kn._sqlConn1);
            DataTable t = new DataTable();
            da.Fill(t);
            return t.Rows.Count;

        }
    }
}
