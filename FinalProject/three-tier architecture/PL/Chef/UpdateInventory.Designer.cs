namespace FinalProject.three_tier_architecture.PL.Chef
{
    partial class UpdateInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInventory));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_selected_item = new System.Windows.Forms.ComboBox();
            this.btn_update_status = new System.Windows.Forms.Button();
            this.txt_stock_left = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cpb_stock_prisentage = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.pnl_title.Size = new System.Drawing.Size(529, 34);
            this.pnl_title.TabIndex = 66;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(491, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
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
            this.label14.Text = "Update Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.txt_stock_left);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_selected_item);
            this.panel1.Location = new System.Drawing.Point(15, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 166);
            this.panel1.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Stocks Left :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Inventory Items :";
            // 
            // cmb_selected_item
            // 
            this.cmb_selected_item.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_selected_item.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_selected_item.FormattingEnabled = true;
            this.cmb_selected_item.Location = new System.Drawing.Point(126, 15);
            this.cmb_selected_item.Name = "cmb_selected_item";
            this.cmb_selected_item.Size = new System.Drawing.Size(121, 21);
            this.cmb_selected_item.TabIndex = 60;
            // 
            // btn_update_status
            // 
            this.btn_update_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_update_status.Location = new System.Drawing.Point(209, 230);
            this.btn_update_status.Name = "btn_update_status";
            this.btn_update_status.Size = new System.Drawing.Size(105, 29);
            this.btn_update_status.TabIndex = 70;
            this.btn_update_status.Text = "Update Status";
            this.btn_update_status.UseVisualStyleBackColor = false;
            // 
            // txt_stock_left
            // 
            this.txt_stock_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_stock_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock_left.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_stock_left.Location = new System.Drawing.Point(126, 114);
            this.txt_stock_left.Name = "txt_stock_left";
            this.txt_stock_left.ReadOnly = true;
            this.txt_stock_left.Size = new System.Drawing.Size(100, 20);
            this.txt_stock_left.TabIndex = 67;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quantity.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_quantity.Location = new System.Drawing.Point(126, 63);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 68;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.cpb_stock_prisentage);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(331, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 210);
            this.panel3.TabIndex = 71;
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
            this.cpb_stock_prisentage.Location = new System.Drawing.Point(32, 52);
            this.cpb_stock_prisentage.MarqueeAnimationSpeed = 2000;
            this.cpb_stock_prisentage.Name = "cpb_stock_prisentage";
            this.cpb_stock_prisentage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpb_stock_prisentage.OuterMargin = -23;
            this.cpb_stock_prisentage.OuterWidth = 20;
            this.cpb_stock_prisentage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cpb_stock_prisentage.ProgressWidth = 15;
            this.cpb_stock_prisentage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpb_stock_prisentage.Size = new System.Drawing.Size(115, 103);
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
            this.cpb_stock_prisentage.Value = 68;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stocks";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Details of last 28 days";
            // 
            // UpdateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(529, 274);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_update_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateInventory";
            this.Text = "UpdateInventory";
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_selected_item;
        private System.Windows.Forms.Button btn_update_status;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_stock_left;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar cpb_stock_prisentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}