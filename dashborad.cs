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
    public partial class dashborad : Form
    {
        public dashborad()
        {
            InitializeComponent();
            getdata();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");

        private void getdata()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Amt) from MoneyTr",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            moneylbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from MoneyTr", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            nolbl.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(PStatus) from ParcelTbl ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            palbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from DeliveryTbl ", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            dlbl.Text = dt3.Rows[0][0].ToString();
            con.Close();

            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from CustomerTbl ", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            clbl.Text = dt4.Rows[0][0].ToString();
            con.Close();

            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from Agent ", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            albl.Text = dt5.Rows[0][0].ToString();
            con.Close();
        }

        private void dashborad_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
    }
}
