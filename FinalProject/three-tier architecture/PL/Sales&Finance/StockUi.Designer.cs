namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    partial class StockUi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUi));
            this.panel6 = new System.Windows.Forms.Panel();
            this.ch_stocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cpb_stock_prisentage = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_stock_names = new System.Windows.Forms.ComboBox();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_stocks)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel6.Controls.Add(this.ch_stocks);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(11, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(554, 297);
            this.panel6.TabIndex = 57;
            // 
            // ch_stocks
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_stocks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_stocks.Legends.Add(legend2);
            this.ch_stocks.Location = new System.Drawing.Point(19, 48);
            this.ch_stocks.Name = "ch_stocks";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ch_stocks.Series.Add(series2);
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
            this.panel3.Location = new System.Drawing.Point(575, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 246);
            this.panel3.TabIndex = 56;
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
            this.cpb_stock_prisentage.Location = new System.Drawing.Point(24, 72);
            this.cpb_stock_prisentage.MarqueeAnimationSpeed = 2000;
            this.cpb_stock_prisentage.Name = "cpb_stock_prisentage";
            this.cpb_stock_prisentage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpb_stock_prisentage.OuterMargin = -23;
            this.cpb_stock_prisentage.OuterWidth = 20;
            this.cpb_stock_prisentage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
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
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stocks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Selected Stock Type :";
            // 
            // cmb_stock_names
            // 
            this.cmb_stock_names.FormattingEnabled = true;
            this.cmb_stock_names.Items.AddRange(new object[] {
            "All"});
            this.cmb_stock_names.Location = new System.Drawing.Point(182, 59);
            this.cmb_stock_names.Name = "cmb_stock_names";
            this.cmb_stock_names.Size = new System.Drawing.Size(166, 21);
            this.cmb_stock_names.TabIndex = 58;
            this.cmb_stock_names.SelectedIndexChanged += new System.EventHandler(this.cmb_stock_names_SelectedIndexChanged);
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label9);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(778, 34);
            this.pnl_title.TabIndex = 61;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(743, 6);
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
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Stock";
            // 
            // StockUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(778, 417);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_stock_names);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockUi";
            this.Text = "StockUi";
            this.Load += new System.EventHandler(this.StockUi_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_stocks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar cpb_stock_prisentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_stock_names;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_stocks;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label9;
    }
}