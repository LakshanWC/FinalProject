namespace FinalProject.three_tier_architecture.PL.Supplier
{
    partial class StockOrderRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOrderRequest));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_requests = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_set_net_price = new System.Windows.Forms.Button();
            this.txt_requested_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_net_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_sigal_item_price = new System.Windows.Forms.NumericUpDown();
            this.txt_selected_row = new System.Windows.Forms.TextBox();
            this.cb_loadAll = new System.Windows.Forms.CheckBox();
            this.btn_delivering = new System.Windows.Forms.Button();
            this.btn_delivered = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sigal_item_price)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label6);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(788, 34);
            this.pnl_title.TabIndex = 53;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(751, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Stock Order Request";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.dgv_requests);
            this.panel1.Location = new System.Drawing.Point(15, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 286);
            this.panel1.TabIndex = 67;
            // 
            // dgv_requests
            // 
            this.dgv_requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_requests.Location = new System.Drawing.Point(17, 17);
            this.dgv_requests.Name = "dgv_requests";
            this.dgv_requests.Size = new System.Drawing.Size(438, 248);
            this.dgv_requests.TabIndex = 1;
            this.dgv_requests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_requests_CellClick);
            this.dgv_requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_requests_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.btn_set_net_price);
            this.panel2.Controls.Add(this.txt_requested_quantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_net_total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nud_sigal_item_price);
            this.panel2.Controls.Add(this.txt_selected_row);
            this.panel2.Controls.Add(this.cb_loadAll);
            this.panel2.Controls.Add(this.btn_delivering);
            this.panel2.Controls.Add(this.btn_delivered);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(490, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 286);
            this.panel2.TabIndex = 68;
            // 
            // btn_set_net_price
            // 
            this.btn_set_net_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_set_net_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set_net_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_net_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btn_set_net_price.Location = new System.Drawing.Point(18, 187);
            this.btn_set_net_price.Name = "btn_set_net_price";
            this.btn_set_net_price.Size = new System.Drawing.Size(103, 36);
            this.btn_set_net_price.TabIndex = 76;
            this.btn_set_net_price.Text = "Set Price ";
            this.btn_set_net_price.UseVisualStyleBackColor = false;
            this.btn_set_net_price.Click += new System.EventHandler(this.btn_set_net_price_Click);
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
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
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
            this.txt_net_total.Location = new System.Drawing.Point(137, 145);
            this.txt_net_total.Name = "txt_net_total";
            this.txt_net_total.ReadOnly = true;
            this.txt_net_total.Size = new System.Drawing.Size(100, 20);
            this.txt_net_total.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Net Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Price Of Sigal Item :";
            // 
            // nud_sigal_item_price
            // 
            this.nud_sigal_item_price.Location = new System.Drawing.Point(137, 108);
            this.nud_sigal_item_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_sigal_item_price.Name = "nud_sigal_item_price";
            this.nud_sigal_item_price.Size = new System.Drawing.Size(100, 20);
            this.nud_sigal_item_price.TabIndex = 69;
            this.nud_sigal_item_price.ValueChanged += new System.EventHandler(this.nud_sigal_item_price_ValueChanged);
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
            // cb_loadAll
            // 
            this.cb_loadAll.AutoSize = true;
            this.cb_loadAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.cb_loadAll.Location = new System.Drawing.Point(186, 197);
            this.cb_loadAll.Name = "cb_loadAll";
            this.cb_loadAll.Size = new System.Drawing.Size(67, 17);
            this.cb_loadAll.TabIndex = 67;
            this.cb_loadAll.Text = "Load All ";
            this.cb_loadAll.UseVisualStyleBackColor = true;
            this.cb_loadAll.CheckedChanged += new System.EventHandler(this.cb_loadAll_CheckedChanged);
            // 
            // btn_delivering
            // 
            this.btn_delivering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_delivering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btn_delivering.Location = new System.Drawing.Point(19, 236);
            this.btn_delivering.Name = "btn_delivering";
            this.btn_delivering.Size = new System.Drawing.Size(103, 36);
            this.btn_delivering.TabIndex = 66;
            this.btn_delivering.Text = "Mark as Out for Delivery";
            this.btn_delivering.UseVisualStyleBackColor = false;
            this.btn_delivering.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delivered
            // 
            this.btn_delivered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_delivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btn_delivered.Location = new System.Drawing.Point(146, 236);
            this.btn_delivered.Name = "btn_delivered";
            this.btn_delivered.Size = new System.Drawing.Size(120, 36);
            this.btn_delivered.TabIndex = 64;
            this.btn_delivered.Text = "Mark as Deliverd";
            this.btn_delivered.UseVisualStyleBackColor = false;
            this.btn_delivered.Click += new System.EventHandler(this.btn_delivered_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Selected Requests :";
            // 
            // StockOrderRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(788, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockOrderRequest";
            this.Text = "StockOrderRequest";
            this.Load += new System.EventHandler(this.StockOrderRequest_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sigal_item_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_requests;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delivered;
        private System.Windows.Forms.Button btn_delivering;
        private System.Windows.Forms.CheckBox cb_loadAll;
        private System.Windows.Forms.TextBox txt_selected_row;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_sigal_item_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_net_total;
        private System.Windows.Forms.TextBox txt_requested_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_set_net_price;
    }
}