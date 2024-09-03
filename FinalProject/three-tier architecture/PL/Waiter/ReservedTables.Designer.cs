namespace FinalProject.three_tier_architecture.PL.Waiter
{
    partial class ReservedTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservedTables));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_reservedTables = new System.Windows.Forms.DataGridView();
            this.txt_selected_item = new System.Windows.Forms.TextBox();
            this.cmb_Order_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update_status = new System.Windows.Forms.Button();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservedTables)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label14);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(417, 34);
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
            this.btn_close.Location = new System.Drawing.Point(381, 3);
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
            this.label14.Size = new System.Drawing.Size(114, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Reserved Tables";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btn_update_status);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_selected_item);
            this.panel1.Controls.Add(this.cmb_Order_status);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dgv_reservedTables);
            this.panel1.Location = new System.Drawing.Point(15, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 398);
            this.panel1.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(14, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Selected Table  :";
            // 
            // dgv_reservedTables
            // 
            this.dgv_reservedTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservedTables.Location = new System.Drawing.Point(7, 10);
            this.dgv_reservedTables.Name = "dgv_reservedTables";
            this.dgv_reservedTables.Size = new System.Drawing.Size(361, 287);
            this.dgv_reservedTables.TabIndex = 0;
            this.dgv_reservedTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservedTables_CellClick);
            // 
            // txt_selected_item
            // 
            this.txt_selected_item.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_selected_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_selected_item.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_selected_item.Location = new System.Drawing.Point(108, 313);
            this.txt_selected_item.Name = "txt_selected_item";
            this.txt_selected_item.ReadOnly = true;
            this.txt_selected_item.Size = new System.Drawing.Size(129, 20);
            this.txt_selected_item.TabIndex = 72;
            // 
            // cmb_Order_status
            // 
            this.cmb_Order_status.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_Order_status.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_Order_status.FormattingEnabled = true;
            this.cmb_Order_status.Items.AddRange(new object[] {
            "free",
            "Cleaning in Progress",
            "Resivered"});
            this.cmb_Order_status.Location = new System.Drawing.Point(108, 350);
            this.cmb_Order_status.Name = "cmb_Order_status";
            this.cmb_Order_status.Size = new System.Drawing.Size(129, 21);
            this.cmb_Order_status.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(14, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mark As :";
            // 
            // btn_update_status
            // 
            this.btn_update_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_update_status.Location = new System.Drawing.Point(263, 345);
            this.btn_update_status.Name = "btn_update_status";
            this.btn_update_status.Size = new System.Drawing.Size(105, 29);
            this.btn_update_status.TabIndex = 74;
            this.btn_update_status.Text = "Update Status";
            this.btn_update_status.UseVisualStyleBackColor = false;
            this.btn_update_status.Click += new System.EventHandler(this.btn_update_status_Click);
            // 
            // ReservedTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservedTables";
            this.Text = "ReservedTables";
            this.Load += new System.EventHandler(this.ReservedTables_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservedTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_reservedTables;
        private System.Windows.Forms.TextBox txt_selected_item;
        private System.Windows.Forms.ComboBox cmb_Order_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update_status;
    }
}