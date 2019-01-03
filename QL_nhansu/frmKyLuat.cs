using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;


namespace QL_nhansu
{
    public partial class frmKyLuat : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsKyLuat nvdn = new QL_nhansu.Class.clsKyLuat();
        //bool trangthai = true;
        string NhanVien = "";
        bool Trangthai = true;
        public frmKyLuat()
        {
            InitializeComponent();
        }

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            dtiNgayKyLuat.Text = DateTime.Now.ToShortDateString();
            nvdn.LoadDataGridView_PhongBan(dgvPhongBan);
            if (dgvPhongBan.RowCount == 0)
            {
                dgvNhanVien.Enabled = false;
            }
            else
            {
                dgvNhanVien.Enabled = true;
            }
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
        }

      
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvNhanVien.CurrentRow.Index;
            txtManv.Text = dgvNhanVien[0, hang].Value.ToString();
            nvdn.LoadDataGridView_KyLuat(dgvKyLuat, txtManv.Text.ToString());
            if (dgvKyLuat.RowCount == 0)
            {
                dgvKyLuat.Enabled = false;

            }
            else
            {
                dgvKyLuat.Enabled = true;
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvPhongBan.CurrentRow.Index;
            string Mapb = dgvPhongBan[0, hang].Value.ToString();
            nvdn.LoadDataGidView_NhanVien(dgvNhanVien, Mapb.Trim().ToString());
            if (dgvNhanVien.RowCount == 0)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                dgvNhanVien.Enabled = false;
                dgvKyLuat.Enabled = false;
                nvdn.LoadDataGridView_KyLuat(dgvKyLuat, "XXXX");
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                dgvNhanVien.Enabled = true;
                dgvKyLuat.Enabled = true;
            }
            
        }

        private void dgvKyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvKyLuat.CurrentRow.Index;
            txtMaKyLuat.Text = dgvKyLuat[0, hang].Value.ToString();
            txtManv.Text = dgvKyLuat[1, hang].Value.ToString();
            txtLyDo.Text = dgvKyLuat[2, hang].Value.ToString();
            txtHinhThuc.Text = dgvKyLuat[3, hang].Value.ToString();
            dtiNgayKyLuat.Text = dgvKyLuat[4, hang].Value.ToString();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa kỷ luật", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaKyLuat(txtMaKyLuat.Text.ToString(), txtManv.Text.ToString());
                nvdn.LoadDataGridView_KyLuat(dgvKyLuat, txtManv.Text.ToString());
                Xoa();

            }
        }
        int laymakl()
        {
            return nvdn.DemDong()+1;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Trangthai = true;
         
            if (laymakl() < 9)
            {
                txtMaKyLuat.Text = "KL" + "0" + laymakl().ToString();
            }
            else
            {
                txtMaKyLuat.Text = "KL" + laymakl().ToString();
            }
                      
                        dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                        dgvKyLuat.Enabled = true;
                        txtLyDo.Text = "";
                        txtHinhThuc.Text = "";
                        dtiNgayKyLuat.Text = "";
                   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai = false;
                        dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                        dgvKyLuat.Enabled = true;
                    
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text.Trim() == "")
                {
                    lblKetQua.Text = "Bạn phải nhập mã nhân sự cần tìm";
                }
                else
                {
                    if (txtTimKiem.Text.Contains("'") == true)
                    {
                        NhanVien = txtTimKiem.Text.Replace("'", "'" + "'");
                    }
                    else
                    {
                        NhanVien = txtTimKiem.Text;
                    }
                    nvdn.LoadDataGridView_TimKiem_NhanVien(dgvNhanVien, NhanVien);
                    if (dgvNhanVien.RowCount == 0)
                    {
                        lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text;
                    }
                    else
                    {
                        lblKetQua.Text = "Kết quả tìm thấy " + txtTimKiem.Text + " là: " + dgvNhanVien.RowCount.ToString();
                    }
                }
            }
            catch (Exception)
            {
                lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMaKyLuat.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã kỷ luật không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKyLuat.Focus();
            }
            else
                if (dtiNgayKyLuat.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Ngày kỷ luật không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtiNgayKyLuat.Focus();
                }
                else
                    if (txtLyDo.Text.Trim() == "")
                    {
                        MessageBoxEx.Show("Lý do kỷ luật không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLyDo.Focus();
                    }
                    else

                        if (txtHinhThuc.Text.Trim() == "")
                        {
                            MessageBoxEx.Show("Hình thức kỷ luật không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLyDo.Focus();
                        }
                        else
                        {
                            if (Trangthai == true)
                            {
                                nvdn.ThemKyLuat(txtMaKyLuat.Text.ToString(), txtManv.Text.ToString(), txtLyDo.Text.ToString(), txtHinhThuc.Text.ToString(), Convert.ToDateTime(dtiNgayKyLuat.Text));

                            }
                            else
                            {
                                nvdn.SuaKyLuat(txtMaKyLuat.Text.ToString(), txtManv.Text.ToString(), txtLyDo.Text.ToString(), txtHinhThuc.Text.ToString(), Convert.ToDateTime(dtiNgayKyLuat.Text));

                            }
                            nvdn.LoadDataGridView_KyLuat(dgvKyLuat, txtManv.Text.ToString());
                            dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                            Xoa();
                        }

        }
        public void Xoa()
        {
            txtMaKyLuat.Text = "";
            txtLyDo.Text = "";
            txtHinhThuc.Text = "";
            dtiNgayKyLuat.Text = "";
        }
    }
}