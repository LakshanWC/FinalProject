namespace FinalProject.three_tier_architecture.PL.Customerr
{
    partial class Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_review_score = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_no_of_letters = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_selected_item = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_priveous = new System.Windows.Forms.Button();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_review_count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_review_score)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.nud_review_score);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_no_of_letters);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_selected_item);
            this.panel1.Location = new System.Drawing.Point(14, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 329);
            this.panel1.TabIndex = 62;
            // 
            // nud_review_score
            // 
            this.nud_review_score.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nud_review_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_review_score.ForeColor = System.Drawing.SystemColors.Info;
            this.nud_review_score.Location = new System.Drawing.Point(126, 65);
            this.nud_review_score.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_review_score.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_review_score.Name = "nud_review_score";
            this.nud_review_score.ReadOnly = true;
            this.nud_review_score.Size = new System.Drawing.Size(77, 20);
            this.nud_review_score.TabIndex = 66;
            this.nud_review_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_review_score.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Review Score :";
            // 
            // lbl_no_of_letters
            // 
            this.lbl_no_of_letters.AutoSize = true;
            this.lbl_no_of_letters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_no_of_letters.Location = new System.Drawing.Point(391, 270);
            this.lbl_no_of_letters.Name = "lbl_no_of_letters";
            this.lbl_no_of_letters.Size = new System.Drawing.Size(36, 13);
            this.lbl_no_of_letters.TabIndex = 64;
            this.lbl_no_of_letters.Text = "0/500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Review Descrpition :";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_description.Location = new System.Drawing.Point(126, 116);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(301, 138);
            this.txt_description.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Select Item :";
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
            this.cmb_selected_item.SelectedIndexChanged += new System.EventHandler(this.cmb_selected_item_SelectedIndexChanged);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_next.Location = new System.Drawing.Point(364, 394);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 44);
            this.btn_next.TabIndex = 63;
            this.btn_next.Text = "Next ";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_priveous
            // 
            this.btn_priveous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_priveous.FlatAppearance.BorderSize = 0;
            this.btn_priveous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_priveous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priveous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_priveous.Location = new System.Drawing.Point(258, 394);
            this.btn_priveous.Name = "btn_priveous";
            this.btn_priveous.Size = new System.Drawing.Size(100, 44);
            this.btn_priveous.TabIndex = 64;
            this.btn_priveous.Text = "Previous";
            this.btn_priveous.UseVisualStyleBackColor = false;
            this.btn_priveous.Click += new System.EventHandler(this.btn_priveous_Click);
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label6);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(479, 34);
            this.pnl_title.TabIndex = 65;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            this.pnl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseMove);
            this.pnl_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(441, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseMove);
            this.btn_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Review";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(27, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "No of Reviews :";
            // 
            // lbl_review_count
            // 
            this.lbl_review_count.AutoSize = true;
            this.lbl_review_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_review_count.Location = new System.Drawing.Point(121, 410);
            this.lbl_review_count.Name = "lbl_review_count";
            this.lbl_review_count.Size = new System.Drawing.Size(13, 13);
            this.lbl_review_count.TabIndex = 72;
            this.lbl_review_count.Text = "0";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.lbl_review_count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.btn_priveous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_review_score)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nud_review_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_no_of_letters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_selected_item;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_priveous;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_review_count;
    }
}