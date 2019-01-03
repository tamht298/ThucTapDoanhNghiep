using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Data.OleDb;

namespace QL_nhansu
{
    public partial class frm_luong : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsLuong luong = new QL_nhansu.Class.clsLuong();
        SqlConnection MyConnection;
        bool Trangthai = true;

        public frm_luong()
        {
            InitializeComponent();
        }
        

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_luong_Load(object sender, EventArgs e)
        {
            MyConnection = QL_nhansu.Class.clsData.OpenSqlConnection();
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            luong.LoadDataGridView(dgvLuong);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa Lương ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                luong.Xoa_Luong(txtMaLuong.Text);
                luong.LoadDataGridView(dgvLuong);
                Xoa();

            }
        }
        public void Xoa()
        {
            txtMaLuong.Text = "";
            txtMaNV.Text = "";
            txtheso.Text = "";
            txtlcb.Text = "";
            dtithang.Text = "";
            txtsmlv.Text = "";
            txtphucapp.Text = "";
            txtbhxh.Text = "";
            txtbhyt.Text = "";
            txttongluong.Text = "";
            txtthuclinh.Text = "";
            txtghichu.Text = "";
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvLuong.CurrentRow.Index;
            txtMaLuong.Text = dgvLuong[0, hang].Value.ToString();
            txtMaNV.Text = dgvLuong[1, hang].Value.ToString();
            dtithangluong.Text = dgvLuong[2, hang].Value.ToString();
            txtheso.Text = dgvLuong[10, hang].Value.ToString();
            txtlcb.Text = dgvLuong[7, hang].Value.ToString();
            txtsnlm.Text = dgvLuong[3, hang].Value.ToString();
            txtphuCap.Text = dgvLuong[4, hang].Value.ToString();
            txtbhxh.Text = dgvLuong[5, hang].Value.ToString();
            txtbhyt.Text = dgvLuong[6, hang].Value.ToString();
            txttongluong.Text = dgvLuong[8, hang].Value.ToString();
            txtthuclinh.Text = dgvLuong[9, hang].Value.ToString();
            txtghichu.Text = dgvLuong[11, hang].Value.ToString();
        }

        private void txtphuCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Trangthai = true;
            int MaLuong = dk.MaTuTang(dgvLuong);

            if (MaLuong <= 9)
            {
                txtMaLuong.Text = "ML" + "0" + MaLuong.ToString();
            }
            else
            {
                txtMaLuong.Text = "ML" + MaLuong.ToString();
            }

            dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            txtMaLuong.Text = "";
            txtMaNV.Text = "";
            txtheso.Text = "";
            txtlcb.Text = "";
            dtithang.Text = "";
            txtsmlv.Text = "";
            txtphucapp.Text = "";
            txtbhxh.Text = "";
            txtbhyt.Text = "";
            txttongluong.Text = "";
            txtthuclinh.Text = "";
            txtghichu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai = false;
            dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLuong.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã Lương không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLuong.Focus();
            }

            else if (txtMaNV.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã nhân viên không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
            }
            else if (dtithangluong.Text.Trim() == "")
            {
                MessageBoxEx.Show("Tháng Lương không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtithangluong.Focus();
            }
            else if (txtsnlm.Text.Trim() == "")
            {
                MessageBoxEx.Show("Số Ngày Làm Việc không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsnlm.Focus();
            }
            else
            if (txtheso.Text.Trim() == "" || (Convert.ToDecimal(txtheso.Text) < 0 || Convert.ToDecimal(txtheso.Text) > 2))
            {
                MessageBoxEx.Show("Hệ số chỉ từ 0-2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtheso.Focus();
            }
            else
            {

                if (Trangthai == true)
                {
                    luong.Them_Luong(txtMaLuong.Text, txtMaNV.Text, float.Parse(txtheso.Text), float.Parse(txtlcb.Text), Convert.ToDateTime(dtithangluong.Text.ToString()), int.Parse(txtsnlm.Text), float.Parse(txtphuCap.Text)
                                           , float.Parse(txtbhxh.Text), float.Parse(txtbhyt.Text), float.Parse(txttongluong.Text), float.Parse(txtthuclinh.Text), txtghichu.Text);
                }
                else
                {
                    luong.Sua_Luong(txtMaLuong.Text, txtMaNV.Text, float.Parse(txtheso.Text), float.Parse(txtlcb.Text), Convert.ToDateTime(dtithangluong.Text.ToString()), int.Parse(txtsnlm.Text), float.Parse(txtphuCap.Text)
                                           , float.Parse(txtbhxh.Text), float.Parse(txtbhyt.Text), float.Parse(txttongluong.Text), float.Parse(txtthuclinh.Text), txtghichu.Text);
                }
                luong.LoadDataGridView(dgvLuong);
                dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                Xoa();
            }
        }

        private void btnbaohiem_Click(object sender, EventArgs e)
        {
            string a = txttongluong.Text;
            double tinhbh = double.Parse(a) * 0.08;
            txtbhxh.Text = tinhbh.ToString();
            double tinhbhyt = double.Parse(a) * 0.015;
            txtbhyt.Text = tinhbhyt.ToString();
        }

        private void btntongluong_Click(object sender, EventArgs e)
        {
            string a = txtlcb.Text;
            string b = txtsnlm.Text;
            string c = txtheso.Text;
            string d = txtphuCap.Text;
            double tinhtongluong = (((double.Parse(a) * double.Parse(c)) + double.Parse(d))/26)*double.Parse(b);
            txttongluong.Text = tinhtongluong.ToString();
        }

        private void btnthuclinh_Click(object sender, EventArgs e)
        {
            string a = txttongluong.Text;
            string b = txtbhxh.Text;
            string c = txtbhyt.Text;
            double tongbh = double.Parse(b) + double.Parse(c);
            double thuclinh = double.Parse(a) - tongbh;
            txtthuclinh.Text = thuclinh.ToString();
        }
    }
}
