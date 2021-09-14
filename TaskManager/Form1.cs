using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetColumnsName()
        {
            task_viewer.Columns[0].Text = "Num";
            task_viewer.Columns[1].Text = "Category";
            task_viewer.Columns[2].Text = "Task";
            task_viewer.Columns[3].Text = "Short description";
            task_viewer.Columns[4].Text = "Status";
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int currentSort = e.Column;
            resetColumnsName();
            switch (currentSort)
            {
                case 0:
                    task_viewer.Columns[0].Text = "Num↓";
                    break;
                case 1:
                    task_viewer.Columns[1].Text = "Category↓";
                    break;
                case 2:
                    task_viewer.Columns[2].Text = "Task↓";
                    break;
                case 3:
                    task_viewer.Columns[3].Text = "Short description↓";
                    break;
                case 4:
                    task_viewer.Columns[4].Text = "Status↓";
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
