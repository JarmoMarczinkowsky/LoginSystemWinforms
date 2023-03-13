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
    public partial class Form1 : Form
    {
        private AppDbContext dbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            var loadUsers = dbContext.Users;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkLogin = dbContext.Users.Where(u => txbUser.Text == u.Email && txbPassword.Text == u.Password);
        }
    }
}
