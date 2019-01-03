using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QL_nhansu.Class
{
    public class clsKetnoi : DataTable
    {
        public SqlCommand _SqlCommand;
        public SqlConnection _SqlConn;
        public string _sconnectDB;
        public SqlDataAdapter _sqlda;
        public DataSet _dataset;
        public DataSet _ds;


        static String strCon = @"Data Source=DESKTOP-TQ93RVT\SQLEXPRESS;Initial Catalog=Quanlynhansu;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(strCon);
        SqlDataAdapter da;
        public static bool Openconnection()
        {
            connection.ConnectionString = strCon;
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    System.Windows.Forms.MessageBox.Show(" ket noi duoc roi");
                    return true;

                }
                catch //(Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(" khong ket noi duoc");
                    return false;
                }

            }
            else
                return true;
        }
        public static bool Closeconnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
        public DataTable Load(SqlCommand cmd)
        {
            cmd.Connection = connection;
            da = new SqlDataAdapter(cmd);
            this.Clear();
            this.da.Fill(this);
            return this;

        }
        public void Update()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.da);
            this.da.Update(this);
        }
    }
}
