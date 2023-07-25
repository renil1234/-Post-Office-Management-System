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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            ShowAgents();
            AgentsDGV.EnableHeadersVisualStyles = false;
            AgentsDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            AgentsDGV.Columns["AgNum"].HeaderText = "No";
            AgentsDGV.Columns["AgName"].HeaderText = "Name";
            AgentsDGV.Columns["AgDob"].HeaderText = "Birth_Date";
            AgentsDGV.Columns["AgAdd"].HeaderText = "Address";
            AgentsDGV.Columns["AgPhone"].HeaderText = "Phone_No";
            AgentsDGV.Columns["AgGen"].HeaderText = "Gender";
            AgentsDGV.Columns["AgPass"].HeaderText = "Password";
            AgentsDGV.Columns["AgEm"].HeaderText = "Email";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select A Agent");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Agent where AgNum=@Ckey", con);
                    cmd.Parameters.AddWithValue("@Ckey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Deleted!!!");
                    con.Close();
                    ShowAgents();
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

        private void ShowAgents()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Agent", con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || ADOB.Text == "" || AddressTb.Text == "" || APhoneTb.Text == "" || AgenCb.Text == "" || APasswordTb.Text == "" || EmailTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Agent(AgName,AgDob,AgAdd,AgPhone,AgGen,AgPass,AgEm)Values(@AN,@AD,@AA,@AP,@AG,@APS,@AE)", con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@AD", ADOB.Value.Date);
                    cmd.Parameters.AddWithValue("@AA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@AP", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AG", AgenCb.Text);
                    cmd.Parameters.AddWithValue("@APS", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EmailTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Recorded!!!");
                    con.Close();
                    ShowAgents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void AgentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ANameTb.Text = AgentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ADOB.Text = AgentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = AgentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            APhoneTb.Text = AgentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            AgenCb.Text = AgentsDGV.SelectedRows[0].Cells[5].Value.ToString();
            APasswordTb.Text = AgentsDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmailTb.Text = AgentsDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (ANameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AgentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            ANameTb.Text = "";
            APhoneTb.Text = "";
            ADOB.Text = "";
            APasswordTb.Text = "";
            AgenCb.Text = "";
            AddressTb.Text = "";
            EmailTb.Text = "";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APhoneTb.Text == "" || ADOB.Text == "" || APasswordTb.Text == "" || AgenCb.Text == "" || AddressTb.Text == "" || EmailTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Agent set AgName=@AN,AgDob=@AD,AgAdd=@AA,AgPhone=@AP,AgGen=@AG,AgPass=@APS,AgEm=@AE where AgNum=@Akey", con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@AD", ADOB.Value.Date);
                    cmd.Parameters.AddWithValue("@AA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@AP", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AG", AgenCb.Text);
                    cmd.Parameters.AddWithValue("@APS", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EmailTb.Text);
                    cmd.Parameters.AddWithValue("@Akey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Updated!!!");
                    con.Close();
                    ShowAgents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            if (rb1.Checked)
            {

                con.Open();
                string query = "select * from Agent where AgNum='" + searchtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader dr = cmd.ExecuteReader();
                bool recordfound = dr.Read();
                
                if (recordfound)
                {
                      
                }
                else
                {
                    MessageBox.Show("No Data Found!!!");
                }
                con.Close();
               
                if (rb1.Checked)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    AgentsDGV.DataSource = ds.Tables[0];
                    con.Close();
                }
            }

            
            if (rb2.Checked)
            {

                con.Open();
                string query = "select * from Agent where AgName='" + searchtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                bool recordfound = dr.Read();

                if (recordfound)
                {

                }
                else
                {
                    MessageBox.Show("No Data Found!!!");
                }
                con.Close();

                if (rb2.Checked)
                {
                    con.Open();
                    SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                    SqlCommandBuilder bilder = new SqlCommandBuilder(sda1);
                    var ds1 = new DataSet();
                    sda1.Fill(ds1);
                    AgentsDGV.DataSource = ds1.Tables[0];
                    con.Close();
                }
            }

            if (rb3.Checked)
            {
                con.Open();
                string query = "select * from Agent where AgPhone='" + searchtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                bool recordfound = dr.Read();

                if (recordfound)
                {

                }
                else
                {
                    MessageBox.Show("No Data Found!!!");
                }
                con.Close();

                if (rb3.Checked)
                {
                    con.Open();
                    SqlDataAdapter sda2 = new SqlDataAdapter(query, con);
                    SqlCommandBuilder bilder = new SqlCommandBuilder(sda2);
                    var ds2 = new DataSet();
                    sda2.Fill(ds2);
                    AgentsDGV.DataSource = ds2.Tables[0];
                    con.Close();
                }
            }
        }

        private void disbtn_Click(object sender, EventArgs e)
        {
            searchtb.Text = "";
            con.Open();
            string query = "select * from Agent";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda2);
            var ds2 = new DataSet();
            sda2.Fill(ds2);
            AgentsDGV.DataSource = ds2.Tables[0];
            con.Close();
        }
    }
}
