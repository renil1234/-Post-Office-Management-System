using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostOffice
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (PasswordTb.Text == "")
            {
                MessageBox.Show("Enter the Password !!!");
            }
            else if (PasswordTb.Text == "password")
            {
                Agents obj = new Agents();
                obj.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Wrong Password");
            }
        }

        private void Backlbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
