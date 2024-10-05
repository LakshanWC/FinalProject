namespace FinalProject.three_tier_architecture.PL.Customerr
{
    partial class RequestAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestAssistant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_request_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_no_of_letters = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tbl_names = new System.Windows.Forms.ComboBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.cmb_request_type);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_no_of_letters);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_tbl_names);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 319);
            this.panel1.TabIndex = 62;
            // 
            // cmb_request_type
            // 
            this.cmb_request_type.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_request_type.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_request_type.FormattingEnabled = true;
            this.cmb_request_type.Items.AddRange(new object[] {
            "--Select---",
            "Order Assistance",
            "Dietary Requests",
            "Accessibility Needs",
            "Complaint"});
            this.cmb_request_type.Location = new System.Drawing.Point(126, 62);
            this.cmb_request_type.Name = "cmb_request_type";
            this.cmb_request_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_request_type.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Request Type : ";
            // 
            // lbl_no_of_letters
            // 
            this.lbl_no_of_letters.AutoSize = true;
            this.lbl_no_of_letters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.lbl_no_of_letters.Location = new System.Drawing.Point(391, 275);
            this.lbl_no_of_letters.Name = "lbl_no_of_letters";
            this.lbl_no_of_letters.Size = new System.Drawing.Size(36, 13);
            this.lbl_no_of_letters.TabIndex = 64;
            this.lbl_no_of_letters.Text = "0/500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Descrpition :";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_description.Location = new System.Drawing.Point(126, 116);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(301, 138);
            this.txt_description.TabIndex = 62;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Table No :";
            // 
            // cmb_tbl_names
            // 
            this.cmb_tbl_names.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_tbl_names.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_tbl_names.FormattingEnabled = true;
            this.cmb_tbl_names.Location = new System.Drawing.Point(126, 15);
            this.cmb_tbl_names.Name = "cmb_tbl_names";
            this.cmb_tbl_names.Size = new System.Drawing.Size(121, 21);
            this.cmb_tbl_names.TabIndex = 60;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_order.Location = new System.Drawing.Point(390, 402);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 36);
            this.btn_order.TabIndex = 63;
            this.btn_order.Text = "Request";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Controls.Add(this.label14);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(479, 34);
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
            this.btn_close.Location = new System.Drawing.Point(442, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 43;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseMove);
            this.btn_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Request Assistants";
            // 
            // RequestAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestAssistant";
            this.Text = "AssistantRequest";
            this.Load += new System.EventHandler(this.RequestAssistant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_no_of_letters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tbl_names;
        private System.Windows.Forms.ComboBox cmb_request_type;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label14;
    }
}