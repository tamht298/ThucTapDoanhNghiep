using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QL_nhansu.Class
{
    public class clsLaybangchucvu
    {
        clsKetnoi kn = new clsKetnoi();
        public DataTable Laychucvu()
        {
            SqlCommand com = new SqlCommand("select * from tblChucvu");
            kn.Load(com);
            return kn;
        }
    }
}
