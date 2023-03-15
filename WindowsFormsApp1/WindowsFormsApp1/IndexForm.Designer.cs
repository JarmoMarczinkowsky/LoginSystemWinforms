namespace WindowsFormsApp1
{
    partial class IndexForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txbChangeName = new System.Windows.Forms.TextBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.userBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(49, 46);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(629, 150);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "UserId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(194, 312);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(44, 16);
            this.lblSelectName.TabIndex = 1;
            this.lblSelectName.Text = "label1";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(541, 9);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(44, 16);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "label1";
            // 
            // txbChangeName
            // 
            this.txbChangeName.Location = new System.Drawing.Point(197, 331);
            this.txbChangeName.Name = "txbChangeName";
            this.txbChangeName.Size = new System.Drawing.Size(190, 22);
            this.txbChangeName.TabIndex = 3;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(197, 359);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(190, 35);
            this.btnChangeName.TabIndex = 4;
            this.btnChangeName.Text = "button1";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WindowsFormsApp1.Tables.User);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 41);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.txbChangeName);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.dgvUsers);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txbChangeName;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnLogout;
    }
}