using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_System
{
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            
            InitializeComponent();
            pInfoToolStripMenuItem.Enabled = false;

        }
        private void saadToolStripMenuItem_Click(object sender, EventArgs e) //opens the cv file stored on my pc. always chenge the file path when making changes to this block of code.
        {
            string file = @"C:\Users\saad\Documents\Visual Studio 2019\Projects\Patient Record System\Patient Record System\Files\Saads CV.docx";
            Process.Start(file);
        }

        private void meherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\saad\Documents\Visual Studio 2019\Projects\Patient Record System\Patient Record System\Files\Mehers CV.docx";
            Process.Start(file);
        }

        private void pInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientInfo PI = new PatientInfo();
            //this.IsMdiContainer = true;
            //f3.MdiParent = this;
            //f3.Show();
            PI.Show();
            PI.hp = this;
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e) //displaying the current time and date.
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.hp = this;
            this.Hide();
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registerForm f2 = new registerForm();
            f2.Show();
            f2.hp = this;
            this.Hide();
        }

        

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pInfoToolStripMenuItem.Enabled == true)
            {

                pInfoToolStripMenuItem.Enabled = false;
                label2.Text = "No User Active";
            }
        }
    }
}
