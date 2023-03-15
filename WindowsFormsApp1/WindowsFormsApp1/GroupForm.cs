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
            this.groupBindingSource.DataSource = this.dbContext.Groups.Local.ToBindingList();
        }
    }
}
