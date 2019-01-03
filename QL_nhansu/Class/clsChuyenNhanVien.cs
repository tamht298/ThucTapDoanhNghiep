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
    class clsChuyenNhanVien
    {
        clsData kn = new clsData();
        //load du lieu vao combobox
        public void LoadComboBox_PhongBan(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblPhongban", "Tenphongban", "Maphongban", cb);
        }
       
        public void LoadComboBox_ChucVu(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblChucvu", "Tenchucvu", "Machucvu", cb);
        }
        //public void LoadComboBox_ToLamViec(ComboBoxEx cb, string Mapb)
        //{
        //    kn.LoadDataComboBox_Select1("SELECT  Tento FROM tblTolamviec WhERE Maphongban='" + Mapb + "'", "Tento","Mato", cb);
        //}
        // thu tuc xu ly du lieu
        public void Chuyen_NhanVien(string Manv, string Tennv,string CMND,DateTime Ngaycap, string Noicap, DateTime Ngaysinh, string Gioitinh 
          ,string Diachi,string Email, string DTrieng, string DTnha, string TTHonnhan
          , string Maphong,string Machucvu,string Matinhoc, string Mangoaingu, string Mabangcap,string Madantoc,string Matongiao)
          
        {
            kn.StoreNone("proc_ChuyenNV_Insert", Manv, Tennv, CMND, Ngaycap, Noicap, Ngaysinh, Gioitinh,Diachi, Email, DTrieng, DTnha
                , TTHonnhan,Maphong, Machucvu, Matinhoc, Mangoaingu,Mabangcap,Madantoc,Matongiao);
                
        }
        
    }
}
