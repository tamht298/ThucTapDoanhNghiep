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
    public partial class frmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsNhanVien nvdn = new QL_nhansu.Class.clsNhanVien();
        string manv;
        string Nhanvien = "";
        int hang;
        bool KiemTraChonAnh = false;
       // SqlConnection MyConnection1 = new SqlConnection();

        SqlConnection MyConnection;
        string gioitinh;
        bool Trangthai = true;


        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
           // MyConnection = Class.clsData.OpenSqlConnection();
            MyConnection = QL_nhansu.Class.clsData.OpenSqlConnection();
            //nvdn.LoadComboBox_GioiTinh(cmbGioiTinh);

            nvdn.LoadComboBox_NgoaiNgu(cmbNgoaiNgu);
            //nvdn.LoadComboBox_NhomMau(cmb);
            nvdn.LoadComboBox_PhongBan(cmbPhongban);
            nvdn.LoadComboBox_ChucVu(cmbChucVu);
            nvdn.LoadComboBox_HocVi(cmbHocVi);

            nvdn.LoadComboBox_TinHoc(cmbTinHoc);
            //nvdn.LoadComboBox_ToLamViec(cmbTo);
            nvdn.LoadComboBox_DanToc(cmbDanToc);
            nvdn.LoadComboBox_TonGiao(cmbTonGiao);

            nvdn.LoadDataGridView_TTChung(dgvTTChung);
            nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());     

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaNhanVien(txtMaNV.Text);
                nvdn.LoadDataGridView_TTChung(dgvTTChung);
                nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
                Xoa();

            }
        }

        private void dgvTTChung_CellClick(object sender, DataGridViewCellEventArgs e)
        {

             hang = dgvTTChung.CurrentRow.Index;
             txtMaNV.Text = dgvTTChung[0, hang].Value.ToString();
             txtTenNV.Text = dgvTTChung[1, hang].Value.ToString();
             txtCMND.Text = dgvTTChung[2, hang].Value.ToString();
             dtiNgayCap.Text = dgvTTChung[3, hang].Value.ToString();
             txtNoiCap.Text = dgvTTChung[4, hang].Value.ToString();
             dtiNgaySinh.Text = dgvTTChung[5, hang].Value.ToString();
            // cmbGioiTinh.Text = dgvTTChung[6, hang].Value.ToString();
             txtNguyenQuan.Text = dgvTTChung[7, hang].Value.ToString();
             txtDCTamTru.Text = dgvTTChung[8, hang].Value.ToString();
             txtEmail.Text = dgvTTChung[9, hang].Value.ToString();
             txtDTRieng.Text = dgvTTChung[10, hang].Value.ToString();
             txtDTNha.Text = dgvTTChung[11, hang].Value.ToString();
             txtHonNhan.Text = dgvTTChung[12, hang].Value.ToString();
             txtLamViec.Text = dgvTTChung[13, hang].Value.ToString();

             nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
        }

      
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());     
        }

        private void dgvTTLienQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hang = dgvTTLienQuan.CurrentRow.Index;
            cmbPhongban.Text = dgvTTLienQuan[1, hang].Value.ToString();
            //cmbTo.Text = dgvTTLienQuan[2, hang].Value.ToString();
            cmbChucVu.Text = dgvTTLienQuan[2, hang].Value.ToString();
            dtiNgayVao.Text = dgvTTLienQuan[3, hang].Value.ToString();
            txtThamNien.Text = dgvTTLienQuan[4, hang].Value.ToString();
            txtHeSo.Text = dgvTTLienQuan[5, hang].Value.ToString();
            cmbTinHoc.Text = dgvTTLienQuan[6, hang].Value.ToString();
            cmbNgoaiNgu.Text = dgvTTLienQuan[7, hang].Value.ToString();
            cmbHocVi.Text = dgvTTLienQuan[8, hang].Value.ToString();
            txtSoBHXH.Text = dgvTTLienQuan[9, hang].Value.ToString();
            txtSoBHYT.Text = dgvTTLienQuan[10, hang].Value.ToString();
            txtCanNang.Text = dgvTTLienQuan[11, hang].Value.ToString();
            txtCao.Text = dgvTTLienQuan[12, hang].Value.ToString();
            txtNhomMau.Text = dgvTTLienQuan[13, hang].Value.ToString();
            txtSucKhoe.Text = dgvTTLienQuan[14, hang].Value.ToString();
            txtSoTK.Text = dgvTTLienQuan[15, hang].Value.ToString();
            cmbDanToc.Text = dgvTTLienQuan[16, hang].Value.ToString();
            cmbTonGiao.Text = dgvTTLienQuan[17, hang].Value.ToString();


        }

       

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            Trangthai = true;
            int MaNhanVien = dk.MaTuTang(dgvTTChung);
           
            if (MaNhanVien <= 9)
            {
                txtMaNV.Text = "NV" + "0" + MaNhanVien.ToString();
            }
            else
            {
                txtMaNV.Text = "NV" + MaNhanVien.ToString();
            }
              
              

                    dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    txtCanNang.Text = "";
                    txtCao.Text = "";
                    txtCMND.Text = "";
                    txtDCTamTru.Text = "";
                    txtDTNha.Text = "";
                    txtDTRieng.Text = "";
                    txtEmail.Text = "";
                    txtHeSo.Text = "";
                    txtHonNhan.Text = "";
                    txtLamViec.Text = "";
                    txtNoiCap.Text = "";
                    txtNguyenQuan.Text = "";
                    txtNhomMau.Text = "";
                    txtSoBHXH.Text = "";
                    txtSoBHYT.Text = "";
                    txtSoTK.Text = "";
                    txtSucKhoe.Text = "";
                    txtTenNV.Text = "";
                    txtThamNien.Text = "";
                    cmbChucVu.Text = "";
                    cmbDanToc.Text = "";
                    cmbHocVi.Text = "";
                    cmbNgoaiNgu.Text = "";
                    cmbPhongban.Text = "";
                    cmbTinHoc.Text = "";
                    //cmbTo.Text = "";
                    cmbTonGiao.Text = "";
                    dtiNgayCap.Text = "";
                    dtiNgaySinh.Text = "";
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai = false;
                dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
           //Cap nhat anh vao csdl
          
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            frmPhongBan f_PhongBan = new frmPhongBan();
            f_PhongBan.ShowDialog();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu f_ChucVu = new frmChucVu();
            f_ChucVu.ShowDialog();
        }

        //private void btnTo_Click(object sender, EventArgs e)
        //{
        //    frmToLamViec f_ToLamViec = new frmToLamViec();
        //    f_ToLamViec.ShowDialog();
        //}

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text.Trim() == "")
                {
                    lblKetQua.Text = "Bạn phải nhập mã nhân viên cần tìm";
                }
                else
                {
                    if (txtTimKiem.Text.Contains("'") == true)
                    {
                        Nhanvien = txtTimKiem.Text.Replace("'", "'" + "'");
                    }
                    else
                    {
                        Nhanvien = txtTimKiem.Text;
                    }
                    nvdn.LoadDataGridView_TTChung_TimKiem(dgvTTChung, Nhanvien);
                    if (dgvTTChung.RowCount == 0)
                    {
                        lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text;
                    }
                    else
                    {
                        lblKetQua.Text = "Kết quả tìm thấy " + txtTimKiem.Text + " là: " + dgvTTChung.RowCount.ToString();
                    }
                }
            }
            catch (Exception)
            {
                lblKetQua.Text = "Không tìm thấy " + txtTimKiem.Text;
            }
        }

        private void btnTinHoc_Click(object sender, EventArgs e)
        {
            frmTinHoc f_TinHoc = new frmTinHoc();
            f_TinHoc.ShowDialog();
        }

        private void btnNgoaiNgu_Click(object sender, EventArgs e)
        {
            frmNgoaiNgu f_NgoaiNgu = new frmNgoaiNgu();
            f_NgoaiNgu.ShowDialog();
        }

        private void btnBangCap_Click(object sender, EventArgs e)
        {
            frmBangCap f_BangCap = new frmBangCap();
            f_BangCap.ShowDialog();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc f_DanToc = new frmDanToc();
            f_DanToc.ShowDialog();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            frmTonGiao f_TonGiao = new frmTonGiao();
            f_TonGiao.ShowDialog();
        }

        private void txtDTRieng_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtDTRieng);

        }

        private void txtDTNha_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtDTNha);

        }

        private void txtHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtHeSo);

        }

        private void txtThamNien_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtThamNien);

        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtCMND);

        }

        private void txtCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtCanNang);

        }

        private void txtCao_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtCao);

        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
             if (rdNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã nhân viên không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
            }

            else if (txtTenNV.Text.Trim() == "")
            {
                MessageBoxEx.Show("Tên nhân viên không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
            }
            else if (dtiNgaySinh.Text.Trim() == "" || Convert.ToDateTime(dtiNgaySinh.Text.Trim()) > DateTime.Now.Date)
            {
                MessageBoxEx.Show("Ngày sinh không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtiNgaySinh.Focus();
            }
            else if (txtCMND.Text.Trim() == "" || txtCMND.Text.Length < 9)
            {
                MessageBoxEx.Show("CMND không được trống hoặc < 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
            }
            else if (txtNoiCap.Text.Trim() == "")
            {
                MessageBoxEx.Show("Nơi cấp CMND không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoiCap.Focus();

            }
            else if (txtDTRieng.Text.Length < 9 || txtDTRieng.Text.Length > 15)
            {
                MessageBoxEx.Show("Số điện thoại riêng không được <9 và >15 số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDTRieng.Focus();
            }
           
            else if (txtNguyenQuan.Text.Trim() == "")
            {
                MessageBoxEx.Show("Nguyên quán không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNguyenQuan.Focus();
            }
            else if (dtiNgayVao.Text.Trim() == "")
            {
                MessageBoxEx.Show("Ngày vào làm không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtiNgayVao.Focus();
            }
            else if (txtThamNien.Text.Trim() == "" || (Convert.ToInt32(txtThamNien.Text) < 0||Convert.ToInt32(txtThamNien.Text) > 50))
            {
                MessageBoxEx.Show("Năm thâm niên từ 0-50 năm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThamNien.Focus();
            }
            else if (txtHeSo.Text.Trim() == "" || (Convert.ToDecimal(txtHeSo.Text) < 0 || Convert.ToDecimal(txtHeSo.Text) > 2))
            {
                MessageBoxEx.Show("Hệ số chỉ từ 0-2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeSo.Focus();
            }
            else if (txtCanNang.Text.Trim() == "" || (Convert.ToDecimal(txtCanNang.Text) < 20 || Convert.ToDecimal(txtCanNang.Text) > 200))
            {
                MessageBoxEx.Show("Cân nặng chỉ từ 20-200", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCanNang.Focus();
            }
            else 
            if(txtCao.Text.Trim()!="" && (Convert.ToDecimal(txtCao.Text) < 1 || Convert.ToDecimal(txtCao.Text) > 4))
            {
                    MessageBoxEx.Show("Chiều cao từ 1-4 m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCao.Focus();
                }
                
                else
                {

                if (Trangthai==true)
                {
                    nvdn.ThemNhanVien(txtMaNV.Text, txtTenNV.Text, txtCMND.Text, Convert.ToDateTime(dtiNgayCap.Text.ToString()), txtNoiCap.Text, Convert.ToDateTime(dtiNgaySinh.Text.ToString()), gioitinh
                                           , txtNguyenQuan.Text, txtDCTamTru.Text, txtEmail.Text, txtDTRieng.Text, txtDTNha.Text, txtHonNhan.Text, txtLamViec.Text
                                           , cmbPhongban.SelectedValue.ToString()/*, cmbTo.SelectedValue.ToString()*/, cmbChucVu.SelectedValue.ToString(), Convert.ToDateTime(dtiNgayVao.Text.ToString())
                                           , int.Parse(txtThamNien.Text), float.Parse(txtHeSo.Text), cmbTinHoc.SelectedValue.ToString(), cmbNgoaiNgu.SelectedValue.ToString(), cmbHocVi.SelectedValue.ToString(), txtSoBHXH.Text, txtSoBHYT.Text
                                           , txtCanNang.Text, txtCao.Text, txtNhomMau.Text, txtSucKhoe.Text, txtSoTK.Text, cmbDanToc.SelectedValue.ToString(), cmbTonGiao.SelectedValue.ToString());
                }
                else
                {
                    nvdn.SuaNhanVien(txtMaNV.Text, txtTenNV.Text, txtCMND.Text, Convert.ToDateTime(dtiNgayCap.Text.ToString()), txtNoiCap.Text, Convert.ToDateTime(dtiNgaySinh.Text.ToString()), gioitinh, txtNguyenQuan.Text
                                       , txtDCTamTru.Text, txtEmail.Text, txtDTRieng.Text, txtDTNha.Text, txtHonNhan.Text, txtLamViec.Text, cmbPhongban.SelectedValue.ToString()/*, cmbTo.SelectedValue.ToString()*/, cmbChucVu.SelectedValue.ToString(), Convert.ToDateTime(dtiNgayVao.Text.ToString())
                                       , int.Parse(txtThamNien.Text), float.Parse(txtHeSo.Text), cmbTinHoc.SelectedValue.ToString(), cmbNgoaiNgu.SelectedValue.ToString(), cmbHocVi.SelectedValue.ToString(), txtSoBHXH.Text, txtSoBHYT.Text, txtCanNang.Text, txtCao.Text
                                       , txtNhomMau.Text, txtSucKhoe.Text, txtSoTK.Text, cmbDanToc.SelectedValue.ToString(), cmbTonGiao.SelectedValue.ToString());


                }
                nvdn.LoadDataGridView_TTChung(dgvTTChung);
                nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
                
                dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                Xoa();
            }
           

           
           

        }
        public void Xoa()
        {
            txtMaNV.Text = "";
            txtCanNang.Text = "";
            txtCao.Text = "";
            txtCMND.Text = "";
            txtDCTamTru.Text = "";
            txtDTNha.Text = "";
            txtDTRieng.Text = "";
            txtEmail.Text = "";
            txtHeSo.Text = "";
            txtHonNhan.Text = "";
            txtLamViec.Text = "";
            txtNoiCap.Text = "";
            txtNguyenQuan.Text = "";
            txtNhomMau.Text = "";
            txtSoBHXH.Text = "";
            txtSoBHYT.Text = "";
            txtSoTK.Text = "";
            txtSucKhoe.Text = "";
            txtTenNV.Text = "";
            txtThamNien.Text = "";
            cmbChucVu.Text = "";
            cmbDanToc.Text = "";
            cmbHocVi.Text = "";
            cmbNgoaiNgu.Text = "";
            cmbPhongban.Text = "";
            cmbTinHoc.Text = "";
            //cmbTo.Text = "";
            cmbTonGiao.Text = "";
            dtiNgayCap.Text = "";
            dtiNgaySinh.Text = "";
            dtiNgayVao.Text = "";
        }

        private void tabTinhTrangChung_Click(object sender, EventArgs e)
        {
        if (dgvTTChung.RowCount == 0)
        {
            nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
        }
        else
        {
            manv = dgvTTChung[0, hang].Value.ToString();
            nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
        }
        }

        private void tabTinhTrangChung_MouseDown(object sender, MouseEventArgs e)
        {
             if (dgvTTChung.RowCount == 0)
             {
                 nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
             }
             else
             {
                 manv = dgvTTChung[0, hang].Value.ToString();
                 nvdn.LoadDataGridView_TTLienQuan(dgvTTLienQuan, txtMaNV.Text.ToString());
             }
        }

        private void txtSoBHXH_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtCMND);

        }

        private void txtSoBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoNguyen(sender, e, txtCMND);

        }

        private void cmbTinHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}