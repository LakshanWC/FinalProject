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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRequest));
            this.dgv_pass_requests = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_no_of_checked_box = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_enable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pass_requests)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pass_requests
            // 
            this.dgv_pass_requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pass_requests.Location = new System.Drawing.Point(15, 59);
            this.dgv_pass_requests.Name = "dgv_pass_requests";
            this.dgv_pass_requests.Size = new System.Drawing.Size(339, 258);
            this.dgv_pass_requests.TabIndex = 0;
            this.dgv_pass_requests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pass_requests_CellClick);
            this.dgv_pass_requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pass_requests_CellContentClick);
            this.dgv_pass_requests.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pass_requests_CellValueChanged);
            this.dgv_pass_requests.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_pass_requests_CurrentCellDirtyStateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Password requests";
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label6);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(363, 34);
            this.pnl_title.TabIndex = 52;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(329, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_no_of_checked_box);
            this.panel1.Location = new System.Drawing.Point(15, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 64);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Selected User";
            // 
            // txt_no_of_checked_box
            // 
            this.txt_no_of_checked_box.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_no_of_checked_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_no_of_checked_box.Location = new System.Drawing.Point(132, 22);
            this.txt_no_of_checked_box.Name = "txt_no_of_checked_box";
            this.txt_no_of_checked_box.ReadOnly = true;
            this.txt_no_of_checked_box.Size = new System.Drawing.Size(153, 20);
            this.txt_no_of_checked_box.TabIndex = 55;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btn_refresh.Location = new System.Drawing.Point(150, 424);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(90, 41);
            this.btn_refresh.TabIndex = 59;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click_1);
            // 
            // btn_enable
            // 
            this.btn_enable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_enable.Location = new System.Drawing.Point(259, 424);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(86, 41);
            this.btn_enable.TabIndex = 57;
            this.btn_enable.Text = "Enable";
            this.btn_enable.UseVisualStyleBackColor = false;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click_1);
            // 
            // PasswordRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(363, 477);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.dgv_pass_requests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRequest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordRequest_FormClosed);
            this.Load += new System.EventHandler(this.PasswordRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pass_requests)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_pass_requests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_no_of_checked_box;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_enable;
    }
}