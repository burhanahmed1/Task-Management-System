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
    public partial class DeleteProjects : UserControl
    {
        DBHelper db; // Instantiate the DBHelper class
        public event EventHandler RequestPanelBack;
        public DeleteProjects()
        {
            InitializeComponent();
            db = new DBHelper();
            this.guna2ImageButton1.Click += guna2ImageButton1_Click;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Use Dispose if you want to completely remove the UserControl
            RequestPanelBack?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteProjects_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string tableName = "projects";
            string tableName1 = "completed";
            string tableName2 = "inprogress";
            string tableName3 = "todolist";
            string tableName4 = "starred";

            string query = $"DELETE FROM {tableName} WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query);

            string query1 = $"DELETE FROM {tableName1} WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query1);

            string query2 = $"DELETE FROM {tableName2} WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query2);

            string query3 = $"DELETE FROM {tableName3} WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query3);

            string query4 = $"DELETE FROM {tableName4} WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query4);

            MessageBox.Show("If the Project name exists in the database it will be deleted successfully");
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
