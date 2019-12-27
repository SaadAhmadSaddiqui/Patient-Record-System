using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Patient_Record_System
{
    public partial class registerForm : Form
    {
        public HomePage hp;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saad\Documents\Visual Studio 2019\Projects\Patient Record System\Patient Record System\DB.mdf;Integrated Security=True;Connect Timeout=30");

        public registerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblWarning.Text = "Leaving fields empty is not allowed";
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Login values(@Username,@Password)", con);
            cmd.Parameters.AddWithValue("Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("Password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Account created!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hp.Show(); 
            this.Close();
        }
    }
}
