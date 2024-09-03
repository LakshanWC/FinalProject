namespace FinalProject.three_tier_architecture.PL.Customerr
{
    partial class OrderConfirmation
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txt_current_report = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(797, 392);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // txt_current_report
            // 
            this.txt_current_report.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_current_report.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_current_report.Location = new System.Drawing.Point(100, 21);
            this.txt_current_report.Name = "txt_current_report";
            this.txt_current_report.Size = new System.Drawing.Size(237, 20);
            this.txt_current_report.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Id :";
            // 
            // btn_update_details
            // 
            this.btn_update_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_update_details.FlatAppearance.BorderSize = 0;
            this.btn_update_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_update_details.Location = new System.Drawing.Point(343, 12);
            this.btn_update_details.Name = "btn_update_details";
            this.btn_update_details.Size = new System.Drawing.Size(150, 36);
            this.btn_update_details.TabIndex = 77;
            this.btn_update_details.Text = "Load";
            this.btn_update_details.UseVisualStyleBackColor = false;
            this.btn_update_details.Click += new System.EventHandler(this.btn_update_details_Click);
            // 
            // OrderConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update_details);
            this.Controls.Add(this.txt_current_report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "OrderConfirmation";
            this.Text = "OrderConfirmation";
            this.Load += new System.EventHandler(this.OrderConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txt_current_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update_details;
    }
}