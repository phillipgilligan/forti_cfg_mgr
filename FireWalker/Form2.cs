using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FireWalker
{
    public partial class mainForm : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public mainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createNext1_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count-1)
            {
                listPanel[++index].BringToFront();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            listPanel.Add(createPanel1);
            listPanel.Add(createPanel2);
            listPanel[index].BringToFront();
        }

        private void createPreviousButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //Hidden Test Button to Prove Functionallity

            //Takes the text boxes and formats the data for a write operation.
            string[] configSystemGlobal = new string[9];
            configSystemGlobal[0] = "config system global";
            configSystemGlobal[1] = "    set admin-scp " + scpComboBox.Text;
            configSystemGlobal[2] = "    set admin-sport " + admintTextBox.Text;
            configSystemGlobal[3] = "    set admintimeout " + adminTimeTextBox.Text;
            configSystemGlobal[4] = "    set alias " + '"' + aliasTextBox.Text + '"';
            configSystemGlobal[5] = "    set hostname " + '"' + hostNameTextBox.Text + '"';
            configSystemGlobal[6] = "    set proxy-auth-timeout " + proxyTimeTextBox.Text;
            configSystemGlobal[7] = "    set timezone " + timeZoneComboBox.Text;
            configSystemGlobal[8] = "end";

            //Prompts user where to save as well as forcing the mime type, them writes all lines from the textbox array to file.
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fortigate Config (*.conf)|*.conf";
            saveFileDialog.DefaultExt = "extension";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, configSystemGlobal);
            }
        }
    }
}
