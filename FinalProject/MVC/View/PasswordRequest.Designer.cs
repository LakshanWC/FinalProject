namespace FinalProject.MVC.View
{
    partial class PasswordRequest
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
            this.dgv_pass_requests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_no_of_checked_box = new System.Windows.Forms.TextBox();
            this.chbx_check_all = new System.Windows.Forms.CheckBox();
            this.btn_enable = new System.Windows.Forms.Button();
            this.btn_return_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pass_requests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pass_requests
            // 
            this.dgv_pass_requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pass_requests.Location = new System.Drawing.Point(15, 23);
            this.dgv_pass_requests.Name = "dgv_pass_requests";
            this.dgv_pass_requests.Size = new System.Drawing.Size(339, 258);
            this.dgv_pass_requests.TabIndex = 0;
            this.dgv_pass_requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pass_requests_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checked Checkboxes :";
            // 
            // txt_no_of_checked_box
            // 
            this.txt_no_of_checked_box.Location = new System.Drawing.Point(136, 318);
            this.txt_no_of_checked_box.Name = "txt_no_of_checked_box";
            this.txt_no_of_checked_box.ReadOnly = true;
            this.txt_no_of_checked_box.Size = new System.Drawing.Size(100, 20);
            this.txt_no_of_checked_box.TabIndex = 2;
            // 
            // chbx_check_all
            // 
            this.chbx_check_all.AutoSize = true;
            this.chbx_check_all.Location = new System.Drawing.Point(270, 318);
            this.chbx_check_all.Name = "chbx_check_all";
            this.chbx_check_all.Size = new System.Drawing.Size(71, 17);
            this.chbx_check_all.TabIndex = 3;
            this.chbx_check_all.Text = "Check All";
            this.chbx_check_all.UseVisualStyleBackColor = true;
            this.chbx_check_all.CheckedChanged += new System.EventHandler(this.chbx_check_all_CheckedChanged);
            // 
            // btn_enable
            // 
            this.btn_enable.Location = new System.Drawing.Point(270, 393);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(75, 23);
            this.btn_enable.TabIndex = 4;
            this.btn_enable.Text = "Enable";
            this.btn_enable.UseVisualStyleBackColor = true;
            // 
            // btn_return_home
            // 
            this.btn_return_home.Location = new System.Drawing.Point(136, 393);
            this.btn_return_home.Name = "btn_return_home";
            this.btn_return_home.Size = new System.Drawing.Size(90, 23);
            this.btn_return_home.TabIndex = 5;
            this.btn_return_home.Text = "Return to Home";
            this.btn_return_home.UseVisualStyleBackColor = true;
            this.btn_return_home.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasswordRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btn_return_home);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.chbx_check_all);
            this.Controls.Add(this.txt_no_of_checked_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pass_requests);
            this.Name = "PasswordRequest";
            this.Text = "PasswordRequest";
            this.Load += new System.EventHandler(this.PasswordRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pass_requests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pass_requests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_no_of_checked_box;
        private System.Windows.Forms.CheckBox chbx_check_all;
        private System.Windows.Forms.Button btn_enable;
        private System.Windows.Forms.Button btn_return_home;
    }
}