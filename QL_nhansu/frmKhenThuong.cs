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
    public partial class frmKhenThuong : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsKhenThuong nvdn = new QL_nhansu.Class.clsKhenThuong();
       //bool trangthai = true;
        string NhanVien = "";
        public frmKhenThuong()
        {
            InitializeComponent();
        }
        bool Trangthai = true;
        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            dtiNgayKhen.Text = DateTime.Now.ToShortDateString();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa Khen Thưởng", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaKhenThuong(txtMaKhen.Text.ToString(), txtManv.Text.ToString());
                nvdn.LoadDataGridView_KhenThuong(dgvKhenThuong, txtManv.Text.ToString());
                Xoa();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvNhanVien.CurrentRow.Index;
            txtManv.Text = dgvNhanVien[0, hang].Value.ToString();
            nvdn.LoadDataGridView_KhenThuong(dgvKhenThuong, txtManv.Text.ToString());
            if (dgvKhenThuong.RowCount == 0)
            {
                dgvKhenThuong.Enabled = false;
                
            }
            else
            {
                dgvKhenThuong.Enabled = true;
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvPhongBan.CurrentRow.Index;
            string Mapb = dgvPhongBan[0, hang].Value.ToString();
            //MessageBox.Show(Madv);
            nvdn.LoadDataGidView_NhanVien(dgvNhanVien, Mapb.Trim().ToString());
            if (dgvNhanVien.RowCount == 0)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                dgvNhanVien.Enabled = false;
                dgvKhenThuong.Enabled = false;
                nvdn.LoadDataGridView_KhenThuong(dgvKhenThuong, "XXXX");
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                dgvNhanVien.Enabled = true;
                dgvKhenThuong.Enabled = true;
            }
            
        }

        private void dgvKhenThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvKhenThuong.CurrentRow.Index;
            txtMaKhen.Text = dgvKhenThuong[0, hang].Value.ToString();
            txtManv.Text = dgvKhenThuong[1, hang].Value.ToString();
            txtLyDo.Text = dgvKhenThuong[2, hang].Value.ToString();
            txtHinhThuc.Text = dgvKhenThuong[3, hang].Value.ToString();
            dtiNgayKhen.Text = dgvKhenThuong[4, hang].Value.ToString();


        }
        int laymakt()
        {
            return nvdn.DemDong() + 1;
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Trangthai=true;
                if (laymakt() < 9)
                {
                    txtMaKhen.Text = "KT" + "0" + laymakt().ToString();
                }
                else
                {
                    txtMaKhen.Text = "KT" + laymakt().ToString();
                }                   
                           
                 dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                 txtLyDo.Text = "";
                 txtHinhThuc.Text ="";
                 dtiNgayKhen.Text = "";
                        
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai=false;    
                        dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                        dgvKhenThuong.Enabled = true;
                   
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
                        NhanVien = txtTimKiem.Text.ToString();
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
        if (txtMaKhen.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Mã khen thưởng không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaKhen.Focus();
                }

                else
                    if (dtiNgayKhen.Text.Trim() == "")
                    {
                        MessageBoxEx.Show("Ngày khen thưởng không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtiNgayKhen.Focus();
                    }
                    else
                        if (txtLyDo.Text.Trim() == "")
                        {
                            MessageBoxEx.Show("Lý do khen thưởng không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLyDo.Focus();
                        }
                        else

                            if (txtHinhThuc.Text.Trim() == "")
                            {
                                MessageBoxEx.Show("Hình thức khen thưởng không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtLyDo.Focus();
                            }
                            else
                            {
                                if (Trangthai == true)
                                {
                                    nvdn.ThemKhenThuong(txtMaKhen.Text.ToString(), txtManv.Text.ToString(), txtLyDo.Text.ToString(), txtHinhThuc.Text.ToString(), Convert.ToDateTime(dtiNgayKhen.Text));
                                }
                                else
                                {
                                    nvdn.SuaKhenThuong(txtMaKhen.Text.ToString(), txtManv.Text.ToString(), txtLyDo.Text.ToString(), txtHinhThuc.Text.ToString(), Convert.ToDateTime(dtiNgayKhen.Text));

                                }
                                nvdn.LoadDataGridView_KhenThuong(dgvKhenThuong, txtManv.Text.ToString());
                                dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                                Xoa();
                            }

        }
        public void Xoa()
        {
            txtMaKhen.Text = "";
            txtLyDo.Text = "";
            txtHinhThuc.Text = "";
            dtiNgayKhen.Text = "";

        }

    }
}