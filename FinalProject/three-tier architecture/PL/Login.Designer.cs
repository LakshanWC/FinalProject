namespace FinalProject.MVC.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.chk_view = new System.Windows.Forms.CheckBox();
            this.lnklbl_reset_pass = new System.Windows.Forms.LinkLabel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.chk_view);
            this.panel1.Controls.Add(this.lnklbl_reset_pass);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_userName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Location = new System.Drawing.Point(21, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 198);
            this.panel1.TabIndex = 9;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(109, 119);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(79, 23);
            this.btn_register.TabIndex = 17;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // chk_view
            // 
            this.chk_view.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_view.AutoSize = true;
            this.chk_view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chk_view.BackgroundImage")));
            this.chk_view.Location = new System.Drawing.Point(248, 67);
            this.chk_view.MinimumSize = new System.Drawing.Size(26, 25);
            this.chk_view.Name = "chk_view";
            this.chk_view.Size = new System.Drawing.Size(26, 25);
            this.chk_view.TabIndex = 16;
            this.chk_view.UseVisualStyleBackColor = true;
            // 
            // lnklbl_reset_pass
            // 
            this.lnklbl_reset_pass.AutoSize = true;
            this.lnklbl_reset_pass.Location = new System.Drawing.Point(89, 167);
            this.lnklbl_reset_pass.Name = "lnklbl_reset_pass";
            this.lnklbl_reset_pass.Size = new System.Drawing.Size(184, 13);
            this.lnklbl_reset_pass.TabIndex = 15;
            this.lnklbl_reset_pass.TabStop = true;
            this.lnklbl_reset_pass.Text = "forgot your passowrd ? Click to reset !";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(109, 70);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(129, 20);
            this.txt_Password.TabIndex = 14;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(109, 18);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(129, 20);
            this.txt_userName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name :";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(194, 119);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(79, 23);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(328, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox chk_view;
        private System.Windows.Forms.LinkLabel lnklbl_reset_pass;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
    }
}