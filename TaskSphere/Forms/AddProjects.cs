using Guna.UI2.WinForms;
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
    public partial class AddProjects : UserControl
    {
        DBHelper db = new DBHelper(); // Instantiate the DBHelper class

        public event EventHandler RequestPanelBack;
        public AddProjects()
        {
            InitializeComponent();
           
            this.guna2ImageButton1.Click += guna2ImageButton1_Click;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Use Dispose if you want to completely remove the UserControl
            RequestPanelBack?.Invoke(this, EventArgs.Empty);

        }

        private void AddProjects_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = "projects";
                string query = $"INSERT INTO {tableName} VALUES('{guna2TextBox1.Text}', '{guna2TextBox2.Text}')";
                db.InsertRow(query);
                MessageBox.Show("Project Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
