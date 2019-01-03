using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using QL_nhansu.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_nhansu
{
    public partial class frmQuenMK : DevComponents.DotNetBar.Office2007Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clsQuenMK quenMK = new clsQuenMK();
            string userEmail = null;
            string userName = null;
            userEmail = txtUserEmail.Text;
            userName = txtUserName.Text;
            if (quenMK.QuenMK(userName, userEmail) == 1)
            {
                MessageBoxEx.Show("Reset mat khau thanh cong", "vui long vao email de xem mk moi");
                this.Hide();
            }
            else
            {
                MessageBoxEx.Show("email sai, nguoi dung sai", "vui long nhap lai email");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmQuenMK_Load(object sender, EventArgs e)
        {

        }
    }
  }
