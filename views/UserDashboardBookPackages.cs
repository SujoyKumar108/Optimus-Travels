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
    public partial class UserDashboardBookPackages : Form
    {
        public UserDashboardBookPackages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard();
            ud.Show();
            this.Hide();

        }
    }
}
