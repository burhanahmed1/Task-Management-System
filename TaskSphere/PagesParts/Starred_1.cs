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
    public partial class Starred_1 : UserControl
    {
        DBHelper db;
        public Starred_1()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        private void Starred_Load(object sender, EventArgs e)
        {
            StarredPanel.Controls.Clear();
            db.getButtons("select * from starred", StarredPanel);
        }
    }
}
