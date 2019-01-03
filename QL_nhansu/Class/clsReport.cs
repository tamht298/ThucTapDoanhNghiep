using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;


namespace QL_nhansu.Class
{
    class clsReport
    {
       clsData kn = new clsData();
        public void Load_BC_Chucvu(CrystalReportViewer cryView, ReportDocument rp)
        {
            kn.Open_DB();
            kn.Exe_sp_X("proc_ChucVu_BC");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
        public void Load_BC_Khenthuong(CrystalReportViewer cryView, ReportDocument rp)
        {
            kn.Open_DB();
            kn.Exe_sp_X("proc_Khenthuong_BC");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
        public void Load_BC_Kyluat(CrystalReportViewer cryView, ReportDocument rp)
        {
            kn.Open_DB();
            kn.Exe_sp_X("proc_Kyluat_BC");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;

        }
        public void Load_BC_Nghiviec(CrystalReportViewer cryView, ReportDocument rp)
        {
            kn.Open_DB();
            kn.Exe_sp_X("proc_Nghiviec_BC");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
        public void Load_BC_Phongban(CrystalReportViewer cryView, ReportDocument rp,string Phongban)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@Phongban", SqlDbType.VarChar, 10).Value = Phongban;
            kn.Exe_sp_X("proc_BC_Phongban");
            if (kn._dataset.Tables.Count > 0)
            {
                rp.SetDataSource(kn._dataset.Tables[0]);
                cryView.ReportSource = rp;
            }
        }
        //========= báo cáo danh sách nhân sự tìm  kiếm theo chức vụ ==================
        public void loaddg_THEO_CHUCVU(CrystalReportViewer cryView, ReportDocument rp, string Chucvu)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@Machucvu", SqlDbType.VarChar, 4).Value = Chucvu;
            kn.Exe_sp_X("Proc_BC_Chucvu");//IN RA REPORT TIM KIEM THEO CHUC VU
            if (kn._dataset.Tables.Count > 0)
            {
                rp.SetDataSource(kn._dataset.Tables[0]);
                cryView.ReportSource = rp;
            }
        }

        //========= báo cáo danh sách nhân sự tìm  kiếm theo độ tuổi ==================
        public void loaddg_THEO_DOTUOI(CrystalReportViewer cryView, ReportDocument rp, int tu, int toi)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@Tunam", SqlDbType.Int).Value =tu;
            kn._sqlcommand.Parameters.Add("@Toinam", SqlDbType.Int).Value = toi;
            kn.Exe_sp_X("Proc_BC_Dotuoi");//IN RA REPORT TIM KIEM THEO CHUC VU
            if (kn._dataset.Tables.Count > 0)
            {
                rp.SetDataSource(kn._dataset.Tables[0]);
                cryView.ReportSource = rp;
            }
        }
        //========= Hàm Load Chức vụ lên ComBo ==================
        public void LoadComboBox_BCNS_Chucvu(ComboBox cbDonVi)
        {
            kn.LoadDataComboBox_Select("SELECT * FROM tblChucvu", "Tenchucvu", "Machucvu", cbDonVi);
        }
        public void loaddg_Chamcongthangnam(CrystalReportViewer cryView, ReportDocument rp,int thang,int nam)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
            kn._sqlcommand.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            kn.Exe_sp_X("select_BC_Chamcongthangnam");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
        public void LoadComboBox_phongban(ComboBox cbDonVi)
        {
            kn.LoadDataComboBox_Select("SELECT * FROM tblPhongban", "Tenphongban", "Maphongban", cbDonVi);
        }
        public void loaddg_Chamcongphongban(CrystalReportViewer cryView, ReportDocument rp, string phongban)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@maphong", SqlDbType.VarChar, 4).Value = phongban;
            kn.Exe_sp_X("Select_BC_Chamcongtheophong");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
        public void loaddg_Chiluongphongban(CrystalReportViewer cryView, ReportDocument rp, string phongban)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@maphong", SqlDbType.VarChar, 4).Value = phongban;
            kn.Exe_sp_X("Select_BC_Chiluongtheophong");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
        public void loaddg_Chiluongthangnam(CrystalReportViewer cryView, ReportDocument rp, int thang, int nam)
        {
            kn.Open_DB();
            kn._sqlcommand.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
            kn._sqlcommand.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            kn.Exe_sp_X("Select_BC_Chiluongtheothang");
            rp.SetDataSource(kn._dataset.Tables[0]);
            cryView.ReportSource = rp;
        }
    }
}
