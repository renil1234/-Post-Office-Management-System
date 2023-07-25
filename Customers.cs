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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowCustomer();
            Datelbl.Text=DateTime.Today.Day+"/"+DateTime.Today.Month+"/"+DateTime.Today.Year;
            CustDGV.EnableHeadersVisualStyles = false;
            CustDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            CustDGV.Columns["CustNum"].HeaderText = "No";
            CustDGV.Columns["CustName"].HeaderText = "Name";
            CustDGV.Columns["CustDob"].HeaderText = "Birth_Date";
            CustDGV.Columns["CustPhone"].HeaderText = "Phone_No";
            CustDGV.Columns["CustAdd"].HeaderText = "Address";
            CustDGV.Columns["CustCity"].HeaderText = "City";
            CustDGV.Columns["CustState"].HeaderText = "State";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ShowCustomer()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from CustomerTbl",con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (CustAddTb.Text == "" || CustNameTb.Text == "" || CustPhoneTb.Text == "" || CustStateTb.Text == "" || CustCityTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustName,CustDOB,CustPhone,CustAdd,CustCity,CustState)Values(@CN,@CD,@CP,@CA,@CC,@CS)",con);
                    cmd.Parameters.AddWithValue("@CN",CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CustDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddTb.Text);
                    cmd.Parameters.AddWithValue("@CC", CustCityTb.Text);
                    cmd.Parameters.AddWithValue("@CS", CustStateTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Recorded!!!");
                    con.Close();
                    ShowCustomer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CustAddTb.Text == "" || CustNameTb.Text == "" || CustPhoneTb.Text == "" || CustStateTb.Text == "" || CustCityTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName=@CN,CustDOB=@CD,CustPhone=@CP,CustAdd=@CA,CustCity=@CC,CustState=@CS where CustNum=@Ckey", con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CustDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddTb.Text);
                    cmd.Parameters.AddWithValue("@CC", CustCityTb.Text);
                    cmd.Parameters.AddWithValue("@CS", CustStateTb.Text);
                    cmd.Parameters.AddWithValue("@Ckey",key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated!!!");
                    con.Close();
                    ShowCustomer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        int key = 0;
        private void CustDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = CustDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustDOB.Text = CustDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhoneTb.Text = CustDGV.SelectedRows[0].Cells[3].Value.ToString();
            CustAddTb.Text = CustDGV.SelectedRows[0].Cells[4].Value.ToString();
            CustCityTb.Text = CustDGV.SelectedRows[0].Cells[5].Value.ToString();
            CustStateTb.Text = CustDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (CustNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CustDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        { 
            CustNameTb.Text = "";
            CustDOB.Text = "";
            CustPhoneTb.Text = "";
            CustAddTb.Text = "";
            CustCityTb.Text ="";
            CustStateTb.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Select A Customer");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustNum=@Ckey", con);
                    cmd.Parameters.AddWithValue("@Ckey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted!!!");
                    con.Close();
                    ShowCustomer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                con.Open();
                string query = "select * from CustomerTbl where CustNum='" + searchtb.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CustDGV.DataSource = ds.Tables[0];
                con.Close();
            
            }
            

            if (rb2.Checked)
            {
                con.Open();
                string query = "select * from CustomerTbl where CustName='" + searchtb.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                SqlCommandBuilder bilder = new SqlCommandBuilder(sda1);
                var ds1 = new DataSet();
                sda1.Fill(ds1);
                CustDGV.DataSource = ds1.Tables[0];
                con.Close();
            }

            if (rb3.Checked)
            {
                con.Open();
                string query = "select * from CustomerTbl where CustPhone='" + searchtb.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query, con);
                SqlCommandBuilder bilder = new SqlCommandBuilder(sda2);
                var ds2 = new DataSet();
                sda2.Fill(ds2);
                CustDGV.DataSource = ds2.Tables[0];
                con.Close();
            }
        }

        private void disbtn_Click(object sender, EventArgs e)
        {
            searchtb.Text = "";
            con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda2);
            var ds2 = new DataSet();
            sda2.Fill(ds2);
            CustDGV.DataSource = ds2.Tables[0];
            con.Close();
        }

        
    }
}
