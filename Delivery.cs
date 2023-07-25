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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
            ShowDelivery();
            GetAgentId();
            GetPArcel();
            Agentlbl.Text = Login.AName;
            Datelbl.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
            DelDGV.EnableHeadersVisualStyles = false;
            DelDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            DelDGV.Columns["DelNum"].HeaderText = "No";
            DelDGV.Columns["PrName"].HeaderText = "Parcel_No";
            DelDGV.Columns["DelDate"].HeaderText = "Delivery_Date";
            DelDGV.Columns["AgentNum"].HeaderText = "Agent_No";
            DelDGV.Columns["AgentName"].HeaderText = "Agent_Name";
            DelDGV.Columns["DelFees"].HeaderText = "Fees";
            DelDGV.Columns["RName"].HeaderText = "Reciver_Name";
            DelDGV.Columns["RPhone"].HeaderText = "Reciver_Phone";
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetAgentId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from Agent", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AgNum", typeof(int));
            dt.Load(rdr);
            AgNumCb.ValueMember = "AgNum";
            AgNumCb.DataSource = dt;
            con.Close();
        }

        private void GetAgentName()
        {
            String Query = "select * from Agent where AgNum=" + AgNumCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                AgNameTb.Text = dr["AgName"].ToString();
            }
        }

        private void GetPArcel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from ParcelTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(rdr);
            ParNumCb.ValueMember = "PNum";
            ParNumCb.DataSource = dt;
            con.Close();
        }

        private void ShowDelivery()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from DeliveryTbl", con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DelDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            AgNameTb.Text = "";
            DelDate.Text = "";
            ParNumCb.Text = "";
            AgNumCb.Text = "";
            FessTb.Text = "";
            ReNameTb.Text = "";
            RPhoneTb.Text = "";
        }


        //Savebtn
        private void button1_Click(object sender, EventArgs e)
        {
            if (AgNameTb.Text == "" || DelDate.Text == "" || ParNumCb.Text == "" || AgNumCb.Text == "" || FessTb.Text == "" || ReNameTb.Text == "" || RPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DeliveryTbl(PrName,DelDate,AgentNum,AgentName,DelFees,RName,RPhone)Values(@PN,@DD,@AN,@AGN,@DF,@RN,@RP)", con);
                    cmd.Parameters.AddWithValue("@PN", ParNumCb.Text);                        //ParNum But in Database By Mistake PrName is given
                    cmd.Parameters.AddWithValue("@DD", DelDate.Value.Date);
                    cmd.Parameters.AddWithValue("@AN", AgNumCb.Text);
                    cmd.Parameters.AddWithValue("@AGN", AgNameTb.Text);
                    cmd.Parameters.AddWithValue("@DF", FessTb.Text);
                    cmd.Parameters.AddWithValue("@RN", ReNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Recorded!!!");
                    con.Close();
                    ShowDelivery();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AgNumCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAgentName();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = 0;
        private void DelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ParNumCb.Text = DelDGV.SelectedRows[0].Cells[1].Value.ToString();
            DelDate.Text = DelDGV.SelectedRows[0].Cells[2].Value.ToString();
            AgNumCb.Text = DelDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgNameTb.Text = DelDGV.SelectedRows[0].Cells[4].Value.ToString();
            FessTb.Text = DelDGV.SelectedRows[0].Cells[5].Value.ToString();
            ReNameTb.Text = DelDGV.SelectedRows[0].Cells[6].Value.ToString();
            RPhoneTb.Text = DelDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (ParNumCb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DelDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (AgNameTb.Text == "" || DelDate.Text == "" || ParNumCb.Text == "" || AgNumCb.Text == "" || FessTb.Text == "" || ReNameTb.Text == "" || RPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update DeliveryTbl set PrName=@PN,DelDate=@DD,AgentNum=@AN,AgentName=@AGN,DelFees=@DF,RName=@RN,RPhone=@RP where DelNum=@Dkey", con);
                    cmd.Parameters.AddWithValue("@PN", ParNumCb.Text);                        //ParNum But in Database By Mistake PrName is given
                    cmd.Parameters.AddWithValue("@DD", DelDate.Value.Date);
                    cmd.Parameters.AddWithValue("@AN", AgNumCb.Text);
                    cmd.Parameters.AddWithValue("@AGN", AgNameTb.Text);
                    cmd.Parameters.AddWithValue("@DF", FessTb.Text);
                    cmd.Parameters.AddWithValue("@RN", ReNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Dkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated!!!");
                    con.Close();
                    ShowDelivery();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
             if (key==0)
            {
                MessageBox.Show("Select A Data");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from DeliveryTbl where DelNum=@Dkey", con);
                    cmd.Parameters.AddWithValue("@Dkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted!!!");
                    con.Close();
                    ShowDelivery();
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
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
    }
}
