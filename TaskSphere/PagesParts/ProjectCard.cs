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

namespace SE_Project.PagesParts
{
    public partial class ProjectCard : UserControl
    {
        DBHelper db;
        public ProjectCard()
        {
            InitializeComponent();
            db = new DBHelper();
        }
        public string ProjectTitle
        {
            get { return CardTitle.Text; }
            set { CardTitle.Text = value; }
        }
        public string ProjectDesc
        {
            get { return CardDesc.Text; }
            set { CardDesc.Text = value; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = guna2ComboBox1.Text.Replace(" ", "").ToLower();
            string query = $"insert into {tableName} values('{CardTitle.Text}','{CardDesc.Text}')";
            db.InsertRow(query);
            MessageBox.Show("Operation Successful");
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string tableName = "starred";
            string query = $"insert into {tableName} values('{CardTitle.Text}','{CardDesc.Text}')";
            db.InsertRow(query);
            MessageBox.Show("Operation Successful");
        }
    }
}
