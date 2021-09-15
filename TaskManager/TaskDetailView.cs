using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Models;

namespace TaskManager
{
    public partial class TaskDetailView : Form
    {
        public string TaskName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int CatalogId { get; set; }
        public List<Catalog> Catalogs { get; set; }
        public int StatusId { get; set; }
        public TaskDetailView()
        {
            InitializeComponent();
        }

        private void TaskDetailView_Load(object sender, EventArgs e)
        {
            UpdateText();
        }
        public void UpdateText()
        {
            Name_textBox.Text = TaskName;
            SHDescription_textBox.Text = ShortDescription;
            FullDescription_textbox.Text = FullDescription;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
