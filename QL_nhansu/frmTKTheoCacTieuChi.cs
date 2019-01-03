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
    public partial class frmTKTheoCacTieuChi : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsTimKiem nvdn = new QL_nhansu.Class.clsTimKiem();

        public frmTKTheoCacTieuChi()
        {
            InitializeComponent();
        }

       
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTKTheoCacTieuChi_Load(object sender, EventArgs e)
        {
            nvdn.LoadComboBox_PhongBan(cmbPhongBan);
            nvdn.LoadComboBox_ChucVu(cmbChucVu);
            nvdn.LoadComboBox_TrinhDo(cmbTrinhDo);
            
            
        }

        private void rdPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhongBan.Checked == true)
            {
                cmbPhongBan.Enabled = true;
            }
            else
            {
                cmbPhongBan.Enabled = false;
            }
        }

        private void rdChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdChucVu.Checked == true)
            {
                cmbChucVu.Enabled = true;
            }
            else
            {
                cmbChucVu.Enabled = false;
            }
        }

        private void rdTrinhDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrinhDo.Checked == true)
            {
                cmbTrinhDo.Enabled = true;
            }
            else
            {
                cmbTrinhDo.Enabled = false;
            }
        }

       

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
             if (rdPhongBan.Checked == true)
            {
                nvdn.LoadDataGridView_TK_TheoPhongBan(dgvTimKiem, cmbPhongBan.SelectedValue.ToString());
                txtTongSoNhanVien.Text = dgvTimKiem.RowCount.ToString();
            }
            else 
                 
                 if (rdChucVu.Checked == true)
                {
                nvdn.LoadDataGridView_TK_TheoChucVu(dgvTimKiem, cmbChucVu.SelectedValue.ToString());
                txtTongSoNhanVien.Text = dgvTimKiem.RowCount.ToString();
                }
                else
                     if (rdTrinhDo.Checked == true)
                    {
                    nvdn.LoadDataGridView_TK_TheoTrinhDo(dgvTimKiem, cmbTrinhDo.SelectedValue.ToString());
                    txtTongSoNhanVien.Text = dgvTimKiem.RowCount.ToString();
                    }
                     //else
                     //    if (rdThamNien.Checked == true)
                     //    {
                     //        nvdn.LoadDataGridView_TK_TheoThamNien(dgvTimKiem, cmbThamNien.SelectedValue.ToString());
                     //        txtTongSoNhanVien.Text = dgvTimKiem.RowCount.ToString();
                     //    }
        }

        //private void rdThamNien_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdThamNien.Checked == true)
        //    {
        //        cmbThamNien.Enabled = true;
        //    }
        //    else
        //    {
        //        cmbThamNien.Enabled = false;
        //    }
        //}

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}