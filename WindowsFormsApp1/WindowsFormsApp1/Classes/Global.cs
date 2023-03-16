using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
    static class Global
    {
        public static string AccountName { get; set; }

        public static void Logout(Form currentForm)
        {
            currentForm.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();
            currentForm.Close();
        }
    }
}
