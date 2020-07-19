using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pang
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelProgressbar.Width>=700)
            {
                this.DialogResult = DialogResult.OK;
                timerProgressbar.Stop();
            }
            else
            {
                panelProgressbar.Width += 5;
            }
        }
    }
}
