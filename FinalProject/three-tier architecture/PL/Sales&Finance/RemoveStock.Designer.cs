namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    partial class RemoveStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStock));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_stock_names = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stock_name = new System.Windows.Forms.TextBox();
            this.btn_update_details = new System.Windows.Forms.Button();
            this.txt_quntity = new System.Windows.Forms.TextBox();
            this.pnl_title.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label9);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(508, 34);
            this.pnl_title.TabIndex = 55;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(472, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Remove Stock";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel6.Controls.Add(this.txt_quntity);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cmb_status);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cmb_stock_names);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_stock_name);
            this.panel6.Location = new System.Drawing.Point(8, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 173);
            this.panel6.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(91, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Status :";
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_status.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Awaiting Restock",
            "Out of Stock",
            "Low Stock",
            "In Stock"});
            this.cmb_status.Location = new System.Drawing.Point(146, 137);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 21);
            this.cmb_status.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Existing Stock Types  : ";
            // 
            // cmb_stock_names
            // 
            this.cmb_stock_names.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_stock_names.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_stock_names.FormattingEnabled = true;
            this.cmb_stock_names.Items.AddRange(new object[] {
            "-- Select to search --"});
            this.cmb_stock_names.Location = new System.Drawing.Point(146, 23);
            this.cmb_stock_names.Name = "cmb_stock_names";
            this.cmb_stock_names.Size = new System.Drawing.Size(121, 21);
            this.cmb_stock_names.TabIndex = 75;
            this.cmb_stock_names.SelectedIndexChanged += new System.EventHandler(this.cmb_stock_names_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(82, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(62, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Stock Name :";
            // 
            // txt_stock_name
            // 
            this.txt_stock_name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_stock_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock_name.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_stock_name.Location = new System.Drawing.Point(146, 66);
            this.txt_stock_name.Name = "txt_stock_name";
            this.txt_stock_name.Size = new System.Drawing.Size(121, 20);
            this.txt_stock_name.TabIndex = 71;
            // 
            // btn_update_details
            // 
            this.btn_update_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_details.FlatAppearance.BorderSize = 0;
            this.btn_update_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_update_details.Location = new System.Drawing.Point(345, 42);
            this.btn_update_details.Name = "btn_update_details";
            this.btn_update_details.Size = new System.Drawing.Size(150, 36);
            this.btn_update_details.TabIndex = 77;
            this.btn_update_details.Text = "Remove";
            this.btn_update_details.UseVisualStyleBackColor = false;
            this.btn_update_details.Click += new System.EventHandler(this.btn_update_details_Click);
            // 
            // txt_quntity
            // 
            this.txt_quntity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_quntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quntity.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_quntity.Location = new System.Drawing.Point(144, 100);
            this.txt_quntity.Name = "txt_quntity";
            this.txt_quntity.Size = new System.Drawing.Size(121, 20);
            this.txt_quntity.TabIndex = 79;
            this.txt_quntity.TextChanged += new System.EventHandler(this.txt_quntity_TextChanged);
            // 
            // RemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(508, 225);
            this.Controls.Add(this.btn_update_details);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveStock";
            this.Text = "RemoveStock";
            this.Load += new System.EventHandler(this.RemoveStock_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_stock_names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stock_name;
        private System.Windows.Forms.Button btn_update_details;
        private System.Windows.Forms.TextBox txt_quntity;
    }
}