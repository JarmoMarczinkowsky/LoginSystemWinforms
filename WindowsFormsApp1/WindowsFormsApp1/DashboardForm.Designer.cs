namespace WindowsFormsApp1
{
    partial class DashboardForm
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.API = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(18, 19);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(208, 73);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1010, 19);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 62);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(236, 19);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(208, 73);
            this.btnGroup.TabIndex = 2;
            this.btnGroup.Text = "Groups";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // API
            // 
            this.API.Location = new System.Drawing.Point(463, 19);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(208, 73);
            this.API.TabIndex = 3;
            this.API.Text = "API";
            this.API.UseVisualStyleBackColor = true;
            this.API.Click += new System.EventHandler(this.API_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.API);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button API;
    }
}