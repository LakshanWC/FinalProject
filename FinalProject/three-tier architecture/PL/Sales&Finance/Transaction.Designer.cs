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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_requests = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_requested_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_net_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_selected_row = new System.Windows.Forms.TextBox();
            this.cb_loadAll = new System.Windows.Forms.CheckBox();
            this.btn_delivering = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.dgv_requests);
            this.panel1.Location = new System.Drawing.Point(12, 67);
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
            this.panel2.Controls.Add(this.cb_loadAll);
            this.panel2.Controls.Add(this.btn_delivering);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(504, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 286);
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
            this.txt_net_total.Location = new System.Drawing.Point(137, 145);
            this.txt_net_total.Name = "txt_net_total";
            this.txt_net_total.ReadOnly = true;
            this.txt_net_total.Size = new System.Drawing.Size(100, 20);
            this.txt_net_total.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(20, 148);
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
            // cb_loadAll
            // 
            this.cb_loadAll.AutoSize = true;
            this.cb_loadAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cb_loadAll.Location = new System.Drawing.Point(186, 197);
            this.cb_loadAll.Name = "cb_loadAll";
            this.cb_loadAll.Size = new System.Drawing.Size(67, 17);
            this.cb_loadAll.TabIndex = 67;
            this.cb_loadAll.Text = "Load All ";
            this.cb_loadAll.UseVisualStyleBackColor = true;
            // 
            // btn_delivering
            // 
            this.btn_delivering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_delivering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_delivering.Location = new System.Drawing.Point(134, 229);
            this.btn_delivering.Name = "btn_delivering";
            this.btn_delivering.Size = new System.Drawing.Size(103, 36);
            this.btn_delivering.TabIndex = 66;
            this.btn_delivering.Text = "Mark As Paid";
            this.btn_delivering.UseVisualStyleBackColor = false;
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
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.CheckBox cb_loadAll;
        private System.Windows.Forms.Button btn_delivering;
        private System.Windows.Forms.Label label1;
    }
}