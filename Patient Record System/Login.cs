using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_System
{
    public partial class Login : Form
    {
        public HomePage hp;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saad\Documents\Visual Studio 2019\Projects\Patient Record System\Patient Record System\DB.mdf;Integrated Security=True;Connect Timeout=30";

            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Login where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);   
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    HomePage home = new HomePage();
                    home.Show();
                    home.label2.Text = "Using as: " + username.Text + "";
                    home.pInfoToolStripMenuItem.Enabled = true;
                    home.logOutToolStripMenuItem.Enabled = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hp.Show();
            this.Close();
        }
    }
}


