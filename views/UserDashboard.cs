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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                UserDashboardBookHotel bh = new UserDashboardBookHotel();
                bh.Show();
                this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDashboardBookPackages udbp = new UserDashboardBookPackages();
            udbp.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDashboardShowProfile udsp = new UserDashboardShowProfile();
            udsp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
