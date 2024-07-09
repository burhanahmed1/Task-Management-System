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
    public partial class ProjectsCompleted : UserControl
    {
        DBHelper db;
        public ProjectsCompleted()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        private void ProjectsCompleted_Load(object sender, EventArgs e)
        {
            ProjectsCompletedPanel.Controls.Clear();
            db.getButtons("select * from completed", ProjectsCompletedPanel);
        }
    }
}
