namespace WindowsFormsApp1.Forms
{
    partial class ApiForm
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
            this.pboxApi = new System.Windows.Forms.PictureBox();
            this.btnGetApi = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxApi)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxApi
            // 
            this.pboxApi.Location = new System.Drawing.Point(414, 124);
            this.pboxApi.Name = "pboxApi";
            this.pboxApi.Size = new System.Drawing.Size(413, 335);
            this.pboxApi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxApi.TabIndex = 0;
            this.pboxApi.TabStop = false;
            this.pboxApi.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pboxApi_LoadProgressChanged);
            // 
            // btnGetApi
            // 
            this.btnGetApi.Location = new System.Drawing.Point(90, 241);
            this.btnGetApi.Name = "btnGetApi";
            this.btnGetApi.Size = new System.Drawing.Size(210, 71);
            this.btnGetApi.TabIndex = 1;
            this.btnGetApi.Text = "Get image of fox";
            this.btnGetApi.UseVisualStyleBackColor = true;
            this.btnGetApi.Click += new System.EventHandler(this.btnGetApi_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(578, 14);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(172, 62);
            this.btnDashboard.TabIndex = 17;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(758, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 62);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(409, 462);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 25);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status...";
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 513);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGetApi);
            this.Controls.Add(this.pboxApi);
            this.Name = "ApiForm";
            this.Text = "ApiForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboxApi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxApi;
        private System.Windows.Forms.Button btnGetApi;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblStatus;
    }
}