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
    public partial class LoginForm : Form
    {
        public string Login { get; set; }
        private Form1 parent { get; set; }
        public string Password { get; set; }

        public LoginForm(Form1 parent_form)
        {
            InitializeComponent();
            parent = parent_form;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Login = login_textBox.Text;
            Password = password_textBox.Text;
            if (parent.Login(Login, Password))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
