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
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lnklbl_reset_pass = new System.Windows.Forms.LinkLabel();
            this.chk_view = new System.Windows.Forms.CheckBox();
            this.pb_logo_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(155, 325);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(79, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(129, 228);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(129, 20);
            this.txt_userName.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(129, 280);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(129, 20);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lnklbl_reset_pass
            // 
            this.lnklbl_reset_pass.AutoSize = true;
            this.lnklbl_reset_pass.Location = new System.Drawing.Point(109, 377);
            this.lnklbl_reset_pass.Name = "lnklbl_reset_pass";
            this.lnklbl_reset_pass.Size = new System.Drawing.Size(184, 13);
            this.lnklbl_reset_pass.TabIndex = 6;
            this.lnklbl_reset_pass.TabStop = true;
            this.lnklbl_reset_pass.Text = "forgot your passowrd ? Click to reset !";
            this.lnklbl_reset_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_reset_pass_LinkClicked);
            // 
            // chk_view
            // 
            this.chk_view.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_view.AutoSize = true;
            this.chk_view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chk_view.BackgroundImage")));
            this.chk_view.Location = new System.Drawing.Point(268, 277);
            this.chk_view.MinimumSize = new System.Drawing.Size(26, 25);
            this.chk_view.Name = "chk_view";
            this.chk_view.Size = new System.Drawing.Size(26, 25);
            this.chk_view.TabIndex = 7;
            this.chk_view.UseVisualStyleBackColor = true;
            this.chk_view.CheckedChanged += new System.EventHandler(this.chk_view_CheckedChanged);
            // 
            // pb_logo_icon
            // 
            this.pb_logo_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_logo_icon.BackgroundImage")));
            this.pb_logo_icon.Location = new System.Drawing.Point(44, 23);
            this.pb_logo_icon.Name = "pb_logo_icon";
            this.pb_logo_icon.Size = new System.Drawing.Size(229, 169);
            this.pb_logo_icon.TabIndex = 8;
            this.pb_logo_icon.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 408);
            this.Controls.Add(this.pb_logo_icon);
            this.Controls.Add(this.chk_view);
            this.Controls.Add(this.lnklbl_reset_pass);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.LinkLabel lnklbl_reset_pass;
        private System.Windows.Forms.CheckBox chk_view;
        private System.Windows.Forms.PictureBox pb_logo_icon;
    }
}