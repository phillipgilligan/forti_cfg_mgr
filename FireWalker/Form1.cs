using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireWalker
{
    public partial class splashForm : Form
    {
        public splashForm()
        {
            InitializeComponent();
        }

        private void splashFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                splashFadeTimer.Stop();
                this.Hide();
                mainForm f2 = new mainForm();
                f2.ShowDialog();
                this.Close();
            }
            Opacity -= .035;
        }
    }
}
