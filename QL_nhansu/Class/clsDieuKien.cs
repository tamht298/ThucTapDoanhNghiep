using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Threading;


namespace QL_nhansu.Class
{
    class clsDieuKien
    {
        public void LoadLen(ButtonX them, ButtonX sua, ButtonX luu, ButtonX xoa, ButtonX thoat)
        {
            them.Enabled = true;
            sua.Enabled = true;
            luu.Enabled = false;
            xoa.Enabled = true;
            thoat.Enabled =true;
        }
        public void Them(ButtonX them, ButtonX sua,ButtonX luu, ButtonX xoa, ButtonX thoat)
        {
            them.Enabled = false;
            xoa.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            thoat.Enabled = true;
            
        }
        public void Sua(ButtonX them, ButtonX sua,ButtonX luu, ButtonX xoa, ButtonX thoat)
        {
            them.Enabled = false;
            xoa.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            thoat.Enabled = true;
            
        }
        public void Xoa(ButtonX them, ButtonX sua,ButtonX luu, ButtonX xoa, ButtonX thoat)
        {
            them.Enabled = true;
            xoa.Enabled = false;
            sua.Enabled = true;
            thoat.Enabled = true;

        }
        public void Luu(ButtonX them, ButtonX sua,ButtonX luu, ButtonX xoa, ButtonX thoat)
        {
            them.Enabled = true;
            xoa.Enabled = true;
            sua.Enabled = true;
            thoat.Enabled = true;
            luu.Enabled = false;

        }
        //Kiem tra nhap ma trung
        public bool KiemTraMa(DataGridViewX dgv, string ma)
        {
            bool ok = false;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (ma == dgv[0, i].Value.ToString())
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
        public int MaTuTang(DataGridViewX dgv)
        {
            if (dgv.RowCount == 0)
            {
                return 1;
            }
            else
            {
                string Makt = dgv[0, dgv.RowCount - 1].Value.ToString();
                //string Makt = dgv.Rows[dgv.RowCount-1].Cells["colMachucvu"].Value.ToString();
                int s = Convert.ToInt32(Makt.Substring(2).Trim());
                return s + 1;
            }
        }
        //Ham chi cho phep nhap so thuc cho TextBox
        public void NhapSoThuc(object sender, KeyPressEventArgs e, TextBoxX tb)
        {
            string DecimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char DecimalChar = Convert.ToChar(DecimalString);
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            { }
            else
                if (e.KeyChar.ToString() == DecimalString && tb.Text.IndexOf(DecimalString) == -1)
                { }
                else
                {
                    e.Handled = true;
                }

        }
        //Ham chi cho nhap so nguyen
        public void NhapSoNguyen(object sender, KeyPressEventArgs e, TextBoxX tb)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            { }
            else
            {
                e.Handled = true;
            }
        }
        public bool KiemTraMa1(DataGridViewX dgv, string ma)
        {
            bool ok = false;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (ma != dgv[0, i].Value.ToString())
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
    }
}
