namespace FinalProject.three_tier_architecture.PL
{
    partial class GenerateReportUi
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
            this.AttendentReport1 = new FinalProject.three_tier_architecture.PL.AttendentReport();
            this.cmb_reports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_current_report = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 58);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Attenden" +
    "tReport.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(784, 392);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cmb_reports
            // 
            this.cmb_reports.FormattingEnabled = true;
            this.cmb_reports.Items.AddRange(new object[] {
            "Attendent Report",
            "Income Report"});
            this.cmb_reports.Location = new System.Drawing.Point(554, 19);
            this.cmb_reports.Name = "cmb_reports";
            this.cmb_reports.Size = new System.Drawing.Size(121, 21);
            this.cmb_reports.TabIndex = 1;
            this.cmb_reports.SelectedIndexChanged += new System.EventHandler(this.cmb_reports_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(425, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Report :";
            // 
            // txt_current_report
            // 
            this.txt_current_report.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_current_report.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_current_report.Location = new System.Drawing.Point(127, 20);
            this.txt_current_report.Name = "txt_current_report";
            this.txt_current_report.Size = new System.Drawing.Size(113, 20);
            this.txt_current_report.TabIndex = 5;
            // 
            // GenerateReportUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.txt_current_report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_reports);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "GenerateReportUi";
            this.Text = "ReportUi";
            this.Load += new System.EventHandler(this.ReportUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private AttendentReport AttendentReport1;
        private System.Windows.Forms.ComboBox cmb_reports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_current_report;
    }
}