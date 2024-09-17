namespace FinalProject.three_tier_architecture.PL.Cashier
{
    partial class CheckInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInventory));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_stock_names = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ch_stocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cpb_stock_prisentage = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update_status = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.nud_quntity = new System.Windows.Forms.NumericUpDown();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_selected_item = new System.Windows.Forms.ComboBox();
            this.pnl_title.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_stocks)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnl_title.Size = new System.Drawing.Size(832, 34);
            this.pnl_title.TabIndex = 64;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(797, 6);
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
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Check Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Selected Stock Type :";
            // 
            // cmb_stock_names
            // 
            this.cmb_stock_names.FormattingEnabled = true;
            this.cmb_stock_names.Items.AddRange(new object[] {
            "All"});
            this.cmb_stock_names.Location = new System.Drawing.Point(183, 53);
            this.cmb_stock_names.Name = "cmb_stock_names";
            this.cmb_stock_names.Size = new System.Drawing.Size(166, 21);
            this.cmb_stock_names.TabIndex = 67;
            this.cmb_stock_names.SelectedIndexChanged += new System.EventHandler(this.cmb_stock_names_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel6.Controls.Add(this.ch_stocks);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(12, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(554, 297);
            this.panel6.TabIndex = 66;
            // 
            // ch_stocks
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_stocks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_stocks.Legends.Add(legend1);
            this.ch_stocks.Location = new System.Drawing.Point(19, 48);
            this.ch_stocks.Name = "ch_stocks";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_stocks.Series.Add(series1);
            this.ch_stocks.Size = new System.Drawing.Size(513, 235);
            this.ch_stocks.TabIndex = 2;
            this.ch_stocks.Text = "chart1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Over All Stocks";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.cpb_stock_prisentage);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(576, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 194);
            this.panel3.TabIndex = 65;
            // 
            // cpb_stock_prisentage
            // 
            this.cpb_stock_prisentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpb_stock_prisentage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpb_stock_prisentage.AnimationSpeed = 500;
            this.cpb_stock_prisentage.BackColor = System.Drawing.Color.Transparent;
            this.cpb_stock_prisentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cpb_stock_prisentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpb_stock_prisentage.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cpb_stock_prisentage.InnerMargin = 2;
            this.cpb_stock_prisentage.InnerWidth = -1;
            this.cpb_stock_prisentage.Location = new System.Drawing.Point(58, 46);
            this.cpb_stock_prisentage.MarqueeAnimationSpeed = 2000;
            this.cpb_stock_prisentage.Name = "cpb_stock_prisentage";
            this.cpb_stock_prisentage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpb_stock_prisentage.OuterMargin = -23;
            this.cpb_stock_prisentage.OuterWidth = 20;
            this.cpb_stock_prisentage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.cpb_stock_prisentage.ProgressWidth = 15;
            this.cpb_stock_prisentage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpb_stock_prisentage.Size = new System.Drawing.Size(138, 132);
            this.cpb_stock_prisentage.StartAngle = 270;
            this.cpb_stock_prisentage.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_stock_prisentage.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpb_stock_prisentage.SubscriptText = "";
            this.cpb_stock_prisentage.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_stock_prisentage.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpb_stock_prisentage.SuperscriptText = "";
            this.cpb_stock_prisentage.TabIndex = 3;
            this.cpb_stock_prisentage.Text = "5%";
            this.cpb_stock_prisentage.TextMargin = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.cpb_stock_prisentage.Value = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stocks";
            // 
            // btn_update_status
            // 
            this.btn_update_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_status.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_update_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_update_status.Location = new System.Drawing.Point(718, 365);
            this.btn_update_status.Name = "btn_update_status";
            this.btn_update_status.Size = new System.Drawing.Size(105, 29);
            this.btn_update_status.TabIndex = 72;
            this.btn_update_status.Text = "Update Status";
            this.btn_update_status.UseVisualStyleBackColor = false;
            this.btn_update_status.Click += new System.EventHandler(this.btn_update_status_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.nud_quntity);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_selected_item);
            this.panel1.Location = new System.Drawing.Point(576, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 119);
            this.panel1.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(40, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Status :";
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
            this.cmb_status.Location = new System.Drawing.Point(115, 83);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 21);
            this.cmb_status.TabIndex = 79;
            // 
            // nud_quntity
            // 
            this.nud_quntity.Location = new System.Drawing.Point(118, 56);
            this.nud_quntity.Name = "nud_quntity";
            this.nud_quntity.Size = new System.Drawing.Size(102, 20);
            this.nud_quntity.TabIndex = 75;
            this.nud_quntity.ValueChanged += new System.EventHandler(this.nud_quntity_ValueChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quantity.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_quantity.Location = new System.Drawing.Point(118, 30);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Stocks Left :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Inventory Items :";
            // 
            // cmb_selected_item
            // 
            this.cmb_selected_item.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_selected_item.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_selected_item.FormattingEnabled = true;
            this.cmb_selected_item.Location = new System.Drawing.Point(118, 4);
            this.cmb_selected_item.Name = "cmb_selected_item";
            this.cmb_selected_item.Size = new System.Drawing.Size(121, 21);
            this.cmb_selected_item.TabIndex = 60;
            this.cmb_selected_item.SelectedIndexChanged += new System.EventHandler(this.cmb_selected_item_SelectedIndexChanged);
            // 
            // CheckInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(832, 416);
            this.Controls.Add(this.btn_update_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_stock_names);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckInventory";
            this.Text = "CheckInventory";
            this.Load += new System.EventHandler(this.CheckInventory_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_stocks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quntity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_stock_names;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_stocks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar cpb_stock_prisentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.NumericUpDown nud_quntity;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_selected_item;
    }
}