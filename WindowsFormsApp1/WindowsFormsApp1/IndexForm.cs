﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class IndexForm : Form
    {
        private AppDbContext dbContext;

        public IndexForm()
        {
            InitializeComponent();
            
            this.dbContext = new AppDbContext();

            dbContext.Users
                .Include(u => u.Role)
                .Include(g => g.GroupUsers)
                .Load();

            dbContext.Roles.Load();
            dbContext.Groups.Load();
            
            

            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();
            this.groupBindingSource.DataSource = dbContext.Groups.Local.ToBindingList();
            this.groupUserBindingSource.DataSource = dbContext.GroupUsers.Local.ToBindingList();
            this.roleBindingSource.DataSource = dbContext.Roles.Local.ToBindingList();
            
            lblAccountName.Text = $"Welcome, {Global.AccountName}";

        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
            {
                return;
            }

            var selectRow = (User)this.dgvUsers.CurrentRow?.DataBoundItem;

            if (selectRow == null)
            {
                return;
            }

            cboxRole.SelectedValue = selectRow.RoleId;

            txbEmail.Text = selectRow.Email;
            txbChangeName.Text = selectRow.Name;

            //group has to be the same as the groupid in the database
            var getGroupUser = dbContext.GroupUsers.Where(gu => gu.UserId == selectRow.UserId).ToList();

            this.groupUserBindingSource.DataSource = getGroupUser;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var getData = (User)this.dgvUsers.CurrentRow?.DataBoundItem;

            //update getData
            getData.Name = txbChangeName.Text;
            getData.Email = txbEmail.Text;
            getData.RoleId = Convert.ToInt32(cboxRole.SelectedValue);

            this.dbContext.SaveChanges();
            dgvUsers.Refresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void bntRemove_Click(object sender, EventArgs e)
        {
            var getName = (User)this.dgvUsers.CurrentRow?.DataBoundItem;
            this.dbContext.Users.Remove(getName);
           
            this.dbContext.SaveChanges();
            dgvUsers.Refresh();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var getRole = (Role)this.cboxRole.SelectedItem;
            var getGroup = (Tables.Group)this.dgvGroups.CurrentRow?.DataBoundItem;

            //insert into database and refresh datagridview 
            var insertUser = new User()
            {
                Name = txbChangeName.Text,
                Email = txbEmail.Text,
                Password = AppDbContext.EncryptPassword("test"),
                RoleId = getRole.RoleId,
            };

            var insertGroupUser = new GroupUser()
            {
                GroupId = (uint)getGroup.GroupId,//(uint)cboxGroup.SelectedValue,
                UserId = (uint)insertUser.UserId
            };

            insertUser.GroupUsers.Add(insertGroupUser);
            this.dbContext.Users.Add(insertUser);

            //add insertgroupuser to usergroup table

            this.dbContext.SaveChanges();

            dgvUsers.Refresh();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new DashboardForm());
        }

        private void btnAddUserToGroup_Click(object sender, EventArgs e)
        {
            var getUser = (User)this.dgvUsers.CurrentRow?.DataBoundItem;
            var getGroup = (Tables.Group)this.dgvGroups.CurrentRow?.DataBoundItem;

            var insertGroupUser = new GroupUser()
            {
                GroupId = (uint)getGroup.GroupId,
                UserId = (uint)getUser.UserId
            };

            getUser.GroupUsers.Add(insertGroupUser);

            this.dbContext.SaveChanges();
            dgvGroupUser.Refresh();

        }
    }
}
