using Microsoft.EntityFrameworkCore;
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
                .Include(g => g.Group)
                .Load();

            dbContext.Roles.Load();
            dbContext.Groups.Load();

            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();
            this.groupBindingSource.DataSource = dbContext.Groups.Local.ToBindingList();
            this.roleBindingSource.DataSource = dbContext.Roles.Local.ToBindingList();

            this.userBindingSource1.DataSource = dbContext.Groups.Local.ToBindingList();

            lblAccountName.Text = Global.AccountName;


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

            cboxGroup.SelectedValue = selectRow.GroupId;
            cboxRole.SelectedValue = selectRow.RoleId;

            lblSelectName.Text = selectRow.Role.Name;
            txbChangeName.Text = selectRow.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var getData = (User)this.dgvUsers.CurrentRow?.DataBoundItem;

            //update getData
            getData.Name = txbChangeName.Text;
            getData.Email = txbEmail.Text;
            getData.RoleId = Convert.ToInt32(txbRole.Text);
            getData.GroupId = Convert.ToInt32(cboxGroup.SelectedValue);

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
            //insert into database and refresh datagridview 
            var insertUser = new User()
            {
                Name = txbChangeName.Text,
                Email = txbEmail.Text,
                Password = BCrypt.Net.BCrypt.HashPassword("test"),
                RoleId = 2,
                GroupId = 1
            };

            var insertGroupUser = new GroupUser()
            {
                GroupId = (uint)cboxGroup.SelectedValue,
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
    }
}
