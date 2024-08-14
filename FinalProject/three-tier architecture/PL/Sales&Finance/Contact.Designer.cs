namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_stock_names = new System.Windows.Forms.ComboBox();
            this.nud_quntity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_requset_description = new System.Windows.Forms.TextBox();
            this.dtp_deliver_on_date = new System.Windows.Forms.DateTimePicker();
            this.btn_add_new_stock = new System.Windows.Forms.Button();
            this.pnl_title.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quntity)).BeginInit();
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
            this.pnl_title.Size = new System.Drawing.Size(648, 34);
            this.pnl_title.TabIndex = 55;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(619, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Contact";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel6.Controls.Add(this.dtp_deliver_on_date);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cmb_stock_names);
            this.panel6.Controls.Add(this.nud_quntity);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_requset_description);
            this.panel6.Location = new System.Drawing.Point(6, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 355);
            this.panel6.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(62, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Deliver On :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(54, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Select Stock  : ";
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
            // 
            // nud_quntity
            // 
            this.nud_quntity.Location = new System.Drawing.Point(146, 77);
            this.nud_quntity.Name = "nud_quntity";
            this.nud_quntity.Size = new System.Drawing.Size(102, 20);
            this.nud_quntity.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(82, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(37, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Request Details :";
            // 
            // txt_requset_description
            // 
            this.txt_requset_description.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_requset_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_requset_description.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_requset_description.Location = new System.Drawing.Point(146, 180);
            this.txt_requset_description.Multiline = true;
            this.txt_requset_description.Name = "txt_requset_description";
            this.txt_requset_description.Size = new System.Drawing.Size(279, 128);
            this.txt_requset_description.TabIndex = 71;
            // 
            // dtp_deliver_on_date
            // 
            this.dtp_deliver_on_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_deliver_on_date.Location = new System.Drawing.Point(146, 130);
            this.dtp_deliver_on_date.Name = "dtp_deliver_on_date";
            this.dtp_deliver_on_date.Size = new System.Drawing.Size(102, 20);
            this.dtp_deliver_on_date.TabIndex = 79;
            // 
            // btn_add_new_stock
            // 
            this.btn_add_new_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_add_new_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_add_new_stock.Location = new System.Drawing.Point(492, 41);
            this.btn_add_new_stock.Name = "btn_add_new_stock";
            this.btn_add_new_stock.Size = new System.Drawing.Size(150, 36);
            this.btn_add_new_stock.TabIndex = 78;
            this.btn_add_new_stock.Text = "Request ";
            this.btn_add_new_stock.UseVisualStyleBackColor = false;
            this.btn_add_new_stock.Click += new System.EventHandler(this.btn_add_new_stock_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(648, 404);
            this.Controls.Add(this.btn_add_new_stock);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contact";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quntity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_stock_names;
        private System.Windows.Forms.NumericUpDown nud_quntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_requset_description;
        private System.Windows.Forms.DateTimePicker dtp_deliver_on_date;
        private System.Windows.Forms.Button btn_add_new_stock;
    }
}