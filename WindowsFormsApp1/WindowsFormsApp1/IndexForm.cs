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

            dbContext.Users.Include(u => u.Role).Load();
            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();

            lblAccountName.Text = Form1.myAccountName;


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

            this.dbContext.SaveChanges();
            dgvUsers.Refresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //open form1 and close this form
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();

            //clear variable myaccoutname
            Form1.myAccountName = "";

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
                RoleId = 2
            };

            this.dbContext.Users.Add(insertUser);
            this.dbContext.SaveChanges();

            dgvUsers.Refresh();
        }
    }
}
