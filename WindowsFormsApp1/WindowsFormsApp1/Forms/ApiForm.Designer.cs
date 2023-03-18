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
            ((System.ComponentModel.ISupportInitialize)(this.pboxApi)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxApi
            // 
            this.pboxApi.Location = new System.Drawing.Point(429, 91);
            this.pboxApi.Name = "pboxApi";
            this.pboxApi.Size = new System.Drawing.Size(413, 335);
            this.pboxApi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxApi.TabIndex = 0;
            this.pboxApi.TabStop = false;
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
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 513);
            this.Controls.Add(this.btnGetApi);
            this.Controls.Add(this.pboxApi);
            this.Name = "ApiForm";
            this.Text = "ApiForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboxApi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxApi;
        private System.Windows.Forms.Button btnGetApi;
    }
}