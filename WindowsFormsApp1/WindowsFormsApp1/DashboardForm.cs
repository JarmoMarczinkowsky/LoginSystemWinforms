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

namespace WindowsFormsApp1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm indexForm = new IndexForm();
            indexForm.ShowDialog();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void API_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new Forms.ApiForm());
        }
    }
}
