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
    public partial class ProjectsInProgress : UserControl
    {
        DBHelper db;
        public ProjectsInProgress()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        private void ProjectsInProgress_Load(object sender, EventArgs e)
        {
            ProjectsInProgressPanel.Controls.Clear();
            db.getButtons("select * from inprogress", ProjectsInProgressPanel);
        }
    }
}
