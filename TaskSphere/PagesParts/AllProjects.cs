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
    public partial class AllProjects : UserControl
    {
        DBHelper db;
        public AllProjects()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        public string ProjectDesc { get; internal set; }
        public string ProjectTitle { get; internal set; }

        private void AllProjects_Load(object sender, EventArgs e)
        {
            AllProjectsPanel.Controls.Clear();
            db.getButtons("select * from projects",AllProjectsPanel);
        }

        private void PanelProjectsAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void projectCard2_Load(object sender, EventArgs e)
        {

        }

        private void projectCard5_Load(object sender, EventArgs e)
        {

        }

        private void projectCard6_Load(object sender, EventArgs e)
        {

        }

        private void projectCard4_Load(object sender, EventArgs e)
        {

        }

        private void projectCard3_Load(object sender, EventArgs e)
        {

        }

        private void projectCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
