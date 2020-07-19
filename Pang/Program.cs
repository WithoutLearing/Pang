using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pang
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new frmSplashScreen());
            frmSplashScreen splashScreen = new frmSplashScreen();
            if (splashScreen.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new frm_Login());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
