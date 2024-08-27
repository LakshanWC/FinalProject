namespace FinalProject.MVC.View
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_generate_pass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_employee_type = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_eno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nic_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_tel_no = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_salary = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_ot_hours = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ot_hours)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_add.Location = new System.Drawing.Point(479, 392);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 57);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_clear.Location = new System.Drawing.Point(350, 392);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 57);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_generate_pass
            // 
            this.btn_generate_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_generate_pass.FlatAppearance.BorderSize = 0;
            this.btn_generate_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_generate_pass.Location = new System.Drawing.Point(350, 327);
            this.btn_generate_pass.Name = "btn_generate_pass";
            this.btn_generate_pass.Size = new System.Drawing.Size(242, 59);
            this.btn_generate_pass.TabIndex = 20;
            this.btn_generate_pass.Text = "Generate Password";
            this.btn_generate_pass.UseVisualStyleBackColor = false;
            this.btn_generate_pass.Click += new System.EventHandler(this.btn_generate_pass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.cmb_employee_type);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtp_date_of_birth);
            this.panel1.Controls.Add(this.txt_eno);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_nic_no);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.txt_tel_no);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 409);
            this.panel1.TabIndex = 23;
            // 
            // cmb_employee_type
            // 
            this.cmb_employee_type.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_employee_type.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_employee_type.FormattingEnabled = true;
            this.cmb_employee_type.Items.AddRange(new object[] {
            "Select Type ...",
            "Manager",
            "Chef",
            "Cashier",
            "Delivery",
            "Sales & Finance",
            "Waiter",
            "Supplier"});
            this.cmb_employee_type.Location = new System.Drawing.Point(127, 86);
            this.cmb_employee_type.Name = "cmb_employee_type";
            this.cmb_employee_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_employee_type.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(23, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Employee Type :";
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_date_of_birth.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(125, 212);
            this.dtp_date_of_birth.Name = "dtp_date_of_birth";
            this.dtp_date_of_birth.Size = new System.Drawing.Size(116, 20);
            this.dtp_date_of_birth.TabIndex = 39;
            // 
            // txt_eno
            // 
            this.txt_eno.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_eno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_eno.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_eno.Location = new System.Drawing.Point(127, 46);
            this.txt_eno.Name = "txt_eno";
            this.txt_eno.ReadOnly = true;
            this.txt_eno.Size = new System.Drawing.Size(117, 20);
            this.txt_eno.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(23, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Eno :";
            // 
            // txt_nic_no
            // 
            this.txt_nic_no.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_nic_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nic_no.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_nic_no.Location = new System.Drawing.Point(126, 166);
            this.txt_nic_no.Name = "txt_nic_no";
            this.txt_nic_no.Size = new System.Drawing.Size(117, 20);
            this.txt_nic_no.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(21, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = " NIC No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(21, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(20, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(20, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tel No :";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_name.Location = new System.Drawing.Point(127, 128);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(116, 20);
            this.txt_name.TabIndex = 33;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_address.Location = new System.Drawing.Point(125, 305);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(175, 95);
            this.txt_address.TabIndex = 35;
            // 
            // txt_tel_no
            // 
            this.txt_tel_no.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_tel_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tel_no.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_tel_no.Location = new System.Drawing.Point(126, 256);
            this.txt_tel_no.Name = "txt_tel_no";
            this.txt_tel_no.Size = new System.Drawing.Size(116, 20);
            this.txt_tel_no.TabIndex = 36;
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user_name.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_user_name.Location = new System.Drawing.Point(112, 40);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(100, 20);
            this.txt_user_name.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label12.Location = new System.Drawing.Point(40, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "User Name :";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_password.Location = new System.Drawing.Point(112, 82);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(40, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Password :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.txt_user_name);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Location = new System.Drawing.Point(350, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 149);
            this.panel2.TabIndex = 46;
            // 
            // nud_salary
            // 
            this.nud_salary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nud_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_salary.DecimalPlaces = 2;
            this.nud_salary.ForeColor = System.Drawing.SystemColors.Info;
            this.nud_salary.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nud_salary.Location = new System.Drawing.Point(116, 25);
            this.nud_salary.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_salary.Name = "nud_salary";
            this.nud_salary.Size = new System.Drawing.Size(100, 20);
            this.nud_salary.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(35, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Salary :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(35, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "OT Hours :";
            // 
            // nud_ot_hours
            // 
            this.nud_ot_hours.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nud_ot_hours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_ot_hours.DecimalPlaces = 2;
            this.nud_ot_hours.ForeColor = System.Drawing.SystemColors.Info;
            this.nud_ot_hours.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nud_ot_hours.Location = new System.Drawing.Point(116, 76);
            this.nud_ot_hours.Name = "nud_ot_hours";
            this.nud_ot_hours.Size = new System.Drawing.Size(79, 20);
            this.nud_ot_hours.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.nud_salary);
            this.panel3.Controls.Add(this.nud_ot_hours);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(350, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 121);
            this.panel3.TabIndex = 50;
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label6);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(600, 34);
            this.pnl_title.TabIndex = 51;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(570, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Add Employee";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(600, 458);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_generate_pass);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEmployee_FormClosed);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ot_hours)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_generate_pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_employee_type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_date_of_birth;
        private System.Windows.Forms.TextBox txt_eno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nic_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_tel_no;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nud_salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_ot_hours;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_close;
    }
}