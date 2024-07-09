using SE_Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project.Forms
{
    public partial class Login : Form
    {
        DBHelper db = new DBHelper();
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (db.userAuth(guna2TextBox1.Text, guna2TextBox2.Text))
            {
                this.Hide();
                Main main_form = new Main();
                main_form.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.Show();
        }
    }
}
