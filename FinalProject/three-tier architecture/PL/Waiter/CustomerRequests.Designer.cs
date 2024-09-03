namespace FinalProject.three_tier_architecture.PL.Waiter
{
    partial class CustomerRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRequests));
            this.btn_pervios = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_request_type = new System.Windows.Forms.ComboBox();
            this.txt_tableNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pervios
            // 
            this.btn_pervios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_pervios.FlatAppearance.BorderSize = 0;
            this.btn_pervios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pervios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pervios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_pervios.Location = new System.Drawing.Point(299, 380);
            this.btn_pervios.Name = "btn_pervios";
            this.btn_pervios.Size = new System.Drawing.Size(75, 36);
            this.btn_pervios.TabIndex = 70;
            this.btn_pervios.Text = "Pervious";
            this.btn_pervios.UseVisualStyleBackColor = false;
            this.btn_pervios.Click += new System.EventHandler(this.btn_pervios_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_next.Location = new System.Drawing.Point(390, 380);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 36);
            this.btn_next.TabIndex = 69;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.cmb_request_type);
            this.panel1.Controls.Add(this.txt_tableNO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 319);
            this.panel1.TabIndex = 68;
            // 
            // cmb_request_type
            // 
            this.cmb_request_type.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_request_type.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_request_type.FormattingEnabled = true;
            this.cmb_request_type.Items.AddRange(new object[] {
            "--Select---",
            "Order Assistance",
            "Dietary Requests",
            "Accessibility Needs",
            "Complaint"});
            this.cmb_request_type.Location = new System.Drawing.Point(126, 70);
            this.cmb_request_type.Name = "cmb_request_type";
            this.cmb_request_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_request_type.TabIndex = 68;
            this.cmb_request_type.SelectedIndexChanged += new System.EventHandler(this.cmb_request_type_SelectedIndexChanged);
            // 
            // txt_tableNO
            // 
            this.txt_tableNO.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_tableNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tableNO.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_tableNO.Location = new System.Drawing.Point(126, 23);
            this.txt_tableNO.Name = "txt_tableNO";
            this.txt_tableNO.ReadOnly = true;
            this.txt_tableNO.Size = new System.Drawing.Size(102, 20);
            this.txt_tableNO.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Descrpition :";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_description.Location = new System.Drawing.Point(126, 116);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(301, 138);
            this.txt_description.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Table No :";
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label14);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(478, 34);
            this.pnl_title.TabIndex = 71;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(442, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Customer Requests";
            // 
            // CustomerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(478, 432);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.btn_pervios);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerRequests";
            this.Text = "CustomerRequests";
            this.Load += new System.EventHandler(this.CustomerRequests_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pervios;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tableNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_request_type;
    }
}