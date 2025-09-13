using Optimus_Travels.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimus_Travels.views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill all the Fields.");
                return;
            }
            
            if (LoginController.login(email, password))
            {
                MessageBox.Show("Log in Successful", "Logged IN");
                Form dashboard = null;

                switch (Cookie.Role.ToLower())
                {
                    case "user":
                        dashboard = new UserDashboard();
                        break;
                    case "admin":
                        dashboard = new AdminDashboard();
                        break;
                    case "employee":
                        dashboard = new EmployeeDashboard();
                        break;
                    default:
                        MessageBox.Show("Invalid role.");
                        return;
                }

                if (dashboard != null)
                {
                    dashboard.Show(this);
                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid", "Wrong INPUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            timer1.Stop();
        }
    }
}
