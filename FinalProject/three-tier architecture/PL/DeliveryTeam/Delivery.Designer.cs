namespace FinalProject.three_tier_architecture.PL.Delivery_Team
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_special_Order_delivery = new System.Windows.Forms.Button();
            this.txt_selected_item = new System.Windows.Forms.TextBox();
            this.btn_normal_orders = new System.Windows.Forms.Button();
            this.btn_accsepted_orders = new System.Windows.Forms.Button();
            this.btn_update_status = new System.Windows.Forms.Button();
            this.cmb_Order_status = new System.Windows.Forms.ComboBox();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btn_special_Order_delivery);
            this.panel1.Controls.Add(this.txt_selected_item);
            this.panel1.Controls.Add(this.btn_normal_orders);
            this.panel1.Controls.Add(this.btn_accsepted_orders);
            this.panel1.Controls.Add(this.btn_update_status);
            this.panel1.Controls.Add(this.cmb_Order_status);
            this.panel1.Controls.Add(this.dgv_orders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 425);
            this.panel1.TabIndex = 68;
            // 
            // btn_special_Order_delivery
            // 
            this.btn_special_Order_delivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_special_Order_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_special_Order_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_special_Order_delivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.btn_special_Order_delivery.Location = new System.Drawing.Point(431, 307);
            this.btn_special_Order_delivery.Name = "btn_special_Order_delivery";
            this.btn_special_Order_delivery.Size = new System.Drawing.Size(145, 46);
            this.btn_special_Order_delivery.TabIndex = 71;
            this.btn_special_Order_delivery.Text = "Special Orders to Deliver";
            this.btn_special_Order_delivery.UseVisualStyleBackColor = false;
            this.btn_special_Order_delivery.Click += new System.EventHandler(this.btn_special_Order_delivery_Click);
            // 
            // txt_selected_item
            // 
            this.txt_selected_item.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_selected_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_selected_item.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_selected_item.Location = new System.Drawing.Point(148, 330);
            this.txt_selected_item.Name = "txt_selected_item";
            this.txt_selected_item.ReadOnly = true;
            this.txt_selected_item.Size = new System.Drawing.Size(268, 20);
            this.txt_selected_item.TabIndex = 70;
            // 
            // btn_normal_orders
            // 
            this.btn_normal_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_normal_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normal_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_normal_orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.btn_normal_orders.Location = new System.Drawing.Point(582, 307);
            this.btn_normal_orders.Name = "btn_normal_orders";
            this.btn_normal_orders.Size = new System.Drawing.Size(145, 46);
            this.btn_normal_orders.TabIndex = 68;
            this.btn_normal_orders.Text = "Normal Orders to Deliver";
            this.btn_normal_orders.UseVisualStyleBackColor = false;
            this.btn_normal_orders.Click += new System.EventHandler(this.btn_normal_orders_Click);
            // 
            // btn_accsepted_orders
            // 
            this.btn_accsepted_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_accsepted_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accsepted_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accsepted_orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.btn_accsepted_orders.Location = new System.Drawing.Point(582, 363);
            this.btn_accsepted_orders.Name = "btn_accsepted_orders";
            this.btn_accsepted_orders.Size = new System.Drawing.Size(145, 46);
            this.btn_accsepted_orders.TabIndex = 67;
            this.btn_accsepted_orders.Text = "Accepted Orders";
            this.btn_accsepted_orders.UseVisualStyleBackColor = false;
            this.btn_accsepted_orders.Click += new System.EventHandler(this.btn_accsepted_orders_Click);
            // 
            // btn_update_status
            // 
            this.btn_update_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_update_status.Location = new System.Drawing.Point(311, 372);
            this.btn_update_status.Name = "btn_update_status";
            this.btn_update_status.Size = new System.Drawing.Size(105, 29);
            this.btn_update_status.TabIndex = 69;
            this.btn_update_status.Text = "Update Status";
            this.btn_update_status.UseVisualStyleBackColor = false;
            this.btn_update_status.Click += new System.EventHandler(this.btn_update_status_Click);
            // 
            // cmb_Order_status
            // 
            this.cmb_Order_status.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_Order_status.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_Order_status.FormattingEnabled = true;
            this.cmb_Order_status.Items.AddRange(new object[] {
            "On the Way",
            "Delivered",
            "Delivered(Payment Received)"});
            this.cmb_Order_status.Location = new System.Drawing.Point(148, 376);
            this.cmb_Order_status.Name = "cmb_Order_status";
            this.cmb_Order_status.Size = new System.Drawing.Size(121, 21);
            this.cmb_Order_status.TabIndex = 66;
            // 
            // dgv_orders
            // 
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Location = new System.Drawing.Point(7, 16);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.Size = new System.Drawing.Size(724, 280);
            this.dgv_orders.TabIndex = 0;
            this.dgv_orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(22, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Delivery Status :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(22, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Select Order :";
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label14);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(762, 34);
            this.pnl_title.TabIndex = 67;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(731, 3);
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
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Delivery ";
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(762, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_selected_item;
        private System.Windows.Forms.Button btn_normal_orders;
        private System.Windows.Forms.Button btn_accsepted_orders;
        private System.Windows.Forms.Button btn_update_status;
        private System.Windows.Forms.ComboBox cmb_Order_status;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_special_Order_delivery;
    }
}