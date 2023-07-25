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
    public partial class MoneyTrans : Form
    {
        public MoneyTrans()
        {
            InitializeComponent();
            ShowMoney();
            Agentlbl.Text=Login.AName;
            Datelbl.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
            TransDGV.EnableHeadersVisualStyles = false;
            TransDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            TransDGV.Columns["TrNum"].HeaderText = "No";
            TransDGV.Columns["TDate"].HeaderText = "Transaction_Date";
            TransDGV.Columns["SName"].HeaderText = "Sender_Name";
            TransDGV.Columns["RName"].HeaderText = "Receiver_Name";
            TransDGV.Columns["SAdd"].HeaderText = "Sender_Address";
            TransDGV.Columns["SPhone"].HeaderText = "Sender_Phone_no";
            TransDGV.Columns["RPhone"].HeaderText = "Receiver_Phone_no";
            TransDGV.Columns["TrCode"].HeaderText = "Secret_Code";
            TransDGV.Columns["Amt"].HeaderText = "Amount";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowMoney()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MoneyTr", con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TransDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\COLLAGE\post_office_project\PostOffice\PostOffice\PostofficeDb.mdf;Integrated Security=True;User Instance=True");

        private void Reset()
        {
              SNameTb.Text="";
              TrDate.Text="";
              RNameTb.Text="";
              RAddressTb.Text="";
              SAddressTb.Text="";
              SPhoneTb.Text="";
              RPhoneTb.Text="";
              PincodeTb.Text="";
              AmTb.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || TrDate.Text == "" || RNameTb.Text == "" || RAddressTb.Text == "" || SAddressTb.Text == "" || SPhoneTb.Text == "" || RPhoneTb.Text == "" || PincodeTb.Text == "" || AmTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MoneyTr(TDate,SName,RName,SAdd,SPhone,Rphone,TrCode,Amt)Values(@TD,@SN,@RN,@SA,@SP,@RP,@TC,@AT)", con);
                    cmd.Parameters.AddWithValue("@TD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@SN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@SA", SAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TC", PincodeTb.Text);
                    cmd.Parameters.AddWithValue("@AT", AmTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Recoded!!!");
                    con.Close();
                    ShowMoney();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void TransDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            TrDate.Text = TransDGV.SelectedRows[0].Cells[1].Value.ToString();
            SNameTb.Text = TransDGV.SelectedRows[0].Cells[2].Value.ToString();
            RNameTb.Text = TransDGV.SelectedRows[0].Cells[3].Value.ToString();
            SAddressTb.Text = TransDGV.SelectedRows[0].Cells[4].Value.ToString();
            SPhoneTb.Text = TransDGV.SelectedRows[0].Cells[5].Value.ToString();
            RPhoneTb.Text = TransDGV.SelectedRows[0].Cells[6].Value.ToString();
            PincodeTb.Text = TransDGV.SelectedRows[0].Cells[7].Value.ToString();
            AmTb.Text = TransDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (SNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TransDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || TrDate.Text == "" || RNameTb.Text == "" || SAddressTb.Text == "" || SPhoneTb.Text == "" || RPhoneTb.Text == "" || PincodeTb.Text == "" || AmTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update MoneyTr set TDate=@TD,SName=@SN,RName=@RN,SAdd=@SA,SPhone=@SP,Rphone=@RP,TrCode=@TC,Amt=@AT where TrNum=@Tkey", con);
                    cmd.Parameters.AddWithValue("@TD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@SN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@SA", SAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TC", PincodeTb.Text);
                    cmd.Parameters.AddWithValue("@AT", AmTb.Text);
                    cmd.Parameters.AddWithValue("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Updated!!!");
                    con.Close();
                    ShowMoney();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select A Transaction");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from MoneyTr where TrNum=@Tkey", con);
                    cmd.Parameters.AddWithValue("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Traansaction Deleted!!!");
                    con.Close();
                    ShowMoney();
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
