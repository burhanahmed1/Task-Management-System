using SE_Project.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DashBoard dashboard = new DashBoard();
            addUserControl(dashboard);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            addUserControl(dashboard);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            addUserControl(projects);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo();
            addUserControl(toDo);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Starred starred = new Starred();
            addUserControl(starred);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
