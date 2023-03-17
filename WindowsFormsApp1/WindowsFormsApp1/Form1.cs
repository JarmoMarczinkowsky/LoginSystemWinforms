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
    public partial class Form1 : Form
    {
        private AppDbContext dbContext;

        //private string _accountName;
        //public string MyAccount
        //{
        //    get { return _accountName; }
        //    set { _accountName = value; }
        //}

        //public static string myAccountName = "";

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

            var checkLogin = dbContext.Users.Where(u => txbUser.Text == u.Email && CheckPassword(txbPassword.Text, getPass.Password)).FirstOrDefault();
            
            if (checkLogin != null)
            {
                lblError.Text = "Login gelukt";

                Global.AccountName = txbUser.Text;

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

        public bool CheckPassword(string password, string hashedPassword)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hash == hashedPassword;
            }
        }
    }
}
