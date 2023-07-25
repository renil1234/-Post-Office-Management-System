namespace PostOffice
{
    partial class Parcels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parcels));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Agentlbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PSAddressTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RecNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ParcelDGV = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.SNameTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SendIdCb = new System.Windows.Forms.ComboBox();
            this.PSourceCb = new System.Windows.Forms.ComboBox();
            this.PacSTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PacWTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RecPhoneTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SPhoneTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PacTypeCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParcelDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(1120, 135);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 36);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(1120, 88);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 36);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(1120, 42);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 36);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.Agentlbl);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 114);
            this.panel1.TabIndex = 6;
            // 
            // Agentlbl
            // 
            this.Agentlbl.AutoSize = true;
            this.Agentlbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Agentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agentlbl.ForeColor = System.Drawing.Color.Gold;
            this.Agentlbl.Location = new System.Drawing.Point(1281, 56);
            this.Agentlbl.Name = "Agentlbl";
            this.Agentlbl.Size = new System.Drawing.Size(120, 24);
            this.Agentlbl.TabIndex = 9;
            this.Agentlbl.Text = "AgentName";
            this.Agentlbl.Click += new System.EventHandler(this.Agentlbl_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(146, 78);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(58, 24);
            this.Datelbl.TabIndex = 8;
            this.Datelbl.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Post Office Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1380, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1278, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 38);
            this.label10.TabIndex = 4;
            this.label10.Text = "<";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PSAddressTb
            // 
            this.PSAddressTb.Location = new System.Drawing.Point(835, 74);
            this.PSAddressTb.Multiline = true;
            this.PSAddressTb.Name = "PSAddressTb";
            this.PSAddressTb.Size = new System.Drawing.Size(204, 99);
            this.PSAddressTb.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(831, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RecNameTb
            // 
            this.RecNameTb.Location = new System.Drawing.Point(431, 41);
            this.RecNameTb.Name = "RecNameTb";
            this.RecNameTb.Size = new System.Drawing.Size(152, 22);
            this.RecNameTb.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Receiver Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ParcelDGV);
            this.panel4.Location = new System.Drawing.Point(26, 405);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1378, 347);
            this.panel4.TabIndex = 10;
            // 
            // ParcelDGV
            // 
            this.ParcelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ParcelDGV.BackgroundColor = System.Drawing.Color.Lavender;
            this.ParcelDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ParcelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParcelDGV.Location = new System.Drawing.Point(3, 0);
            this.ParcelDGV.Name = "ParcelDGV";
            this.ParcelDGV.RowTemplate.Height = 24;
            this.ParcelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ParcelDGV.Size = new System.Drawing.Size(1372, 347);
            this.ParcelDGV.TabIndex = 2;
            this.ParcelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParcelDGV_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(633, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Manage Parcel";
            // 
            // SNameTb
            // 
            this.SNameTb.Enabled = false;
            this.SNameTb.Location = new System.Drawing.Point(247, 41);
            this.SNameTb.Name = "SNameTb";
            this.SNameTb.Size = new System.Drawing.Size(152, 22);
            this.SNameTb.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.SendIdCb);
            this.panel3.Controls.Add(this.PSourceCb);
            this.panel3.Controls.Add(this.PacSTb);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.PacWTb);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.StatusCb);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.RecPhoneTb);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.SPhoneTb);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.EditBtn);
            this.panel3.Controls.Add(this.SaveBtn);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.PSAddressTb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.RecNameTb);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.SNameTb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.PacTypeCb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.PDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(26, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1375, 208);
            this.panel3.TabIndex = 8;
            // 
            // SendIdCb
            // 
            this.SendIdCb.FormattingEnabled = true;
            this.SendIdCb.Location = new System.Drawing.Point(67, 42);
            this.SendIdCb.Name = "SendIdCb";
            this.SendIdCb.Size = new System.Drawing.Size(151, 24);
            this.SendIdCb.TabIndex = 26;
            this.SendIdCb.SelectionChangeCommitted += new System.EventHandler(this.SendIdCb_SelectionChangeCommitted);
            // 
            // PSourceCb
            // 
            this.PSourceCb.FormattingEnabled = true;
            this.PSourceCb.Items.AddRange(new object[] {
            " Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura"});
            this.PSourceCb.Location = new System.Drawing.Point(68, 176);
            this.PSourceCb.Name = "PSourceCb";
            this.PSourceCb.Size = new System.Drawing.Size(151, 24);
            this.PSourceCb.TabIndex = 25;
            // 
            // PacSTb
            // 
            this.PacSTb.Location = new System.Drawing.Point(641, 167);
            this.PacSTb.Name = "PacSTb";
            this.PacSTb.Size = new System.Drawing.Size(152, 22);
            this.PacSTb.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(637, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 40);
            this.label17.TabIndex = 23;
            this.label17.Text = "Package Size\r\nin Inch";
            // 
            // PacWTb
            // 
            this.PacWTb.Location = new System.Drawing.Point(641, 70);
            this.PacWTb.Name = "PacWTb";
            this.PacWTb.Size = new System.Drawing.Size(152, 22);
            this.PacWTb.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(637, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 40);
            this.label16.TabIndex = 21;
            this.label16.Text = "Package Weight\r\nin Gram";
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Pending",
            "Deliverd"});
            this.StatusCb.Location = new System.Drawing.Point(431, 176);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(152, 24);
            this.StatusCb.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(427, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Status";
            // 
            // RecPhoneTb
            // 
            this.RecPhoneTb.Location = new System.Drawing.Point(431, 111);
            this.RecPhoneTb.Name = "RecPhoneTb";
            this.RecPhoneTb.Size = new System.Drawing.Size(152, 22);
            this.RecPhoneTb.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(427, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Receiver Phone";
            // 
            // SPhoneTb
            // 
            this.SPhoneTb.Location = new System.Drawing.Point(247, 111);
            this.SPhoneTb.Name = "SPhoneTb";
            this.SPhoneTb.Size = new System.Drawing.Size(152, 22);
            this.SPhoneTb.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(243, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Sender Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sender Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Source";
            // 
            // PacTypeCb
            // 
            this.PacTypeCb.FormattingEnabled = true;
            this.PacTypeCb.Items.AddRange(new object[] {
            "Ordinary",
            "Document",
            "Fraglle"});
            this.PacTypeCb.Location = new System.Drawing.Point(248, 176);
            this.PacTypeCb.Name = "PacTypeCb";
            this.PacTypeCb.Size = new System.Drawing.Size(151, 24);
            this.PacTypeCb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // PDate
            // 
            this.PDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PDate.Location = new System.Drawing.Point(67, 101);
            this.PDate.Name = "PDate";
            this.PDate.Size = new System.Drawing.Size(152, 22);
            this.PDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parcel Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sender Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 768);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 33);
            this.panel2.TabIndex = 7;
            // 
            // Parcels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parcels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcels";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParcelDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PSAddressTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RecNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SNameTb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PacTypeCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker PDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RecPhoneTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SPhoneTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PacSTb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PacWTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SendIdCb;
        private System.Windows.Forms.ComboBox PSourceCb;
        private System.Windows.Forms.DataGridView ParcelDGV;
        private System.Windows.Forms.Label Agentlbl;
        private System.Windows.Forms.Label Datelbl;
    }
}