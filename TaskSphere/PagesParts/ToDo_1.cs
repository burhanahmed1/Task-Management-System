using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE_Project.Helpers;

namespace SE_Project.PagesParts
{
    public partial class ToDo_1 : UserControl
    {
        DBHelper db;
        public ToDo_1()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        private void ToDo_1_Load(object sender, EventArgs e)
        {
            ToDoPanel.Controls.Clear();
            string query = @"INSERT INTO todolist (name, description) 
                SELECT name, description 
                FROM projects AS p 
                WHERE NOT EXISTS (
                    SELECT 1 
                    FROM completed AS c 
                    WHERE c.name = p.name
                ) 
                AND NOT EXISTS (
                    SELECT 1 
                    FROM inprogress AS ip 
                    WHERE ip.name = p.name
                )
                AND NOT EXISTS (
                    SELECT 1 
                    FROM todolist AS t 
                    WHERE t.name = p.name AND t.description = p.description
                );";

            db.InsertRow(query);
            db.getButtons("select * from todolist", ToDoPanel);
        }

        private void ToDoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
