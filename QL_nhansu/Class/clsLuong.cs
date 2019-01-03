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
    class clsLuong
    {
        clsData kn = new clsData();
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT MaLuong,MaNV,Thang,Ngaylamviec,Phucap,BHXH,BHYT,Luongcoban,TongLuong,ThucLinh,Heso,GhiChu FROM tblLLuong", dgv);
        }
        //public void LoadDataGridView_TimKiem(DataGridViewX dgv, string MaLuong)
        //{
        //    kn.LoadDGV("SELECT MaLuong,MaNV,Thang,Ngaylamviec,Phucap,BHXH,BHYT,Luongcoban,TongLuong,ThucLinh,Heso,GhiChu FROM tblLuong WHERE MaLuong='" + MaLuong + "'", dgv);
        //}
        public void Xoa_Luong(string MaLuong)
        {
            kn.StoreNone("proc_LLuong_Delete", MaLuong);
        }
        public void Them_Luong(string MaLuong, string MaNV, float Heso, float Luongcoban, DateTime Thang, int Ngaylamviec, float Phucap
           , float BHXH, float BHYT, float TongLuong, float ThucLinh, string GhiChu)
        {
            kn.StoreNone("proc_LLuong_Insert", MaLuong, MaNV, Heso, Luongcoban, Thang, Ngaylamviec, Phucap, BHXH, BHYT, TongLuong, ThucLinh, GhiChu);
        }

        public void Sua_Luong(string MaLuong, string MaNV, float Heso, float Luongcoban, DateTime Thang, int Ngaylamviec, float Phucap
           , float BHXH, float BHYT, float TongLuong, float ThucLinh, string GhiChu)
        {
            kn.StoreNone("proc_LLuong_Update", MaLuong, MaNV, Heso, Luongcoban, Thang, Ngaylamviec, Phucap, BHXH, BHYT, TongLuong, ThucLinh, GhiChu);
        }

    }
}
