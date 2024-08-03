namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    partial class AddNewStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStock));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nud_quntity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_item_no_one = new System.Windows.Forms.TextBox();
            this.btn_update_details = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_add_new_stock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
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
            this.pnl_title.Size = new System.Drawing.Size(515, 34);
            this.pnl_title.TabIndex = 54;
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Add New Stock";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cmb_status);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.nud_quntity);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_item_no_one);
            this.panel6.Location = new System.Drawing.Point(0, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 173);
            this.panel6.TabIndex = 56;
            // 
            // nud_quntity
            // 
            this.nud_quntity.Location = new System.Drawing.Point(146, 106);
            this.nud_quntity.Name = "nud_quntity";
            this.nud_quntity.Size = new System.Drawing.Size(102, 20);
            this.nud_quntity.TabIndex = 74;
            this.nud_quntity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(82, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(62, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Stock Name :";
            // 
            // txt_item_no_one
            // 
            this.txt_item_no_one.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_item_no_one.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item_no_one.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_item_no_one.Location = new System.Drawing.Point(146, 71);
            this.txt_item_no_one.Name = "txt_item_no_one";
            this.txt_item_no_one.ReadOnly = true;
            this.txt_item_no_one.Size = new System.Drawing.Size(121, 20);
            this.txt_item_no_one.TabIndex = 71;
            // 
            // btn_update_details
            // 
            this.btn_update_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_details.FlatAppearance.BorderSize = 0;
            this.btn_update_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_update_details.Location = new System.Drawing.Point(345, 186);
            this.btn_update_details.Name = "btn_update_details";
            this.btn_update_details.Size = new System.Drawing.Size(150, 36);
            this.btn_update_details.TabIndex = 76;
            this.btn_update_details.Text = "Update Details";
            this.btn_update_details.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // btn_add_new_stock
            // 
            this.btn_add_new_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_add_new_stock.FlatAppearance.BorderSize = 0;
            this.btn_add_new_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_add_new_stock.Location = new System.Drawing.Point(345, 49);
            this.btn_add_new_stock.Name = "btn_add_new_stock";
            this.btn_add_new_stock.Size = new System.Drawing.Size(150, 36);
            this.btn_add_new_stock.TabIndex = 77;
            this.btn_add_new_stock.Text = "Add new Stock ";
            this.btn_add_new_stock.UseVisualStyleBackColor = false;
            this.btn_add_new_stock.Click += new System.EventHandler(this.btn_add_new_stock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(91, 145);
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
            this.cmb_status.Location = new System.Drawing.Point(146, 142);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 21);
            this.cmb_status.TabIndex = 77;
            // 
            // AddNewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(515, 239);
            this.Controls.Add(this.btn_add_new_stock);
            this.Controls.Add(this.btn_update_details);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewStock";
            this.Text = "AddNewStock";
            this.Load += new System.EventHandler(this.AddNewStock_Load);
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
        private System.Windows.Forms.NumericUpDown nud_quntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_item_no_one;
        private System.Windows.Forms.Button btn_update_details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_add_new_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_status;
    }
}