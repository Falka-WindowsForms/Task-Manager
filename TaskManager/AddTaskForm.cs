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
        public AddTaskForm(int type=0)
        {
            InitializeComponent();
            if (type == 1)
            {
                add_button.Text = "Change";
            }
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
                StatusId = EnumStatuses.InProgress;
            else
                StatusId = EnumStatuses.Done;

            if (String.IsNullOrWhiteSpace(TaskName) && String.IsNullOrWhiteSpace(Catalog))
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        public void UpdateAll()
        {
            Name_textBox.Text = TaskName;
            SHDescription_textBox.Text = ShortDescription;
            FullDescription_textbox.Text = FullDescription;
            if(StatusId == EnumStatuses.ToDo)
            {
                ToDo_radioButton.Checked = true;
                InProgress_radioButton.Checked = false;
                Done_radioButton.Checked = false;
            }else if(StatusId == EnumStatuses.InProgress)
            {
                ToDo_radioButton.Checked = false;
                InProgress_radioButton.Checked = true;
                Done_radioButton.Checked = false;
            }
            else
            {
                ToDo_radioButton.Checked = false;
                InProgress_radioButton.Checked = false;
                Done_radioButton.Checked = true;
            }
            Catalog_textBox.Text = Catalog;

        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            UpdateAll();
        }
    }
}
