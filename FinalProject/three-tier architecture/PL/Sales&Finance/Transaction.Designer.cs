namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_requests = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_requested_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_net_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_selected_row = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mark_as_paid = new System.Windows.Forms.Button();
            this.btn_load_all_paided = new System.Windows.Forms.Button();
            this.btn_load_payment_pending = new System.Windows.Forms.Button();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.dgv_requests);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 286);
            this.panel1.TabIndex = 68;
            // 
            // dgv_requests
            // 
            this.dgv_requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_requests.Location = new System.Drawing.Point(17, 17);
            this.dgv_requests.Name = "dgv_requests";
            this.dgv_requests.Size = new System.Drawing.Size(438, 248);
            this.dgv_requests.TabIndex = 1;
            this.dgv_requests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_requests_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.txt_requested_quantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_net_total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_selected_row);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(497, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 123);
            this.panel2.TabIndex = 69;
            // 
            // txt_requested_quantity
            // 
            this.txt_requested_quantity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_requested_quantity.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_requested_quantity.Location = new System.Drawing.Point(137, 50);
            this.txt_requested_quantity.Name = "txt_requested_quantity";
            this.txt_requested_quantity.ReadOnly = true;
            this.txt_requested_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_requested_quantity.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Requested Quantity :";
            // 
            // txt_net_total
            // 
            this.txt_net_total.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_net_total.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_net_total.Location = new System.Drawing.Point(137, 81);
            this.txt_net_total.Name = "txt_net_total";
            this.txt_net_total.ReadOnly = true;
            this.txt_net_total.Size = new System.Drawing.Size(100, 20);
            this.txt_net_total.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Net Total :";
            // 
            // txt_selected_row
            // 
            this.txt_selected_row.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_selected_row.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_selected_row.Location = new System.Drawing.Point(137, 24);
            this.txt_selected_row.Name = "txt_selected_row";
            this.txt_selected_row.Size = new System.Drawing.Size(100, 20);
            this.txt_selected_row.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Selected Requests :";
            // 
            // btn_mark_as_paid
            // 
            this.btn_mark_as_paid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_mark_as_paid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mark_as_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mark_as_paid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_mark_as_paid.Location = new System.Drawing.Point(656, 256);
            this.btn_mark_as_paid.Name = "btn_mark_as_paid";
            this.btn_mark_as_paid.Size = new System.Drawing.Size(125, 36);
            this.btn_mark_as_paid.TabIndex = 66;
            this.btn_mark_as_paid.Text = "Mark As Paid";
            this.btn_mark_as_paid.UseVisualStyleBackColor = false;
            this.btn_mark_as_paid.Click += new System.EventHandler(this.btn_mark_as_paid_Click);
            // 
            // btn_load_all_paided
            // 
            this.btn_load_all_paided.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_load_all_paided.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_all_paided.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_all_paided.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_load_all_paided.Location = new System.Drawing.Point(497, 256);
            this.btn_load_all_paided.Name = "btn_load_all_paided";
            this.btn_load_all_paided.Size = new System.Drawing.Size(153, 36);
            this.btn_load_all_paided.TabIndex = 70;
            this.btn_load_all_paided.Text = "Load All Paid Requests";
            this.btn_load_all_paided.UseVisualStyleBackColor = false;
            this.btn_load_all_paided.Click += new System.EventHandler(this.btn_load_all_paided_Click);
            // 
            // btn_load_payment_pending
            // 
            this.btn_load_payment_pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_load_payment_pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_payment_pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_payment_pending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_load_payment_pending.Location = new System.Drawing.Point(497, 205);
            this.btn_load_payment_pending.Name = "btn_load_payment_pending";
            this.btn_load_payment_pending.Size = new System.Drawing.Size(284, 36);
            this.btn_load_payment_pending.TabIndex = 71;
            this.btn_load_payment_pending.Text = "Load Payment Pending Requests";
            this.btn_load_payment_pending.UseVisualStyleBackColor = false;
            this.btn_load_payment_pending.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label9);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(797, 34);
            this.pnl_title.TabIndex = 72;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(765, 7);
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
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Transaction";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(797, 343);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.btn_load_payment_pending);
            this.Controls.Add(this.btn_load_all_paided);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_mark_as_paid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_requests;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_requested_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_net_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_selected_row;
        private System.Windows.Forms.Button btn_mark_as_paid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_load_all_paided;
        private System.Windows.Forms.Button btn_load_payment_pending;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label9;
    }
}