using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu
{
    public partial class frmReportNV : DevComponents.DotNetBar.Office2007Form
    {
        public frmReportNV()
        {
            InitializeComponent();
        }
        private DataTable populate(DataTable dt)
        {
            string cnstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlynhansu;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnstr);
            SqlDataAdapter da = new SqlDataAdapter("select MaNV, TenNV, Email, Maphongban from tblNhanvien", cn);
            da.Fill(dt);
            return dt;
        }
        private void frmReportNV_Load(object sender, EventArgs e)
        {

            DataTable dtt = new DataTable();
            dtt = populate(dtt);
            rpvDSNV.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("RPNV",dtt);
            rpvDSNV.LocalReport.DataSources.Add(rpts);
            rpvDSNV.RefreshReport();
        }
    }
}
