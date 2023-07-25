namespace PostOffice
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.RPhoneTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DelDGV = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DelDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Agentlbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AgNameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AgNumCb = new System.Windows.Forms.ComboBox();
            this.ParNumCb = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ReNameTb = new System.Windows.Forms.TextBox();
            this.FessTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RPhoneTb
            // 
            this.RPhoneTb.Location = new System.Drawing.Point(393, 127);
            this.RPhoneTb.Name = "RPhoneTb";
            this.RPhoneTb.Size = new System.Drawing.Size(152, 22);
            this.RPhoneTb.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Receiver Phone";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DelDGV);
            this.panel4.Location = new System.Drawing.Point(133, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1133, 347);
            this.panel4.TabIndex = 15;
            // 
            // DelDGV
            // 
            this.DelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DelDGV.BackgroundColor = System.Drawing.Color.Lavender;
            this.DelDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DelDGV.Location = new System.Drawing.Point(3, 0);
            this.DelDGV.Name = "DelDGV";
            this.DelDGV.RowTemplate.Height = 24;
            this.DelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DelDGV.Size = new System.Drawing.Size(1127, 347);
            this.DelDGV.TabIndex = 2;
            this.DelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DelDGV_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(633, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Manage Delivery";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Agent Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(206, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Parcel Number";
            // 
            // DelDate
            // 
            this.DelDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DelDate.Location = new System.Drawing.Point(31, 125);
            this.DelDate.Name = "DelDate";
            this.DelDate.Size = new System.Drawing.Size(152, 22);
            this.DelDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Delivery Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agent Name";
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
            this.panel1.TabIndex = 11;
            // 
            // Agentlbl
            // 
            this.Agentlbl.AutoSize = true;
            this.Agentlbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Agentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agentlbl.ForeColor = System.Drawing.Color.Gold;
            this.Agentlbl.Location = new System.Drawing.Point(1284, 60);
            this.Agentlbl.Name = "Agentlbl";
            this.Agentlbl.Size = new System.Drawing.Size(120, 24);
            this.Agentlbl.TabIndex = 7;
            this.Agentlbl.Text = "AgentName";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(149, 82);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(58, 24);
            this.Datelbl.TabIndex = 5;
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
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(775, 120);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 36);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Receiver Name";
            // 
            // AgNameTb
            // 
            this.AgNameTb.Enabled = false;
            this.AgNameTb.Location = new System.Drawing.Point(210, 57);
            this.AgNameTb.Name = "AgNameTb";
            this.AgNameTb.Size = new System.Drawing.Size(152, 22);
            this.AgNameTb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fess in rs";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.AgNumCb);
            this.panel3.Controls.Add(this.ParNumCb);
            this.panel3.Controls.Add(this.RPhoneTb);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.Delete);
            this.panel3.Controls.Add(this.Edit);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ReNameTb);
            this.panel3.Controls.Add(this.FessTb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.DelDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.AgNameTb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(224, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 184);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // AgNumCb
            // 
            this.AgNumCb.FormattingEnabled = true;
            this.AgNumCb.Location = new System.Drawing.Point(31, 57);
            this.AgNumCb.Name = "AgNumCb";
            this.AgNumCb.Size = new System.Drawing.Size(145, 24);
            this.AgNumCb.TabIndex = 24;
            this.AgNumCb.SelectionChangeCommitted += new System.EventHandler(this.AgNumCb_SelectionChangeCommitted);
            // 
            // ParNumCb
            // 
            this.ParNumCb.FormattingEnabled = true;
            this.ParNumCb.Location = new System.Drawing.Point(210, 125);
            this.ParNumCb.Name = "ParNumCb";
            this.ParNumCb.Size = new System.Drawing.Size(145, 24);
            this.ParNumCb.TabIndex = 23;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(775, 73);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 36);
            this.Edit.TabIndex = 13;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(775, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(909, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 38);
            this.label10.TabIndex = 4;
            this.label10.Text = "<";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ReNameTb
            // 
            this.ReNameTb.Location = new System.Drawing.Point(393, 59);
            this.ReNameTb.Name = "ReNameTb";
            this.ReNameTb.Size = new System.Drawing.Size(152, 22);
            this.ReNameTb.TabIndex = 7;
            // 
            // FessTb
            // 
            this.FessTb.Location = new System.Drawing.Point(576, 57);
            this.FessTb.Name = "FessTb";
            this.FessTb.Size = new System.Drawing.Size(152, 22);
            this.FessTb.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 768);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 33);
            this.panel2.TabIndex = 12;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 802);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DelDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RPhoneTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DelDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Agentlbl;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgNameTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ReNameTb;
        private System.Windows.Forms.TextBox FessTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox AgNumCb;
        private System.Windows.Forms.ComboBox ParNumCb;
        private System.Windows.Forms.DataGridView DelDGV;
    }
}