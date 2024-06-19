namespace FinalProject.MVC
{
    partial class TostMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TostMessage));
            this.tost_color = new System.Windows.Forms.Panel();
            this.tost_icon = new System.Windows.Forms.PictureBox();
            this.tost_title = new System.Windows.Forms.Label();
            this.tost_message = new System.Windows.Forms.Label();
            this.btn_toast_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tost_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tost_color
            // 
            this.tost_color.Location = new System.Drawing.Point(-25, -1);
            this.tost_color.Name = "tost_color";
            this.tost_color.Size = new System.Drawing.Size(41, 79);
            this.tost_color.TabIndex = 0;
            // 
            // tost_icon
            // 
            this.tost_icon.Location = new System.Drawing.Point(28, 23);
            this.tost_icon.Name = "tost_icon";
            this.tost_icon.Size = new System.Drawing.Size(33, 31);
            this.tost_icon.TabIndex = 1;
            this.tost_icon.TabStop = false;
            // 
            // tost_title
            // 
            this.tost_title.AutoSize = true;
            this.tost_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tost_title.Location = new System.Drawing.Point(70, 9);
            this.tost_title.Name = "tost_title";
            this.tost_title.Size = new System.Drawing.Size(50, 16);
            this.tost_title.TabIndex = 2;
            this.tost_title.Text = "label1";
            // 
            // tost_message
            // 
            this.tost_message.AutoSize = true;
            this.tost_message.Location = new System.Drawing.Point(73, 37);
            this.tost_message.Name = "tost_message";
            this.tost_message.Size = new System.Drawing.Size(35, 13);
            this.tost_message.TabIndex = 3;
            this.tost_message.Text = "label1";
            // 
            // btn_toast_close
            // 
            this.btn_toast_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toast_close.BackgroundImage")));
            this.btn_toast_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_toast_close.FlatAppearance.BorderSize = 0;
            this.btn_toast_close.Location = new System.Drawing.Point(296, 3);
            this.btn_toast_close.Name = "btn_toast_close";
            this.btn_toast_close.Size = new System.Drawing.Size(21, 21);
            this.btn_toast_close.TabIndex = 4;
            this.btn_toast_close.UseVisualStyleBackColor = true;
            this.btn_toast_close.Click += new System.EventHandler(this.btn_toast_close_Click);
            // 
            // TostMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 76);
            this.Controls.Add(this.btn_toast_close);
            this.Controls.Add(this.tost_message);
            this.Controls.Add(this.tost_title);
            this.Controls.Add(this.tost_icon);
            this.Controls.Add(this.tost_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TostMessage";
            this.Text = "TostMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TostMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tost_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tost_color;
        private System.Windows.Forms.PictureBox tost_icon;
        private System.Windows.Forms.Label tost_title;
        private System.Windows.Forms.Label tost_message;
        private System.Windows.Forms.Button btn_toast_close;
    }
}