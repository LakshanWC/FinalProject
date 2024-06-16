namespace FinalProject.MVC.View
{
    partial class PManagerHome
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
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_pass_reset_requests = new System.Windows.Forms.NumericUpDown();
            this.dgv_quick_details = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_get_attendends = new System.Windows.Forms.Button();
            this.btn_get_pass_requests = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pass_reset_requests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quick_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reportsToolStripMenuItem});
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
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addFoodItemToolStripMenuItem
            // 
            this.addFoodItemToolStripMenuItem.Name = "addFoodItemToolStripMenuItem";
            this.addFoodItemToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
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
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.removeEmployeeToolStripMenuItem_Click);
            // 
            // removeFoodItemToolStripMenuItem
            // 
            this.removeFoodItemToolStripMenuItem.Name = "removeFoodItemToolStripMenuItem";
            this.removeFoodItemToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeFoodItemToolStripMenuItem.Text = "Remove Food Item";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEmployeeDetailsToolStripMenuItem,
            this.updateMenuToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // updateEmployeeDetailsToolStripMenuItem
            // 
            this.updateEmployeeDetailsToolStripMenuItem.Name = "updateEmployeeDetailsToolStripMenuItem";
            this.updateEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.updateEmployeeDetailsToolStripMenuItem.Text = "Update Employee Details";
            // 
            // updateMenuToolStripMenuItem
            // 
            this.updateMenuToolStripMenuItem.Name = "updateMenuToolStripMenuItem";
            this.updateMenuToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.updateMenuToolStripMenuItem.Text = "Update Menu";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
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
            // dgv_quick_details
            // 
            this.dgv_quick_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quick_details.Location = new System.Drawing.Point(269, 45);
            this.dgv_quick_details.Name = "dgv_quick_details";
            this.dgv_quick_details.Size = new System.Drawing.Size(498, 290);
            this.dgv_quick_details.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_get_attendends);
            this.groupBox1.Controls.Add(this.btn_get_pass_requests);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 393);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Buttons";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_get_attendends
            // 
            this.btn_get_attendends.Location = new System.Drawing.Point(27, 95);
            this.btn_get_attendends.Name = "btn_get_attendends";
            this.btn_get_attendends.Size = new System.Drawing.Size(181, 23);
            this.btn_get_attendends.TabIndex = 1;
            this.btn_get_attendends.Text = "View Attendends";
            this.btn_get_attendends.UseVisualStyleBackColor = true;
            this.btn_get_attendends.Click += new System.EventHandler(this.btn_get_attendends_Click);
            // 
            // btn_get_pass_requests
            // 
            this.btn_get_pass_requests.Location = new System.Drawing.Point(27, 45);
            this.btn_get_pass_requests.Name = "btn_get_pass_requests";
            this.btn_get_pass_requests.Size = new System.Drawing.Size(181, 23);
            this.btn_get_pass_requests.TabIndex = 0;
            this.btn_get_pass_requests.Text = "View Password Reset Requests";
            this.btn_get_pass_requests.UseVisualStyleBackColor = true;
            this.btn_get_pass_requests.Click += new System.EventHandler(this.btn_get_pass_requests_Click);
            // 
            // PManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_quick_details);
            this.Controls.Add(this.nud_pass_reset_requests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PManagerHome";
            this.Text = "ManagerHome";
            this.Load += new System.EventHandler(this.ManagerHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pass_reset_requests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quick_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_quick_details;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_get_attendends;
        private System.Windows.Forms.Button btn_get_pass_requests;
    }
}