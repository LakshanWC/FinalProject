namespace FinalProject.three_tier_architecture.PL.Manager
{
    partial class RemoveMenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveMenuItem));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_item_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_item_image = new System.Windows.Forms.PictureBox();
            this.btn_remove_item = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_event_type = new System.Windows.Forms.ComboBox();
            this.txt_item_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item_image)).BeginInit();
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
            this.pnl_title.Size = new System.Drawing.Size(543, 34);
            this.pnl_title.TabIndex = 53;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(503, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Remove menu item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmb_event_type);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(248, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 62);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_item_id);
            this.panel1.Controls.Add(this.txt_item_price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_item_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(248, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 111);
            this.panel1.TabIndex = 57;
            // 
            // txt_item_id
            // 
            this.txt_item_id.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_item_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item_id.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_item_id.Location = new System.Drawing.Point(145, 14);
            this.txt_item_id.Name = "txt_item_id";
            this.txt_item_id.ReadOnly = true;
            this.txt_item_id.Size = new System.Drawing.Size(100, 20);
            this.txt_item_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id :";
            // 
            // txt_item_name
            // 
            this.txt_item_name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_item_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item_name.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_item_name.Location = new System.Drawing.Point(144, 45);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(100, 20);
            this.txt_item_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name :";
            // 
            // pb_item_image
            // 
            this.pb_item_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_item_image.Location = new System.Drawing.Point(15, 69);
            this.pb_item_image.Name = "pb_item_image";
            this.pb_item_image.Size = new System.Drawing.Size(217, 176);
            this.pb_item_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_item_image.TabIndex = 55;
            this.pb_item_image.TabStop = false;
            // 
            // btn_remove_item
            // 
            this.btn_remove_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_remove_item.FlatAppearance.BorderSize = 0;
            this.btn_remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_remove_item.Location = new System.Drawing.Point(444, 227);
            this.btn_remove_item.Name = "btn_remove_item";
            this.btn_remove_item.Size = new System.Drawing.Size(82, 42);
            this.btn_remove_item.TabIndex = 56;
            this.btn_remove_item.Text = "Remove";
            this.btn_remove_item.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search :";
            // 
            // cmb_event_type
            // 
            this.cmb_event_type.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmb_event_type.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_event_type.FormattingEnabled = true;
            this.cmb_event_type.Items.AddRange(new object[] {
            "..Select...",
            "Live Music Performances",
            "",
            "Chef’s Table Events",
            "",
            "Themed Dinner Nights",
            "",
            "Brunch Events",
            "",
            "Trivia Nights",
            "",
            "Game Nights",
            "",
            "Holiday Celebrations",
            "",
            "Cultural Festivals",
            "",
            "Seasonal Celebrations",
            "",
            "Birthday Events",
            "",
            "Custom"});
            this.cmb_event_type.Location = new System.Drawing.Point(67, 21);
            this.cmb_event_type.Name = "cmb_event_type";
            this.cmb_event_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_event_type.TabIndex = 59;
            // 
            // txt_item_price
            // 
            this.txt_item_price.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_item_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item_price.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_item_price.Location = new System.Drawing.Point(145, 79);
            this.txt_item_price.Name = "txt_item_price";
            this.txt_item_price.Size = new System.Drawing.Size(100, 20);
            this.txt_item_price.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item Price :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Location = new System.Drawing.Point(205, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 36);
            this.button1.TabIndex = 59;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RemoveMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(543, 286);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_remove_item);
            this.Controls.Add(this.pb_item_image);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveMenuItem";
            this.Text = "RemoveMenuItem";
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_item_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_item_image;
        private System.Windows.Forms.Button btn_remove_item;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_event_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_item_price;
    }
}