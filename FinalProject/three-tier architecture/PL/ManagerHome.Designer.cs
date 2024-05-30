namespace FinalProject.MVC.View
{
    partial class ManagerHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordResetRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_pass_reset_requests = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pass_reset_requests)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addFoodItemToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addFoodItemToolStripMenuItem
            // 
            this.addFoodItemToolStripMenuItem.Name = "addFoodItemToolStripMenuItem";
            this.addFoodItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFoodItemToolStripMenuItem.Text = "Add Food Item";
            this.addFoodItemToolStripMenuItem.Click += new System.EventHandler(this.addFoodItemToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttendentsToolStripMenuItem,
            this.passwordResetRequestsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewAttendentsToolStripMenuItem
            // 
            this.viewAttendentsToolStripMenuItem.Name = "viewAttendentsToolStripMenuItem";
            this.viewAttendentsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewAttendentsToolStripMenuItem.Text = "View Attendents";
            // 
            // passwordResetRequestsToolStripMenuItem
            // 
            this.passwordResetRequestsToolStripMenuItem.Name = "passwordResetRequestsToolStripMenuItem";
            this.passwordResetRequestsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.passwordResetRequestsToolStripMenuItem.Text = "Password reset requests";
            this.passwordResetRequestsToolStripMenuItem.Click += new System.EventHandler(this.passwordResetRequestsToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeEmployeeToolStripMenuItem,
            this.removeFoodItemToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.removeEmployeeToolStripMenuItem_Click);
            // 
            // removeFoodItemToolStripMenuItem
            // 
            this.removeFoodItemToolStripMenuItem.Name = "removeFoodItemToolStripMenuItem";
            this.removeFoodItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeFoodItemToolStripMenuItem.Text = "Remove Food Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Reset Requestes :";
            // 
            // nud_pass_reset_requests
            // 
            this.nud_pass_reset_requests.Location = new System.Drawing.Point(720, 424);
            this.nud_pass_reset_requests.Name = "nud_pass_reset_requests";
            this.nud_pass_reset_requests.ReadOnly = true;
            this.nud_pass_reset_requests.Size = new System.Drawing.Size(68, 20);
            this.nud_pass_reset_requests.TabIndex = 4;
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_pass_reset_requests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerHome";
            this.Text = "ManagerHome";
            this.Load += new System.EventHandler(this.ManagerHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pass_reset_requests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordResetRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFoodItemToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_pass_reset_requests;
    }
}