using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QL_nhansu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //Application.Run(new frmDangNhap());



            if (BienToanCuc.f_main == null || BienToanCuc.f_main.IsDisposed)
            {
                BienToanCuc.f_main = new frmMain();
            }
            Application.Run(BienToanCuc.f_main); 



            //Application.Run(new frmBangchiluong());
           


        }
    }
}
