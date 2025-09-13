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
            this.Close();
        }
    }
}
