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
    public partial class AddTaskForm : Form
    {
        public string TaskName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Catalog { get; set; }
        public EnumStatuses StatusId { get; set; }
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            TaskName = Name_textBox.Text;
            ShortDescription = SHDescription_textBox.Text;
            FullDescription = FullDescription_textbox.Text;
            Catalog = Catalog_textBox.Text;
            if (ToDo_radioButton.Checked == true)
                StatusId = EnumStatuses.ToDo;
            else if (InProgress_radioButton.Checked == true)
                StatusId = EnumStatuses.InProgressbar;
            else
                StatusId = EnumStatuses.Done;

            this.DialogResult = DialogResult.OK;
        }
    }
}
