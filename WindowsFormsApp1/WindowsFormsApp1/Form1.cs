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

        //private string _accountName;
        //public string MyAccount
        //{
        //    get { return _accountName; }
        //    set { _accountName = value; }
        //}

        public static string myAccountName = "";

        public Form1()
        {
            InitializeComponent();

            lblError.Text = "";

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
            //decrypt password from database
            var getPass = dbContext.Users.Where(u => txbUser.Text == u.Email).FirstOrDefault();
            var decryptGetPass = BCrypt.Net.BCrypt.Verify(txbPassword.Text, getPass.Password);


            var checkLogin = dbContext.Users.Where(u => txbUser.Text == u.Email && decryptGetPass).FirstOrDefault();
            if (checkLogin != null)
            {
                lblError.Text = "Login gelukt";

                //MyAccount = txbUser.Text;
                myAccountName = txbUser.Text;

                //go to IndexForm and close current form

                this.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Text = "Login gefaald";
            }




        }
    }
}
