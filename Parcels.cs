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
    public partial class Parcels : Form
    {
        public Parcels()
        {
            InitializeComponent();
            ShowParcel();
            GetSendId();
            Agentlbl.Text = Login.AName;
            Datelbl.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
            ParcelDGV.EnableHeadersVisualStyles = false;
            ParcelDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            ParcelDGV.Columns["PNum"].HeaderText = "No";
            ParcelDGV.Columns["PDate"].HeaderText = "Parcel_Date";
            ParcelDGV.Columns["PSource"].HeaderText = "Source";
            ParcelDGV.Columns["PSName"].HeaderText = "Sender";
            ParcelDGV.Columns["PRName"].HeaderText = "Receiver";
            ParcelDGV.Columns["PSAdd"].HeaderText = "Sender_Address";
            ParcelDGV.Columns["PSPhone"].HeaderText = "Sender_Phone_no";
            ParcelDGV.Columns["PRPhone"].HeaderText = "Receiver_Phone_no";
            ParcelDGV.Columns["Packw"].HeaderText = "Pack_Weight";
            ParcelDGV.Columns["Packsize"].HeaderText = "Pack_Size";
            ParcelDGV.Columns["PType"].HeaderText = "Type";
            ParcelDGV.Columns["PAgent"].HeaderText = "Parcel_Agent";
            ParcelDGV.Columns["PStatus"].HeaderText = "Status";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowParcel()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ParcelTbl", con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ParcelDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");

        private void Reset()
        {
            SNameTb.Text = "";
            PDate.Text = "";
            PSourceCb.Text = "";
            RecNameTb.Text = "";
            RecPhoneTb.Text = "";
            SPhoneTb.Text = "";
            PSAddressTb.Text = "";
            PacTypeCb.Text = "";
            StatusCb.Text = "";
            PacWTb.Text = "";
            PacSTb.Text = "";
        }

        private void GetSendId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from CustomerTbl",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustNum",typeof(int));
            dt.Load(rdr);
            SendIdCb.ValueMember = "CustNum";
            SendIdCb.DataSource = dt;
            con.Close();
        }

        private void GetSenderName()
        {
            String Query = "select * from CustomerTbl where CustNum=" + SendIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SNameTb.Text = dr["CustName"].ToString();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || PDate.Text == "" || PSourceCb.Text == "" || RecNameTb.Text == "" || SPhoneTb.Text == "" || RecPhoneTb.Text == "" || PSAddressTb.Text == "" || PacTypeCb.Text == "" || StatusCb.Text == "" || PacWTb.Text == "" || PacSTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ParcelTbl(PDate,PSource,PSName,PRName,PSAdd,PSPhone,PRPhone,PackW,PackSize,PType,PAgent,PStatus)Values(@PD,@PS,@PN,@PRN,@PSA,@PSP,@PRP,@PW,@PAS,@PT,@PA,@PST)", con);
                    cmd.Parameters.AddWithValue("@PD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@PS", PSourceCb.Text);
                    cmd.Parameters.AddWithValue("@PN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@PRN", RecNameTb.Text);
                    cmd.Parameters.AddWithValue("@PSA", PSAddressTb.Text);
                    cmd.Parameters.AddWithValue("@PSP", SPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PRP", RecPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PW", PacWTb.Text);
                    cmd.Parameters.AddWithValue("@PAS", PacSTb.Text);
                    cmd.Parameters.AddWithValue("@PT", PacTypeCb.Text);
                    cmd.Parameters.AddWithValue("@PA", Agentlbl.Text);
                    cmd.Parameters.AddWithValue("@PST", StatusCb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Recoded!!!");
                    con.Close();
                    ShowParcel();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void SendIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSenderName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || PDate.Text == "" || PSourceCb.Text == "" || RecNameTb.Text == "" || SPhoneTb.Text == "" || RecPhoneTb.Text == "" || PSAddressTb.Text == "" || PacTypeCb.Text == "" || StatusCb.Text == "" || PacWTb.Text == "" || PacSTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update ParcelTbl set PDate=@PD,PSource=@PS,PSName=@PN,PRName=@PRN,PSAdd=@PSA,PSPhone=@PSP,PRPhone=@PRP,PackW=@PW,PackSize=@PAS,PType=@PT,PAgent=@PA,PStatus=@PST where PNum=@Pkey", con);
                    cmd.Parameters.AddWithValue("@PD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@PS", PSourceCb.Text);
                    cmd.Parameters.AddWithValue("@PN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@PRN", RecNameTb.Text);
                    cmd.Parameters.AddWithValue("@PSA", PSAddressTb.Text);
                    cmd.Parameters.AddWithValue("@PSP", SPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PRP", RecPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PW", PacWTb.Text);
                    cmd.Parameters.AddWithValue("@PAS", PacSTb.Text);
                    cmd.Parameters.AddWithValue("@PT", PacTypeCb.Text);
                    cmd.Parameters.AddWithValue("@PA", Agentlbl.Text);
                    cmd.Parameters.AddWithValue("@PST", StatusCb.Text);
                    cmd.Parameters.AddWithValue("@Pkey",key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated!!!");
                    con.Close();
                    ShowParcel();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void ParcelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PDate.Text = ParcelDGV.SelectedRows[0].Cells[1].Value.ToString();
            PSourceCb.Text = ParcelDGV.SelectedRows[0].Cells[2].Value.ToString();
            SNameTb.Text = ParcelDGV.SelectedRows[0].Cells[3].Value.ToString();
            RecNameTb.Text = ParcelDGV.SelectedRows[0].Cells[4].Value.ToString();
            PSAddressTb.Text = ParcelDGV.SelectedRows[0].Cells[5].Value.ToString();
            SPhoneTb.Text = ParcelDGV.SelectedRows[0].Cells[6].Value.ToString();
            RecPhoneTb.Text = ParcelDGV.SelectedRows[0].Cells[7].Value.ToString();
            PacWTb.Text = ParcelDGV.SelectedRows[0].Cells[8].Value.ToString();
            PacSTb.Text = ParcelDGV.SelectedRows[0].Cells[9].Value.ToString();
            PacTypeCb.Text = ParcelDGV.SelectedRows[0].Cells[10].Value.ToString();
           // Agentlbl.Text = ParcelDGV.SelectedRows[0].Cells[11].Value.ToString();
            StatusCb.Text = ParcelDGV.SelectedRows[0].Cells[12].Value.ToString();

            if (SNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ParcelDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select A Data");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ParcelTbl where PNum=@Pkey", con);
                    cmd.Parameters.AddWithValue("@Pkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted!!!");
                    con.Close();
                    ShowParcel();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Agentlbl_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
    }
}
