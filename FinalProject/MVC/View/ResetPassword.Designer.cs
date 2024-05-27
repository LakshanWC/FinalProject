namespace FinalProject.MVC.View
{
    partial class ResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.txt_re_password = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_pass_request = new System.Windows.Forms.Button();
            this.chk_view_new_pass = new System.Windows.Forms.CheckBox();
            this.chk_view_re_pass = new System.Windows.Forms.CheckBox();
            this.btn_go_to_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Retype Passowrd :";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(147, 146);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(115, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(147, 196);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(115, 20);
            this.txt_new_password.TabIndex = 4;
            this.txt_new_password.UseSystemPasswordChar = true;
            // 
            // txt_re_password
            // 
            this.txt_re_password.Location = new System.Drawing.Point(147, 260);
            this.txt_re_password.Name = "txt_re_password";
            this.txt_re_password.Size = new System.Drawing.Size(115, 20);
            this.txt_re_password.TabIndex = 5;
            this.txt_re_password.UseSystemPasswordChar = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(40, 323);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_pass_request
            // 
            this.btn_pass_request.Location = new System.Drawing.Point(228, 323);
            this.btn_pass_request.Name = "btn_pass_request";
            this.btn_pass_request.Size = new System.Drawing.Size(91, 23);
            this.btn_pass_request.TabIndex = 7;
            this.btn_pass_request.Text = "Send Request";
            this.btn_pass_request.UseVisualStyleBackColor = true;
            this.btn_pass_request.Click += new System.EventHandler(this.btn_pass_request_Click);
            // 
            // chk_view_new_pass
            // 
            this.chk_view_new_pass.AutoSize = true;
            this.chk_view_new_pass.Location = new System.Drawing.Point(271, 199);
            this.chk_view_new_pass.Name = "chk_view_new_pass";
            this.chk_view_new_pass.Size = new System.Drawing.Size(48, 17);
            this.chk_view_new_pass.TabIndex = 8;
            this.chk_view_new_pass.Text = "view";
            this.chk_view_new_pass.UseVisualStyleBackColor = true;
            this.chk_view_new_pass.CheckedChanged += new System.EventHandler(this.chk_view_new_pass_CheckedChanged);
            // 
            // chk_view_re_pass
            // 
            this.chk_view_re_pass.AutoSize = true;
            this.chk_view_re_pass.Location = new System.Drawing.Point(268, 263);
            this.chk_view_re_pass.Name = "chk_view_re_pass";
            this.chk_view_re_pass.Size = new System.Drawing.Size(48, 17);
            this.chk_view_re_pass.TabIndex = 9;
            this.chk_view_re_pass.Text = "view";
            this.chk_view_re_pass.UseVisualStyleBackColor = true;
            this.chk_view_re_pass.CheckedChanged += new System.EventHandler(this.chk_view_re_pass_CheckedChanged);
            // 
            // btn_go_to_login
            // 
            this.btn_go_to_login.Location = new System.Drawing.Point(134, 323);
            this.btn_go_to_login.Name = "btn_go_to_login";
            this.btn_go_to_login.Size = new System.Drawing.Size(75, 23);
            this.btn_go_to_login.TabIndex = 10;
            this.btn_go_to_login.Text = "Go To Login";
            this.btn_go_to_login.UseVisualStyleBackColor = true;
            this.btn_go_to_login.Click += new System.EventHandler(this.btn_go_to_login_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 386);
            this.Controls.Add(this.btn_go_to_login);
            this.Controls.Add(this.chk_view_re_pass);
            this.Controls.Add(this.chk_view_new_pass);
            this.Controls.Add(this.btn_pass_request);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_re_password);
            this.Controls.Add(this.txt_new_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.TextBox txt_re_password;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_pass_request;
        private System.Windows.Forms.CheckBox chk_view_new_pass;
        private System.Windows.Forms.CheckBox chk_view_re_pass;
        private System.Windows.Forms.Button btn_go_to_login;
    }
}