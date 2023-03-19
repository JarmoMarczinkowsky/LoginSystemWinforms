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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txbChangeName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.bntRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroupUser = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddUserToGroup = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.userBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(18, 98);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 25;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1164, 234);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WindowsFormsApp1.Tables.User);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(13, 33);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(131, 25);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Welcome, ...";
            // 
            // txbChangeName
            // 
            this.txbChangeName.Location = new System.Drawing.Point(412, 347);
            this.txbChangeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbChangeName.Name = "txbChangeName";
            this.txbChangeName.Size = new System.Drawing.Size(362, 31);
            this.txbChangeName.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 411);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(285, 55);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1010, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 62);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bntRemove
            // 
            this.bntRemove.Location = new System.Drawing.Point(18, 475);
            this.bntRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntRemove.Name = "bntRemove";
            this.bntRemove.Size = new System.Drawing.Size(285, 53);
            this.bntRemove.TabIndex = 5;
            this.bntRemove.Text = "Remove";
            this.bntRemove.UseVisualStyleBackColor = true;
            this.bntRemove.Click += new System.EventHandler(this.bntRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(18, 347);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(285, 55);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(412, 391);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(362, 31);
            this.txbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Role";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(828, 14);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(172, 62);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(WindowsFormsApp1.Tables.Group);
            // 
            // cboxRole
            // 
            this.cboxRole.DataSource = this.roleBindingSource;
            this.cboxRole.DisplayMember = "Name";
            this.cboxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRole.FormattingEnabled = true;
            this.cboxRole.Location = new System.Drawing.Point(412, 436);
            this.cboxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.Size = new System.Drawing.Size(362, 33);
            this.cboxRole.TabIndex = 2;
            this.cboxRole.ValueMember = "RoleId";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(WindowsFormsApp1.Tables.Role);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AutoGenerateColumns = false;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn});
            this.dgvGroups.DataSource = this.groupBindingSource;
            this.dgvGroups.Location = new System.Drawing.Point(18, 559);
            this.dgvGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersWidth = 25;
            this.dgvGroups.RowTemplate.Height = 24;
            this.dgvGroups.Size = new System.Drawing.Size(474, 234);
            this.dgvGroups.TabIndex = 10;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dgvGroupUser
            // 
            this.dgvGroupUser.AutoGenerateColumns = false;
            this.dgvGroupUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.userIdDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn1,
            this.groupDataGridViewTextBoxColumn});
            this.dgvGroupUser.DataSource = this.groupUserBindingSource;
            this.dgvGroupUser.Location = new System.Drawing.Point(674, 559);
            this.dgvGroupUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGroupUser.Name = "dgvGroupUser";
            this.dgvGroupUser.RowHeadersWidth = 25;
            this.dgvGroupUser.RowTemplate.Height = 24;
            this.dgvGroupUser.Size = new System.Drawing.Size(458, 234);
            this.dgvGroupUser.TabIndex = 11;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Group";
            this.Group.MinimumWidth = 10;
            this.Group.Name = "Group";
            this.Group.Width = 200;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 200;
            // 
            // groupIdDataGridViewTextBoxColumn1
            // 
            this.groupIdDataGridViewTextBoxColumn1.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn1.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.groupIdDataGridViewTextBoxColumn1.Name = "groupIdDataGridViewTextBoxColumn1";
            this.groupIdDataGridViewTextBoxColumn1.Width = 200;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 200;
            // 
            // groupUserBindingSource
            // 
            this.groupUserBindingSource.DataSource = typeof(WindowsFormsApp1.Tables.GroupUser);
            // 
            // btnAddUserToGroup
            // 
            this.btnAddUserToGroup.Location = new System.Drawing.Point(526, 586);
            this.btnAddUserToGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUserToGroup.Name = "btnAddUserToGroup";
            this.btnAddUserToGroup.Size = new System.Drawing.Size(115, 55);
            this.btnAddUserToGroup.TabIndex = 6;
            this.btnAddUserToGroup.Text = ">>";
            this.btnAddUserToGroup.UseVisualStyleBackColor = true;
            this.btnAddUserToGroup.Click += new System.EventHandler(this.btnAddUserToGroup_Click);
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
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 966);
            this.Controls.Add(this.btnAddUserToGroup);
            this.Controls.Add(this.dgvGroupUser);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.bntRemove);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbChangeName);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txbChangeName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button bntRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.ComboBox cboxRole;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridView dgvGroupUser;
        private System.Windows.Forms.BindingSource groupUserBindingSource;
        private System.Windows.Forms.Button btnAddUserToGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}