namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    partial class FinancialReview
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
            this.cmb_seleted_filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 53);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Sales&Fi" +
    "nance\\FinancialExpenseReport.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(798, 396);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cmb_seleted_filter
            // 
            this.cmb_seleted_filter.FormattingEnabled = true;
            this.cmb_seleted_filter.Items.AddRange(new object[] {
            "All",
            "Monthly",
            "Yearly"});
            this.cmb_seleted_filter.Location = new System.Drawing.Point(81, 12);
            this.cmb_seleted_filter.Name = "cmb_seleted_filter";
            this.cmb_seleted_filter.Size = new System.Drawing.Size(121, 21);
            this.cmb_seleted_filter.TabIndex = 1;
            this.cmb_seleted_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_seleted_filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter :";
            // 
            // FinancialReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_seleted_filter);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FinancialReview";
            this.Text = "FinancialReview";
            this.Load += new System.EventHandler(this.FinancialReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cmb_seleted_filter;
        private System.Windows.Forms.Label label1;
    }
}