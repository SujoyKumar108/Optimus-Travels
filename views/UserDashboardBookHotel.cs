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
    public partial class UserDashboardBookHotel : Form
    {
        public UserDashboardBookHotel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard();
            ud.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDashboardBookHotelBook udhb = new UserDashboardBookHotelBook();
            udhb.Show();
            this.Hide();
        }
    }
}
