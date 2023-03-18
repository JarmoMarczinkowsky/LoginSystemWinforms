using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class ApiForm : Form
    {
        public ApiForm()
        {
            InitializeComponent();
        }

        private void btnGetApi_Click(object sender, EventArgs e)
        {
            //get api from url
            string url = "https://randomfox.ca/floof/";
            var json = new WebClient().DownloadString(url);
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

            //show image from api in picturebox
            pboxApi.ImageLocation = myDeserializedClass.image;
            //pbxApi.Image = new Bitmap(myDeserializedClass.image);


            //pboxApi.Image = new Bitmap(myDeserializedClass.image);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new DashboardForm());
        }
    }
}
