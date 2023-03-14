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
    public partial class IndexForm : Form
    {
        private AppDbContext dbContext;

        public IndexForm()
        {
            InitializeComponent();
            
            this.dbContext = new AppDbContext();

            dbContext.Users.Load();
            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();

        }
    }
}
