namespace FinalProject.three_tier_architecture.PL.Customerr
{
    partial class OrderCustomize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCustomize));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_selected_item = new System.Windows.Forms.ComboBox();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_item_one = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nud_item_quantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_third_option = new System.Windows.Forms.ComboBox();
            this.txt_total_price = new System.Windows.Forms.TextBox();
            this.cmb_second_option = new System.Windows.Forms.ComboBox();
            this.cmb_first_option = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_item_quantity)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pnl_title.Size = new System.Drawing.Size(781, 34);
            this.pnl_title.TabIndex = 63;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(745, 6);
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
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "OrderCustomize";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.txt_order_id);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_selected_item);
            this.panel1.Controls.Add(this.txt_item_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_item_one);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.nud_item_quantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 403);
            this.panel1.TabIndex = 64;
            // 
            // txt_order_id
            // 
            this.txt_order_id.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_order_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_order_id.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_order_id.Location = new System.Drawing.Point(146, 211);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.ReadOnly = true;
            this.txt_order_id.Size = new System.Drawing.Size(121, 20);
            this.txt_order_id.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(33, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Order Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(33, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Selected Items :";
            // 
            // cmb_selected_item
            // 
            this.cmb_selected_item.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_selected_item.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_selected_item.FormattingEnabled = true;
            this.cmb_selected_item.Location = new System.Drawing.Point(146, 247);
            this.cmb_selected_item.Name = "cmb_selected_item";
            this.cmb_selected_item.Size = new System.Drawing.Size(121, 21);
            this.cmb_selected_item.TabIndex = 61;
            // 
            // txt_item_name
            // 
            this.txt_item_name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_item_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item_name.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_item_name.Location = new System.Drawing.Point(146, 289);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.ReadOnly = true;
            this.txt_item_name.Size = new System.Drawing.Size(102, 20);
            this.txt_item_name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item Name :";
            // 
            // pb_item_one
            // 
            this.pb_item_one.Location = new System.Drawing.Point(29, 21);
            this.pb_item_one.Name = "pb_item_one";
            this.pb_item_one.Size = new System.Drawing.Size(272, 161);
            this.pb_item_one.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_item_one.TabIndex = 18;
            this.pb_item_one.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(34, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Quantity :";
            // 
            // nud_item_quantity
            // 
            this.nud_item_quantity.Location = new System.Drawing.Point(146, 330);
            this.nud_item_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_item_quantity.Name = "nud_item_quantity";
            this.nud_item_quantity.Size = new System.Drawing.Size(88, 20);
            this.nud_item_quantity.TabIndex = 65;
            this.nud_item_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_item_quantity.ValueChanged += new System.EventHandler(this.nud_item_quantity_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(36, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Price :";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_price.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_price.Location = new System.Drawing.Point(146, 366);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(88, 20);
            this.txt_price.TabIndex = 62;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_third_option);
            this.panel2.Controls.Add(this.txt_total_price);
            this.panel2.Controls.Add(this.cmb_second_option);
            this.panel2.Controls.Add(this.cmb_first_option);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_description);
            this.panel2.Location = new System.Drawing.Point(376, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 363);
            this.panel2.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Total Price :";
            // 
            // cmb_third_option
            // 
            this.cmb_third_option.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_third_option.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_third_option.FormattingEnabled = true;
            this.cmb_third_option.Location = new System.Drawing.Point(138, 86);
            this.cmb_third_option.Name = "cmb_third_option";
            this.cmb_third_option.Size = new System.Drawing.Size(121, 21);
            this.cmb_third_option.TabIndex = 83;
            this.cmb_third_option.SelectedIndexChanged += new System.EventHandler(this.cmb_third_option_SelectedIndexChanged);
            // 
            // txt_total_price
            // 
            this.txt_total_price.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_total_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total_price.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_total_price.Location = new System.Drawing.Point(138, 284);
            this.txt_total_price.Name = "txt_total_price";
            this.txt_total_price.ReadOnly = true;
            this.txt_total_price.Size = new System.Drawing.Size(121, 20);
            this.txt_total_price.TabIndex = 82;
            this.txt_total_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_second_option
            // 
            this.cmb_second_option.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_second_option.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_second_option.FormattingEnabled = true;
            this.cmb_second_option.Location = new System.Drawing.Point(138, 53);
            this.cmb_second_option.Name = "cmb_second_option";
            this.cmb_second_option.Size = new System.Drawing.Size(121, 21);
            this.cmb_second_option.TabIndex = 82;
            this.cmb_second_option.SelectedIndexChanged += new System.EventHandler(this.cmb_second_option_SelectedIndexChanged);
            // 
            // cmb_first_option
            // 
            this.cmb_first_option.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_first_option.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_first_option.FormattingEnabled = true;
            this.cmb_first_option.Location = new System.Drawing.Point(138, 22);
            this.cmb_first_option.Name = "cmb_first_option";
            this.cmb_first_option.Size = new System.Drawing.Size(121, 21);
            this.cmb_first_option.TabIndex = 81;
            this.cmb_first_option.SelectedIndexChanged += new System.EventHandler(this.cmb_first_option_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(22, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Third Option :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(22, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Second Option :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "First Option :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(22, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Extra Info  :";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_description.Location = new System.Drawing.Point(138, 127);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(231, 130);
            this.txt_description.TabIndex = 76;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_order.Location = new System.Drawing.Point(620, 409);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(146, 36);
            this.btn_order.TabIndex = 66;
            this.btn_order.Text = "Place special order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_clear_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_clear_all.Location = new System.Drawing.Point(527, 409);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(75, 36);
            this.btn_clear_all.TabIndex = 67;
            this.btn_clear_all.Text = "Clear All";
            this.btn_clear_all.UseVisualStyleBackColor = false;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // OrderCustomize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(781, 455);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCustomize";
            this.Text = "OrderCustomize";
            this.Load += new System.EventHandler(this.OrderCustomize_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_item_quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_selected_item;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_item_one;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.NumericUpDown nud_item_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ComboBox cmb_third_option;
        private System.Windows.Forms.ComboBox cmb_second_option;
        private System.Windows.Forms.ComboBox cmb_first_option;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total_price;
        private System.Windows.Forms.Button btn_clear_all;
    }
}