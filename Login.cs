using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PostOffice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");
       
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adminibl_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }

        public static string AName = "";

        private void Lodinbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Agent where AgName='" + UNameTb.Text + "'and AgPass='" + PasswordTb.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AName = UNameTb.Text;
                MainMenu obj = new MainMenu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password !!!");
            }
            con.Close();
        }
    }
}
