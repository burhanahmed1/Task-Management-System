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

namespace SE_Project.Pages
{

    public partial class DashBoard : UserControl
    {
        DBHelper db;
        public DashBoard()
        {

            InitializeComponent();
            db = new DBHelper();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            int count = db.GetTotalRowCount("projects");

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
