namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(155, 315);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(262, 22);
            this.txbPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(155, 365);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 42);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(155, 262);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(262, 22);
            this.txbUser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUser;
    }
}

