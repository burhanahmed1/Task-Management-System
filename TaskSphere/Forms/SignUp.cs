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
    public partial class SignUp : Form
    {
        DBHelper db = new DBHelper();

        public SignUp()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string password = guna2TextBox2.Text;

            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                string query = $"INSERT INTO userlist VALUES('{guna2TextBox1.Text.Replace("'", "''")}', '{password.Replace("'", "''")}')";

                try
                {
                    db.InsertRow(query);
                    this.Hide();
                    Main main_form = new Main();
                    main_form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password must be at least 8 characters long, contain at least one uppercase letter, and one special character.");
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
