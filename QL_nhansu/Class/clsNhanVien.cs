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
    class clsNhanVien
    {
        clsData kn = new clsData();
        

        //load dl vao gridview
        public void LoadDataGridView_TTChung(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT MaNV,TenNV,CMND,Ngaycap,Tinhthanh,Ngaysinh,Gioitinh,Nguyenquan,Dctamtru,Email,SDTrieng,SDTnha,Tinhtranghonnhan,Tinhtranglamviec FROM tblNhanvien", dgv);
        }
        public void LoadDataGridView_TTChung_TimKiem(DataGridViewX dgv, string manv )
        {
            kn.LoadDGV("SELECT MaNV,TenNV,CMND,NgayCap,Tinhthanh,Ngaysinh,Gioitinh,Nguyenquan,Dctamtru,SDTrieng,SDTnha,Tinhtranghonnhan,Tinhtranglamviec FROM tblNhanvien WHERE MaNV='" + manv + "'", dgv);
        }
        public void LoadDataGridView_TTLienQuan(DataGridViewX dgv,string Manv)
        {
            kn.LoadDGV("SELECT MaNV,Maphongban,Machucvu,Ngayvaolam,Thamnien,Heso,Matinhoc,Mangoaingu,Mabangcap,SoBHXH,SoBHYT,Cannang,Cao,Nhommau,Tinhtrangsuckhoe,TaikhoanNH,Madantoc,Matongiao FROM tblNhanvien WHERE MaNV='" + Manv + "'", dgv);
        }
       

        //load dl vao combobox
        public void LoadComboBox_GioiTinh(ComboBoxEx cb)
        {
            kn.LoadCB("SELECT DISTINCT Gioitinh FROM tblNhanvien", "Gioitinh", cb);
        }
        public void LoadComboBox_HonNhan(ComboBoxEx cb)
        {
            kn.LoadCB("SELECT Tinhtranghonnhan FROM tblNhanvien", "Tinhtranghonnhan", cb);
        }
        public void LoadComboBox_LamViec(ComboBoxEx cb)
        {
            kn.LoadCB("SELECT Tinhtranglamviec FROM tblNhanvien", "Tinhtranglamviec", cb);
        }
        public void LoadComboBox_NhomMau(ComboBoxEx cb)
        {
            kn.LoadCB("SELECT Nhommau FROM tblNhanvien", "Nhommau", cb);
        }
        public void LoadComboBox_PhongBan(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblPhongban", "Tenphongban", "Maphongban", cb);
        }
        public void LoadComboBox_ChucVu(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblChucvu", "Tenchucvu", "Machucvu", cb);
        }
        public void LoadComboBox_TinHoc(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblTinhoc", "Tentinhoc", "Matinhoc", cb);
        }
        public void LoadComboBox_NgoaiNgu(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblNgoaingu", "Tenngoaingu", "Mangoaingu", cb);
        }
        public void LoadComboBox_HocVi(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblBangcap", "Tenbangcap", "Mabangcap", cb);
        }
        public void LoadComboBox_DanToc(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblDantoc", "Tendantoc", "Madantoc", cb);
        }
        public void LoadComboBox_TonGiao(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblTongiao", "Tentongiao", "Matongiao", cb);
        }

        //cac thu tuc xu ly dl
        public void XoaNhanVien(string MaNV)
        {
            kn.StoreNone("proc_NhanVien_Delete", MaNV);
        }
        //Thu tuc them sua bang nhan vien
        public void ThemNhanVien(string Manv, string Tennv, string CMND, DateTime Ngaycap, string Noicap, DateTime Ngaysinh, string Gioitinh
           , string Nguyenquan, string DCTamtru, string Email,  string DTrieng, string DTnha,string TTHonnhan, string TTLamviec,string Maphong, string Machucvu
           , DateTime Ngayvao, int Thamnien, float Heso, string Tinhoc, string Ngoaingu, string Hocvi,string SoBHXH,string SoBHYT
            ,string Cannang,string Cao,string Nhommau, string TTsuckhoe, string Sotaikhoan,string Madantoc,string Matongiao)
        {
            kn.StoreNone("proc_NhanVien_Insert", Manv, Tennv, CMND, Ngaycap, Noicap, Ngaysinh, Gioitinh, Nguyenquan, DCTamtru, Email, DTrieng, DTnha
                , TTHonnhan, TTLamviec, Maphong, Machucvu, Ngayvao, Thamnien, Heso, Tinhoc, Ngoaingu, Hocvi, SoBHXH, SoBHYT, Cannang, Cao, Nhommau, TTsuckhoe,Sotaikhoan,Madantoc,Matongiao);
        }

        public void SuaNhanVien(string Manv, string Tennv, string CMND, DateTime Ngaycap, string Noicap, DateTime Ngaysinh, string Gioitinh
           , string Nguyenquan, string DCTamtru, string Email, string DTrieng, string DTnha, string TTHonnhan, string TTLamviec
           ,   string Maphong, string Machucvu, DateTime Ngayvao, int Thamnien, float Heso ,string Tinhoc,string Ngoaingu
            ,  string Hocvi,  string SoBHXH, string SoBHYT, string Cannang, string Cao, string Nhommau, string TTsuckhoe,string Sotaikhoan,string Madantoc,string Matongiao)
        {
            kn.StoreNone("proc_NhanVien_Update", Manv, Tennv,CMND, Ngaycap, Noicap, Ngaysinh, Gioitinh, Nguyenquan, DCTamtru, Email,  DTrieng, DTnha
            , TTHonnhan, TTLamviec, Maphong,Machucvu, Ngayvao, Thamnien, Heso, Tinhoc, Ngoaingu, Hocvi, SoBHXH, SoBHYT, Cannang, Cao, Nhommau, TTsuckhoe, Sotaikhoan,Madantoc,Matongiao);
        }
        
    }
}
