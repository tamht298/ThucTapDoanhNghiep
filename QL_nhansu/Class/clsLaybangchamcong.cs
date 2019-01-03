using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Threading;

namespace QL_nhansu.Class
{
    public class clsLaybangchamcong
    {
        clsKetnoi kn = new clsKetnoi();
        public DataTable Laybangchamcongrong()
        {
            SqlCommand com = new SqlCommand("select * from tblBangchamcong where Machamcong=''");
            kn.Load(com);
            return kn;
        }
        public DataTable Laybangchamcong()
        {
            SqlCommand com = new SqlCommand("select * from tblBangchamcong");
            kn.Load(com);
            return kn;
        }
        public DataTable Laybangchamcongtheonamthang(int Thang, int Nam)
        {
            SqlCommand com = new SqlCommand("select * from tblBangchamcong where month(Thangchamcong)='" + Thang + "'and year(Thangchamcong)='" + Nam + "'");
            kn.Load(com);
            return kn;
        }
        public DataTable Laybangchamcongtheonamcuanhanvien(string MaNV, int nam)
        {
            SqlCommand com = new SqlCommand("select * from tblBangchamcong where MaNV='" + MaNV + "'and year(Thangchamcong)='" + nam + "'");
            kn.Load(com);
            return kn;
        }
        public void Themmoi(string machamcong, string thangchamcong, string maNV, string ngay1, string ngay2, string ngay3, string ngay4, string ngay5, string ngay6, string ngay7, string ngay8, string ngay9, string ngay10, string ngay11, string ngay12, string ngay13, string ngay14, string ngay15, string ngay16, string ngay17, string ngay18, string ngay19, string ngay20, string ngay21, string ngay22, string ngay23, string ngay24, string ngay25, string ngay26, string ngay27, string ngay28, string ngay29, string ngay30, string ngay31, int tongsongay, int ngaydilam, int ngayvang)
        {
            string query = "INSERT INTO tblBangchamcong(Machamcong,Thangchamcong,MaNV,Ngay1,Ngay2,Ngay3,Ngay4,Ngay5,Ngay6,Ngay7,Ngay8,Ngay9,Ngay10,Ngay11,Ngay12,Ngay13,Ngay14,Ngay15,Ngay16,Ngay17,Ngay18,Ngay19,Ngay20,Ngay21,Ngay22,Ngay23,Ngay24,Ngay25,Ngay26,Ngay27,Ngay28,Ngay29,Ngay30,Ngay31,Tongsongay,Ngaydilam,Ngayvang) values ('" + machamcong + "','" + thangchamcong + "','" + maNV + "','" + ngay1 + "','" + ngay2 + "','" + ngay3 + "','" + ngay4 + "','" + ngay5 + "','" + ngay6 + "','" + ngay7 + "','" + ngay8 + "','" + ngay9 + "','" + ngay10 + "','" + ngay11 + "','" + ngay12 + "','" + ngay13 + "','" + ngay14 + "','" + ngay15 + "','" + ngay16 + "','" + ngay17 + "','" + ngay18 + "','" + ngay19 + "','" + ngay20 + "','" + ngay21 + "','" + ngay22 + "','" + ngay23 + "','" + ngay24 + "','" + ngay25 + "','" + ngay26 + "','" + ngay27 + "','" + ngay28 + "','" + ngay29 + "','" + ngay30 + "','" + ngay31 + "','" + tongsongay + "','" + ngaydilam + "','" + ngayvang + "')";
            SqlCommand com = new SqlCommand(query);
            kn.Load(com);
        }
        public void Capnhat(string machamcong, string ngay1, string ngay2, string ngay3, string ngay4, string ngay5, string ngay6, string ngay7, string ngay8, string ngay9, string ngay10, string ngay11, string ngay12, string ngay13, string ngay14, string ngay15, string ngay16, string ngay17, string ngay18, string ngay19, string ngay20, string ngay21, string ngay22, string ngay23, string ngay24, string ngay25, string ngay26, string ngay27, string ngay28, string ngay29, string ngay30, string ngay31, int tongngay, int ngaydilam, int ngayvang)
        {
            string query = "UPDATE tblBangchamcong SET Ngay1='" + ngay1 + "',Ngay2='" + ngay2 + "',Ngay3='" + ngay3 + "',Ngay4='" + ngay4 + "',Ngay5='" + ngay5 + "',Ngay6='" + ngay6 + "',Ngay7='" + ngay7 + "',Ngay8='" + ngay8 + "',Ngay9='" + ngay9 + "',Ngay10='" + ngay10 + "',Ngay11='" + ngay11 + "',Ngay12='" + ngay12 + "',Ngay13='" + ngay13 + "',Ngay14='" + ngay14 + "',Ngay15='" + ngay15 + "',Ngay16='" + ngay16 + "',Ngay17='" + ngay17 + "',Ngay18='" + ngay18 + "',Ngay19='" + ngay19 + "',Ngay20='" + ngay20 + "',Ngay21='" + ngay21 + "',Ngay22='" + ngay22 + "',Ngay23='" + ngay23 + "',Ngay24='" + ngay24 + "',Ngay25='" + ngay25 + "',Ngay26='" + ngay26 + "',Ngay27='" + ngay27 + "',Ngay28='" + ngay28 + "',Ngay29='" + ngay29 + "',Ngay30='" + ngay30 + "',Ngay31='" + ngay31 + "',Tongsongay='" + tongngay + "',Ngaydilam='" + ngaydilam + "',Ngayvang='" + ngayvang + "' where Machamcong='" + machamcong + "'";
            SqlCommand com = new SqlCommand(query);
            kn.Load(com);

        }
        public void Xoa(string machamcong)
        {
            SqlCommand com = new SqlCommand("delete from tblBangchamcong where Machamcong='" + machamcong + "'");
            kn.Load(com);

        }
        public void Themphuong(string ma)
        {
            string query = "INSERT INTO tblphuong(Ma) values ('" + ma + "')";
            SqlCommand com = new SqlCommand(query);
            kn.Load(com);
        }

        public DataTable laybangphuong()
        {
            SqlCommand com = new SqlCommand("select * from tblphuong");
            kn.Load(com);
            return kn;
        }

        //public DataTable LayThangtrongBangchamcong()
        //{
        //    SqlCommand com = new SqlCommand("select month(Thangchamcong) from tblBangchamcong");
        //    kn.Load(com);
        //    return kn;
        //}

        public int Matutang(DataGridViewX dgv)
        {
            if (dgv.RowCount == 0)
            {
                return 1;
            }
            else
            {
                string Makt = dgv[0, dgv.RowCount - 1].Value.ToString();
                int s = Convert.ToInt32(Makt.Substring(2).Trim());
                return s + 1;
            }
        }
    }
}
