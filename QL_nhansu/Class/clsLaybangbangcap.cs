using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QL_nhansu.Class
{
    public class clsLaybangbangcap
    {
        clsKetnoi kn = new clsKetnoi();

        public DataTable LaythongtinBangcap()
        {
            SqlCommand com = new SqlCommand("select * from tblBangcap");
            DataTable dt = kn.Load(com);
            return dt;
        }
    }
}
