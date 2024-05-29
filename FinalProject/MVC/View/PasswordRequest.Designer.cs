namespace FinalProject.MVC.View
{
    partial class PasswordRequest
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
            this.dgv_pass_requests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pass_requests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pass_requests
            // 
            this.dgv_pass_requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pass_requests.Location = new System.Drawing.Point(254, 37);
            this.dgv_pass_requests.Name = "dgv_pass_requests";
            this.dgv_pass_requests.Size = new System.Drawing.Size(508, 317);
            this.dgv_pass_requests.TabIndex = 0;
            // 
            // PasswordRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_pass_requests);
            this.Name = "PasswordRequest";
            this.Text = "PasswordRequest";
            this.Load += new System.EventHandler(this.PasswordRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pass_requests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pass_requests;
    }
}