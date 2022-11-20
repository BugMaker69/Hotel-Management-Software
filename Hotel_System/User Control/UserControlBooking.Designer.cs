﻿namespace Hotel_System.User_Control
{
    partial class UserControlBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReserv = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comRoom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DGVcust = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabReserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcust)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabReserv);
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabReserv
            // 
            this.tabReserv.Controls.Add(this.maskedTextBox1);
            this.tabReserv.Controls.Add(this.dateOut);
            this.tabReserv.Controls.Add(this.dateIn);
            this.tabReserv.Controls.Add(this.dateTimePicker3);
            this.tabReserv.Controls.Add(this.numericUpDown1);
            this.tabReserv.Controls.Add(this.txtUser);
            this.tabReserv.Controls.Add(this.label14);
            this.tabReserv.Controls.Add(this.label11);
            this.tabReserv.Controls.Add(this.button1);
            this.tabReserv.Controls.Add(this.label10);
            this.tabReserv.Controls.Add(this.label9);
            this.tabReserv.Controls.Add(this.comboBox5);
            this.tabReserv.Controls.Add(this.comRoom);
            this.tabReserv.Controls.Add(this.label8);
            this.tabReserv.Controls.Add(this.label7);
            this.tabReserv.Controls.Add(this.txtCity);
            this.tabReserv.Controls.Add(this.txtAddress);
            this.tabReserv.Controls.Add(this.label6);
            this.tabReserv.Controls.Add(this.label5);
            this.tabReserv.Controls.Add(this.txtEmail);
            this.tabReserv.Controls.Add(this.label4);
            this.tabReserv.Controls.Add(this.comboBox3);
            this.tabReserv.Controls.Add(this.label3);
            this.tabReserv.Controls.Add(this.label2);
            this.tabReserv.Controls.Add(this.txtName);
            this.tabReserv.Controls.Add(this.label12);
            this.tabReserv.Location = new System.Drawing.Point(4, 4);
            this.tabReserv.Name = "tabReserv";
            this.tabReserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserv.Size = new System.Drawing.Size(1079, 618);
            this.tabReserv.TabIndex = 0;
            this.tabReserv.Text = "Reservation";
            this.tabReserv.UseVisualStyleBackColor = true;
            this.tabReserv.Leave += new System.EventHandler(this.tabReserv_Leave);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(29, 293);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(457, 27);
            this.maskedTextBox1.TabIndex = 106;
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(801, 227);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(240, 27);
            this.dateOut.TabIndex = 81;
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(549, 227);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(246, 27);
            this.dateIn.TabIndex = 82;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(29, 119);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker3.TabIndex = 83;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(572, 122);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 27);
            this.numericUpDown1.TabIndex = 105;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(254, 39);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(182, 27);
            this.txtUser.TabIndex = 104;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(254, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 103;
            this.label14.Text = "User Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label11.Location = new System.Drawing.Point(136, -25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 24);
            this.label11.TabIndex = 102;
            this.label11.Text = "Reservation";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(549, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 82);
            this.button1.TabIndex = 101;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(828, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 100;
            this.label10.Text = "Deperture:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(549, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 99;
            this.label9.Text = "Entry Date:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox5.Location = new System.Drawing.Point(807, 74);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(176, 28);
            this.comboBox5.TabIndex = 98;
            // 
            // comRoom
            // 
            this.comRoom.FormattingEnabled = true;
            this.comRoom.Items.AddRange(new object[] {
            "VIP",
            "Family Suite",
            "Standart",
            "Single"});
            this.comRoom.Location = new System.Drawing.Point(572, 74);
            this.comRoom.Name = "comRoom";
            this.comRoom.Size = new System.Drawing.Size(186, 28);
            this.comRoom.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(572, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 23);
            this.label8.TabIndex = 96;
            this.label8.Text = "Choice Of Room:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 95;
            this.label7.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 454);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(232, 27);
            this.txtCity.TabIndex = 94;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(29, 499);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(423, 103);
            this.txtAddress.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 92;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 91;
            this.label5.Text = "E-Mail Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 374);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(457, 27);
            this.txtEmail.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 89;
            this.label4.Text = "Phone Number:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox3.Location = new System.Drawing.Point(29, 207);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(457, 28);
            this.comboBox3.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 87;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 86;
            this.label2.Text = "Birthday:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 27);
            this.txtName.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(29, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 84;
            this.label12.Text = "Name:";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.Search);
            this.tabView.Controls.Add(this.label13);
            this.tabView.Controls.Add(this.DGVcust);
            this.tabView.Location = new System.Drawing.Point(4, 4);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(1079, 618);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "View Customer";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(157, 93);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(298, 27);
            this.Search.TabIndex = 12;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(120, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Search By ID:";
            // 
            // DGVcust
            // 
            this.DGVcust.AllowUserToAddRows = false;
            this.DGVcust.AllowUserToDeleteRows = false;
            this.DGVcust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVcust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.DGVcust.Location = new System.Drawing.Point(66, 145);
            this.DGVcust.Name = "DGVcust";
            this.DGVcust.ReadOnly = true;
            this.DGVcust.RowHeadersWidth = 51;
            this.DGVcust.RowTemplate.Height = 29;
            this.DGVcust.Size = new System.Drawing.Size(905, 442);
            this.DGVcust.TabIndex = 10;
            this.DGVcust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcust_CellClick);
            this.DGVcust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcust_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DataID";
            this.Column1.HeaderText = "User Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DataName";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DataRoom";
            this.Column3.HeaderText = "Room";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DataInDate";
            this.Column4.HeaderText = "Check In Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DataOutDate";
            this.Column5.HeaderText = "Check Out Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DataCost";
            this.Column7.HeaderText = "Total Cost";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UserControlBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlBooking";
            this.Size = new System.Drawing.Size(1087, 651);
            this.tabControl1.ResumeLayout(false);
            this.tabReserv.ResumeLayout(false);
            this.tabReserv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabReserv;
        private TabPage tabView;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateOut;
        private DateTimePicker dateIn;
        private DateTimePicker dateTimePicker3;
        private NumericUpDown numericUpDown1;
        private TextBox txtUser;
        private Label label14;
        private Label label11;
        private Button button1;
        private Label label10;
        private Label label9;
        private ComboBox comboBox5;
        private ComboBox comRoom;
        private Label label8;
        private Label label7;
        private TextBox txtCity;
        private TextBox txtAddress;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private ComboBox comboBox3;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label12;
        private TextBox Search;
        private Label label13;
        private DataGridView DGVcust;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
    }
}
