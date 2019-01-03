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
    class clsTimKiem
    {
        clsData kn = new clsData();

        //load du lieu vao gridview de tim kiem nhan vien
        public void LoadDataGridView_TK(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblNhanvien", dgv);
        }
        public void LoadDataGridView_TK_MaNV(DataGridViewX dgv,string Manv)
        {
            kn.LoadDGV("SELECT * FROM tblNhanvien WHERE MaNV='" + Manv + "'", dgv);
        }
        public void LoadDataGridView_TK_HoTen(DataGridViewX dgv, string Tennv)
        {
            kn.LoadDGV("SELECT * FROM tblNhanvien WHERE TenNV like N'%" + Tennv + "'", dgv);
        }
        public void LoadDataGridView_TK_CMND(DataGridViewX dgv, string CMND)
        {
            kn.LoadDGV("SELECT * FROM tblNhanvien WHERE CMND='" + CMND + "'", dgv);
        }

        //Tim kiem du lieu theo cac tieu chi
        //----------Theo phong ban------------
        public void LoadComboBox_PhongBan(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblPhongban", "Tenphongban", "Maphongban", cb);
        }
        public void LoadDataGridView_TK_TheoPhongBan(DataGridViewX dgv, string Mapb)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,Ngaysinh,Gioitinh,CMND,Ngaycap,Tinhthanh,Nguyenquan,Dctamtru,SDTrieng,SDTnha,Tinhtranghonnhan,Maphongban,Mabangcap,Machucvu,Ngayvaolam,Thamnien,Heso,Tinhtranglamviec,Tinhtrangsuckhoe FROM tblNhanvien WHERE Maphongban='" + Mapb + "'", dgv);
        }
        //----------theo chuc vu-------------
        public void LoadComboBox_ChucVu(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblChucvu", "Tenchucvu", "Machucvu", cb);
        }
        public void LoadDataGridView_TK_TheoChucVu(DataGridViewX dgv, string Macv)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,Ngaysinh,Gioitinh,CMND,Ngaycap,Tinhthanh,Nguyenquan,Dctamtru,SDTrieng,SDTnha,Tinhtranghonnhan,Maphongban,Mabangcap,Machucvu,Ngayvaolam,Thamnien,Heso,Tinhtranglamviec,Tinhtrangsuckhoe FROM tblNhanvien WHERE Machucvu='" + Macv + "'", dgv);
        }
        //-----------Theo trinh do-----------
        public void LoadComboBox_TrinhDo(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblBangcap", "Tenbangcap", "Mabangcap", cb);
        }
        public void LoadDataGridView_TK_TheoTrinhDo(DataGridViewX dgv, string Mabc)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,Ngaysinh,Gioitinh,CMND,Ngaycap,Tinhthanh,Nguyenquan,Dctamtru,SDTrieng,SDTnha,Tinhtranghonnhan,Maphongban,Mabangcap,Machucvu,Ngayvaolam,Thamnien,Heso,Tinhtranglamviec,Tinhtrangsuckhoe FROM tblNhanvien WHERE Mabangcap='" + Mabc + "'", dgv);
        }
        //--------------Theo tham nien-------------
        public void LoadComboBox_ThamNien(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Select("SELECT DISTINCT Thamnien FROM tblNhanvien", "Thamnien", "Thamnien", cb);
        }
        public void LoadDataGridView_TK_TheoThamNien(DataGridViewX dgv, string Thamnien)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,Ngaysinh,Gioitinh,CMND,Ngaycap,Tinhthanh,Nguyenquan,Dctamtru,SDTrieng,SDTnha,Tinhtranghonnhan,Maphongban,Mabangcap,Machucvu,Ngayvaolam,Thamnien,Heso,Tinhtranglamviec,Tinhtrangsuckhoe FROM tblNhanvien WHERE Thamnien='" + Thamnien + "'", dgv);
        }
    }
}
