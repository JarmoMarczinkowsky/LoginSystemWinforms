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

namespace WindowsFormsApp1
{
    public partial class GroupForm : Form
    {
        private AppDbContext dbContext;
        public GroupForm()
        {
            InitializeComponent();

            this.dbContext = new AppDbContext();

            this.dbContext.Groups.Load();
            this.dbContext.GroupUsers.Include(gu => gu.User).Load();

            this.groupBindingSource.DataSource = this.dbContext.Groups.Local.ToBindingList();
            this.groupUserBindingSource.DataSource = this.dbContext.GroupUsers.Local.ToBindingList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new DashboardForm());
        }

        private void dgvGroup_SelectionChanged(object sender, EventArgs e)
        {
            var getRow = (Group)this.dgvGroup.CurrentRow?.DataBoundItem;

            if (getRow == null)
            {
                return;
            }
            this.groupUserBindingSource.DataSource = this.dbContext.GroupUsers.Local.ToBindingList().Where(gu => gu.GroupId == getRow.GroupId);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            //insert textbox into database
            var newGroup = new Group
            {
                Name = txbGroup.Text
            };

            this.dbContext.Groups.Add(newGroup);
            this.dbContext.SaveChanges();
            dgvGroup.Refresh();
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            //edit group
            var getRow = (Group)this.dgvGroup.CurrentRow?.DataBoundItem;
            getRow.Name = txbGroup.Text;

            this.dbContext.SaveChanges();
            dgvGroup.Refresh();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            this.dbContext.Remove((Group)this.dgvGroup.CurrentRow?.DataBoundItem);
            this.dbContext.SaveChanges();
            dgvGroup.Refresh();
        }
    }
}
