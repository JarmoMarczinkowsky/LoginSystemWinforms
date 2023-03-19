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
using WindowsFormsApp1.Img;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.Forms
{
    public partial class ApiForm : Form
    {
        public ApiForm()
        {
            InitializeComponent();

            lblStatus.Text = "";
        }

        private void btnGetApi_Click(object sender, EventArgs e)
        {
            pboxApi.Image = Images.ProcesCatCrop;
            lblStatus.Text = "loading...";

            //get api from url
            string url = "https://randomfox.ca/floof/";
            var json = new WebClient().DownloadString(url);
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

            pboxApi.ImageLocation = myDeserializedClass.image;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new DashboardForm());
        }

        private void pboxApi_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "";
        }
    }
}
