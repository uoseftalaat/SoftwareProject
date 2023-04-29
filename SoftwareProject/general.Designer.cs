
namespace SoftwareProject
{
    partial class general
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
            this.user = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(245, 213);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(75, 23);
            this.user.TabIndex = 0;
            this.user.Text = "user";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(462, 213);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(75, 23);
            this.admin.TabIndex = 1;
            this.admin.Text = "admin";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.user);
            this.Name = "general";
            this.Text = "general";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button admin;
    }
}