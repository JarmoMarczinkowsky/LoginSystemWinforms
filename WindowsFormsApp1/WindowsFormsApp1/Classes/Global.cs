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
            AccountName = "";

            currentForm.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            currentForm.Close();
        }
    }
}
