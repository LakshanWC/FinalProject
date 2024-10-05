namespace FinalProject.three_tier_architecture.PL
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_tel_no = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(40, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Password :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(40, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "User Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.txt_user_name);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Location = new System.Drawing.Point(343, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 149);
            this.panel2.TabIndex = 56;
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
            // cmb_employee_type
            // 
            this.cmb_employee_type.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_employee_type.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_employee_type.FormattingEnabled = true;
            this.cmb_employee_type.Items.AddRange(new object[] {
            "Select Type ...",
            "Customer",
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
            this.cmb_employee_type.SelectedIndexChanged += new System.EventHandler(this.cmb_employee_type_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(23, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Type :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_date_of_birth.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(125, 222);
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
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
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
            this.txt_nic_no.Location = new System.Drawing.Point(126, 158);
            this.txt_nic_no.Name = "txt_nic_no";
            this.txt_nic_no.Size = new System.Drawing.Size(117, 20);
            this.txt_nic_no.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(21, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = " NIC No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Register";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(20, 273);
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
            this.txt_name.Location = new System.Drawing.Point(127, 120);
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
            this.txt_tel_no.Location = new System.Drawing.Point(126, 266);
            this.txt_tel_no.Name = "txt_tel_no";
            this.txt_tel_no.Size = new System.Drawing.Size(116, 20);
            this.txt_tel_no.TabIndex = 36;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.lbl_email);
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
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 409);
            this.panel1.TabIndex = 55;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_email.Location = new System.Drawing.Point(124, 190);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(117, 20);
            this.txt_email.TabIndex = 43;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.lbl_email.Location = new System.Drawing.Point(19, 197);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 42;
            this.lbl_email.Text = "Email :";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_clear.Location = new System.Drawing.Point(345, 383);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 57);
            this.btn_clear.TabIndex = 53;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_add.Location = new System.Drawing.Point(474, 383);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 57);
            this.btn_add.TabIndex = 52;
            this.btn_add.Text = "Register";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label6);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(602, 34);
            this.pnl_title.TabIndex = 58;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_password;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_tel_no;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
    }
}