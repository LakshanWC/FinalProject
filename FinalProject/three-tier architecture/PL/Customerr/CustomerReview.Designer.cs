namespace FinalProject.three_tier_architecture.PL.Customerr
{
    partial class CustomerReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReview));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_post = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_review_score = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_no_of_letters = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_selected_item = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cutomer_id = new System.Windows.Forms.TextBox();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_review_score)).BeginInit();
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
            this.pnl_title.Size = new System.Drawing.Size(471, 34);
            this.pnl_title.TabIndex = 52;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(435, 6);
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
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Customer Review";
            // 
            // btn_post
            // 
            this.btn_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_post.FlatAppearance.BorderSize = 0;
            this.btn_post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_post.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_post.Location = new System.Drawing.Point(383, 386);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 36);
            this.btn_post.TabIndex = 60;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = false;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.txt_cutomer_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nud_review_score);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_no_of_letters);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_selected_item);
            this.panel1.Location = new System.Drawing.Point(9, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 329);
            this.panel1.TabIndex = 61;
            // 
            // nud_review_score
            // 
            this.nud_review_score.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nud_review_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_review_score.ForeColor = System.Drawing.SystemColors.Info;
            this.nud_review_score.Location = new System.Drawing.Point(126, 109);
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
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Review Score :";
            // 
            // lbl_no_of_letters
            // 
            this.lbl_no_of_letters.AutoSize = true;
            this.lbl_no_of_letters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_no_of_letters.Location = new System.Drawing.Point(391, 305);
            this.lbl_no_of_letters.Name = "lbl_no_of_letters";
            this.lbl_no_of_letters.Size = new System.Drawing.Size(36, 13);
            this.lbl_no_of_letters.TabIndex = 64;
            this.lbl_no_of_letters.Text = "0/500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(15, 154);
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
            this.txt_description.Location = new System.Drawing.Point(126, 154);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(301, 138);
            this.txt_description.TabIndex = 62;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            this.txt_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_description_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 71);
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
            this.cmb_selected_item.Location = new System.Drawing.Point(126, 65);
            this.cmb_selected_item.Name = "cmb_selected_item";
            this.cmb_selected_item.Size = new System.Drawing.Size(121, 21);
            this.cmb_selected_item.TabIndex = 60;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_clear.Location = new System.Drawing.Point(292, 386);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 36);
            this.btn_clear.TabIndex = 62;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(15, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Cutomer Id :";
            // 
            // txt_cutomer_id
            // 
            this.txt_cutomer_id.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_cutomer_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cutomer_id.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_cutomer_id.Location = new System.Drawing.Point(126, 17);
            this.txt_cutomer_id.Name = "txt_cutomer_id";
            this.txt_cutomer_id.ReadOnly = true;
            this.txt_cutomer_id.Size = new System.Drawing.Size(102, 20);
            this.txt_cutomer_id.TabIndex = 68;
            // 
            // CustomerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(471, 434);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerReview";
            this.Text = "CustomerReview";
            this.Load += new System.EventHandler(this.CustomerReview_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_review_score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nud_review_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_no_of_letters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_selected_item;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cutomer_id;
    }
}