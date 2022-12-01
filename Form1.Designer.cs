namespace project
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.EmpPosCb = new System.Windows.Forms.ComboBox();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.EmpPhoneTb = new System.Windows.Forms.TextBox();
            this.EmpAddTb = new System.Windows.Forms.TextBox();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.EmpIdTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.EmpPosCb);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.EmpGenCb);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.EmpAddTb);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 628);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpDob
            // 
            this.EmpDob.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDob.Location = new System.Drawing.Point(75, 574);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.Size = new System.Drawing.Size(274, 27);
            this.EmpDob.TabIndex = 15;
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPosCb.FormattingEnabled = true;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Assistant Manager",
            "HouseKeeper",
            "Mazintenance",
            "Chef",
            "Receptionist",
            "Accountant",
            "HR"});
            this.EmpPosCb.Location = new System.Drawing.Point(75, 496);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(180, 24);
            this.EmpPosCb.TabIndex = 14;
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "AUC",
            "GUC",
            "BUE",
            "MIU",
            "MSA",
            "MUST",
            "KFS"});
            this.EmpEduCb.Location = new System.Drawing.Point(75, 419);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(180, 24);
            this.EmpEduCb.TabIndex = 13;
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.EmpGenCb.Location = new System.Drawing.Point(75, 261);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(180, 24);
            this.EmpGenCb.TabIndex = 12;
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhoneTb.Location = new System.Drawing.Point(75, 341);
            this.EmpPhoneTb.Multiline = true;
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(180, 26);
            this.EmpPhoneTb.TabIndex = 11;
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAddTb.Location = new System.Drawing.Point(75, 180);
            this.EmpAddTb.Multiline = true;
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.Size = new System.Drawing.Size(180, 27);
            this.EmpAddTb.TabIndex = 10;
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTb.Location = new System.Drawing.Point(75, 102);
            this.EmpNameTb.Multiline = true;
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(180, 26);
            this.EmpNameTb.TabIndex = 9;
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTb.Location = new System.Drawing.Point(75, 31);
            this.EmpIdTb.Multiline = true;
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(180, 27);
            this.EmpIdTb.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employee Education :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee DOB :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Position :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 80);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(679, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 80);
            this.button2.TabIndex = 18;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(884, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 80);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmpDGV
            // 
            this.EmpDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.Location = new System.Drawing.Point(366, 0);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.Size = new System.Drawing.Size(699, 478);
            this.EmpDGV.TabIndex = 20;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1063, 749);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker EmpDob;
        private System.Windows.Forms.ComboBox EmpPosCb;
        private System.Windows.Forms.ComboBox EmpEduCb;
        private System.Windows.Forms.ComboBox EmpGenCb;
        private System.Windows.Forms.TextBox EmpPhoneTb;
        private System.Windows.Forms.TextBox EmpAddTb;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.TextBox EmpIdTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

