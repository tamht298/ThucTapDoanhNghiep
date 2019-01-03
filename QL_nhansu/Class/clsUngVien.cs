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
    class clsUngVien
    {
        clsData kn = new clsData();
        //load du lieu vao gridview
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Maungvien,Tenungvien,CMND,Ngaycap,Tinhthanh,Ngaysinh,Gioitinh,Diachi,Email,SDTrieng,SDTnha,Tinhtranghonnhan,Mabangcap,Mangoaingu,Matinhoc,Namkinhnghiem,Ngaynophoso,Trangthai,Madotphongvan,Madantoc,Matongiao FROM tblUngvien", dgv);
        }
        public void LoadDataGridView_TimKiem(DataGridViewX dgv,string Mauv)
        {
            kn.LoadDGV("SELECT Maungvien,Tenungvien,CMND,Ngaycap,Tinhthanh,Ngaysinh,Gioitinh,Diachi,Email,SDTrieng,SDTnha,Tinhtranghonnhan,Mabangcap,Mangoaingu,Matinhoc,Namkinhnghiem,Ngaynophoso,Trangthai,Madotphongvan,Madantoc,Matongiao FROM tblUngvien WHERE Maungvien='" + Mauv + "'", dgv);
        }
        public void LoadDataGridView_NhanVien(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT MaNV FROM tblNhanvien", dgv);
        }
        //load du lileu vao combobox
        public void LoadComboBox_GioiTinh(ComboBoxEx cb)
        {
            kn.LoadCB("SELECT Gioitinh FROM tblUngvien", "Gioitinh", cb);
        }
        public void LoadComboBox_HonNhan(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Select("SELECT DISTINCT Tinhtranghonnhan FROM tblUngVien", "Tinhtranghonnhan", "Tinhtranghonnhan", cb);
        }
        public void LoadComboBox_Trangthai(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Select("SELECT DISTINCT Trangthai FROM tblUngVien", "Trangthai", "Trangthai", cb);
        }
        public void LoadComboBox_DotPV(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblDotphongvan", "Tendotphongvan", "Madotphongvan", cb);
        }
        public void LoadComboBox_BangCap(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblBangcap", "Tenbangcap", "Mabangcap", cb);
        }
        public void LoadComboBox_TinHoc(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblTinhoc", "Tentinhoc", "Matinhoc", cb);
        }
        public void LoadComboBox_NgoaiNgu(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblNgoaingu", "Tenngoaingu", "Mangoaingu", cb);
        }
        public void LoadComboBox_DanToc(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblDantoc", "Tendantoc", "Madantoc", cb);
        }
        public void LoadComboBox_TonGiao(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblTongiao", "Tentongiao", "Matongiao", cb);
        }

        //cac thu tuc xu ly du lieu
        public void Xoa_UngVien(string MaUV)
        {
            kn.StoreNone("proc_UngVien_Delete", MaUV);
        }
        public void Them_UngVien(string Mauv, string Tenuv, string CMND, DateTime Ngaycap, string Noicap, DateTime Ngaysinh, string Gioitinh
           , string Diachi, string Email, string DTrieng, string DTnha, string TTHonnhan , string Bangcap, string Ngoaingu, string Tinhoc
            , int Namkinhnghiem, DateTime NgaynopHS, string Trangthai, string DotPV,string Madantoc,string Matongiao)
        {
            kn.StoreNone("proc_UngVien_Insert", Mauv, Tenuv, CMND, Ngaycap, Noicap, Ngaysinh, Gioitinh,Diachi,Email,DTrieng,DTnha
                , TTHonnhan, Bangcap,Ngoaingu, Tinhoc,  Namkinhnghiem, NgaynopHS, Trangthai,DotPV,Madantoc,Matongiao);
        }

        public void Sua_UngVien(string Mauv, string Tenuv, string CMND, DateTime Ngaycap, string Noicap, DateTime Ngaysinh, string Gioitinh
           , string Diachi,string Email, string DTrieng, string DTnha, string TTHonnhan
           , string Bangcap, string Ngoaingu, string Tinhoc, int Namkinhnghiem, DateTime NgaynopHS, string Trangthai, string DotPV, string Madantoc, string Matongiao)
        {
            kn.StoreNone("proc_UngVien_Update", Mauv, Tenuv, CMND, Ngaycap, Noicap, Ngaysinh, Gioitinh, Diachi, Email, DTrieng, DTnha
                , TTHonnhan, Bangcap, Ngoaingu, Tinhoc, Namkinhnghiem, NgaynopHS, Trangthai, DotPV,Madantoc, Matongiao);
        }
        public int DemDong()
        {
            kn.Open_DB();
            string sql = "SELECT * FROM tblNhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, kn._sqlConn1);
            DataTable t = new DataTable();
            da.Fill(t);
            return t.Rows.Count;

        }
       

    }
}
