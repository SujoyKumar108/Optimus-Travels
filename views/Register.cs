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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            string contact = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox5.Text;
            string repassword = textBox6.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repassword))
            {
                MessageBox.Show("Fill all the Fields.");
                return;
            }

            if(password != repassword)
            {
                MessageBox.Show("Password and Re-Password must be same.");
                return;
            }
            controller.RegisterController rc = new controller.RegisterController();
            if (rc.Register(name, address, contact, email, password))
            {
                MessageBox.Show("Registration Successful");
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration Failed. Try Again.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if(this.Owner != null)
            {
                this.Owner.Hide();
            }
        }
    }
}
