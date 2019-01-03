using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QL_nhansu.Class
{
    public class clsLaybangnhanvien
    {
        clsKetnoi kn = new clsKetnoi();
        public DataTable Laynhanvientheophongban(string maphong)
        {
            SqlCommand com = new SqlCommand("select * from tblNhanvien where Maphongban='" + maphong + "'");
            kn.Load(com);
            return kn;
        }
        public DataTable Laynhanvientheophongbandanglam(string phongban)
        {
            SqlCommand com = new SqlCommand("select * from tblNhanvien where Maphongban='" + phongban + "'and Tinhtranglamviec=N'Đang làm việc'");
            kn.Load(com);
            return kn;
        }
        public DataTable LayMaNVtheophongdanglam(string phongban)
        {
            SqlCommand com = new SqlCommand("select MaNV from tblNhanvien where Maphongban='" + phongban + "'and Tinhtranglamviec=N'Đang làm việc'");
            kn.Load(com);
            return kn;
        }
        public DataTable Laynhanvienthuviectheophong(string phongban)
        {
            SqlCommand com = new SqlCommand("select * from tblNhanvien where Maphongban='" + phongban + "'and Tinhtranglamviec=N'Thử việc'");
            kn.Load(com);
            return kn;
        }
        //public DataTable Laynhanvienthuviectheophong(string phongban)
        //{
        //    SqlCommand com= new SqlCommand("select * from tblNhanvien where Maphongban='" + phongban + "'and Tinhtranglamviec=N'Thử việc'");
        //    kn.Load(com);
        //    return kn;
        //}
        public DataTable Laynhanvien()
        {
            //kn = new clsKetnoi();
            SqlCommand com = new SqlCommand("select * from tblNhanvien");
            kn.Load(com);
            return kn;

        }
        public DataTable Laynhanviendanglam()
        {
            SqlCommand com= new SqlCommand("select * from tblNhanvien where Tinhtranglamviec=N'Đang làm việc'");
            kn.Load(com);
            return kn;

        }
        public DataTable Laynhanvienthuviec()
        {
            SqlCommand com = new SqlCommand("select * from tblNhanvien where Tinhtranglamviec=N'Thử việc'");
            kn.Load(com);
            return kn;

        }
    }
}
