using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimus_Travels.views
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if(this.Owner != null)
            {
                this.Owner.Hide();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Cookie.ClearCookie();
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageUsers am = new AdminManageUsers();
            am.Show(owner: this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManageHotels amh = new AdminManageHotels();
            amh.Show(owner: this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminManagePackages amp = new AdminManagePackages();
            amp.Show(owner: this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminManagePackages ame = new AdminManagePackages();
            ame.Show(owner: this);

        }
    }
}
