using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void StartProgram(string strAppname)
        {
            try
            {
                TestLib.LogFile = "c:\\testlog.log";
                TestLib.StartProgram(txtAppname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnStartApp_Click(object sender, EventArgs e)
        {
            try
            {
                StartProgram(txtAppname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAutoTester aForm = new AboutAutoTester();
            aForm.ShowDialog();
        }

        private void startApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStartApp.PerformClick();
        }
    }
}
