using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Data.OleDb;

namespace QL_nhansu.Class
{
    class clsData
    {
        static String strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlynhansu;Integrated Security=True";
        static SqlConnection _sqlConn = new SqlConnection(strCon);
        public SqlConnection _sqlConn1;
        public SqlDataAdapter _sqlda;
        public DataSet _dataset = new DataSet();
        public DataTable t = new DataTable();
        public SqlCommand _sqlcommand;
        public static bool Openconnection()
        {
            //_sqlConn.ConnectionString = strCon;
            //if (_sqlConn.State != ConnectionState.Open)
            //{
            //    try
            //    {
            //        _sqlConn.Open();
            //        System.Windows.Forms.MessageBox.Show(" ket noi duoc roi");
            //        return true;

            //    }
            //    catch //(Exception e)
            //    {
            //        System.Windows.Forms.MessageBox.Show(" khong ket noi duoc");
            //        return false;
            //    }

            //}
            //else
            //    return true;
            //=======================================
            try
            {
                _sqlConn.Open();
                if (_sqlConn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool Closeconnection()
        {
            try
            {
                _sqlConn.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }


        public static SqlConnection OpenSqlConnection()
        {
            SqlConnection cn = null;
            string strConnect1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlynhansu;Integrated Security=True";
            try
            {

                cn = new SqlConnection(strConnect1);
                cn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (cn.State == ConnectionState.Open)
                return cn;
            else
                return null;
        }

        //Xay dung phuong thuc LoadDataGridView
        public void LoadDataGridView(string tenbang, DataGridView dgv)
        {
            dgv.DataSource = _dataset.Tables[tenbang];
            dgv.Refresh();
        }

        //Xay phuong phuong thuc Load DataGridView gom 2 tham so
        public void LoadDGV(string causelect, DataGridViewX dgv)
        {
            DataTable tb = new DataTable();
            _sqlda = new SqlDataAdapter(causelect, _sqlConn);
            _sqlda.Fill(tb);
            dgv.DataSource = tb;
            dgv.Refresh();
        }
        //Xay dung phuong thuc StoreNone dung de goi cac thu tuc Update, Insert, Delete
        public void StoreNone(string ten_store, params object[] giatri)
        {
            Openconnection();
            try
            {
                _sqlcommand = new SqlCommand(ten_store, _sqlConn);
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(_sqlcommand);
                for (int i = 1; i < _sqlcommand.Parameters.Count; i++)
                {
                    _sqlcommand.Parameters[i].Value = giatri[i - 1];
                }
                _sqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //load du lieu vao combobox
        public void LoadDataComboBox(string tb, string truong_ht, ComboBox cb)
        {
            _sqlda = new SqlDataAdapter("SELECT * FROM " + tb, _sqlConn);
            _sqlda.Fill(_dataset, tb);
            cb.DataSource = _dataset.Tables[tb];
            cb.DisplayMember = truong_ht;
            cb.Refresh();
        }
        public void LoadCB(string causelect, string truong_ht, ComboBox cb)
        {
            _sqlda = new SqlDataAdapter(causelect, _sqlConn);
            _sqlda.Fill(t);
            cb.DataSource = t;
            cb.DisplayMember = truong_ht;
        }
        public void LoadDataComboBox_Value(string tb, string truong_ht, string truong_ma, ComboBox cb)
        {
            _sqlda = new SqlDataAdapter("SELECT * FROM " + tb, _sqlConn);
            _sqlda.Fill(_dataset, tb);
            cb.DataSource = _dataset.Tables[tb];
            cb.DisplayMember = truong_ht;
            cb.ValueMember = truong_ma;
            cb.Refresh();
        }
        public void LoadDataComboBox_Select(string causelect, string truong_ht, string truong_ma,ComboBox cb)
        {
            DataTable tb = new DataTable();
            _sqlda = new SqlDataAdapter(causelect, _sqlConn);
            _sqlda.Fill(tb);
            cb.DataSource = tb;
            cb.DisplayMember = truong_ht;
            cb.ValueMember = truong_ma;
            cb.Refresh();
        }
        public void LoadDataComboBox_Select1(string causelect, string truong_ht, string truong_ma,ComboBoxEx cb)
        {
            DataTable tb = new DataTable();
            _sqlda = new SqlDataAdapter(causelect, _sqlConn);
            _sqlda.Fill(tb);
            cb.DataSource = tb;
            cb.DisplayMember = truong_ht;
            cb.ValueMember = truong_ma;
            cb.Refresh();
        }

        public void Open_DB()
        {
            try
            {
                this._sqlConn1 = new SqlConnection(strCon);
                this._sqlcommand = new SqlCommand();
                this._sqlcommand.Connection = this._sqlConn1;
            }
            catch
            {
                MessageBox.Show("Không thể mở được cở sở dữ liệu...", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Exe_sp_X(string sp_X)
        {
            try
            {
                this._sqlcommand.CommandText = sp_X;
                this._sqlcommand.CommandType = CommandType.StoredProcedure;
                this._sqlda = new SqlDataAdapter(this._sqlcommand);
                this._dataset = new DataSet();
                this._sqlda.Fill(this._dataset);
                this._sqlda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
