using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QL_nhansu.Class
{
    public class clsLayphongban
    {
        clsKetnoi kn = new clsKetnoi();
        public DataTable Layphongban()
        {
            SqlCommand com = new SqlCommand("select * from tblPhongban");
            kn.Load(com);
            return kn;
        }
        public DataTable Laytolamviec(string maphongban)
        {
            SqlCommand com = new SqlCommand("select * tblTolamviec where Maphongban='" + maphongban + "' ");
            kn.Load(com);
            return kn;
        }
    }
}
