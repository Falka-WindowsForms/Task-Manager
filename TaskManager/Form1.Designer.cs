
namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.task_viewer = new System.Windows.Forms.ListView();
            this.number_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddTask_button = new System.Windows.Forms.Button();
            this.editTask_button = new System.Windows.Forms.Button();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // task_viewer
            // 
            this.task_viewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number_header,
            this.category_header,
            this.name_header,
            this.description_header,
            this.status_header});
            this.task_viewer.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task_viewer.FullRowSelect = true;
            this.task_viewer.HideSelection = false;
            this.task_viewer.Location = new System.Drawing.Point(15, 28);
            this.task_viewer.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.task_viewer.MultiSelect = false;
            this.task_viewer.Name = "task_viewer";
            this.task_viewer.Size = new System.Drawing.Size(991, 325);
            this.task_viewer.TabIndex = 0;
            this.task_viewer.UseCompatibleStateImageBehavior = false;
            this.task_viewer.View = System.Windows.Forms.View.Details;
            this.task_viewer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.task_viewer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.task_viewer_MouseDoubleClick);
            // 
            // number_header
            // 
            this.number_header.Text = "Num↓";
            this.number_header.Width = 80;
            // 
            // category_header
            // 
            this.category_header.Text = "Category";
            this.category_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.category_header.Width = 160;
            // 
            // name_header
            // 
            this.name_header.Text = "Task";
            this.name_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_header.Width = 131;
            // 
            // description_header
            // 
            this.description_header.Text = "Short description";
            this.description_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.description_header.Width = 465;
            // 
            // status_header
            // 
            this.status_header.Text = "Status";
            this.status_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status_header.Width = 150;
            // 
            // AddTask_button
            // 
            this.AddTask_button.BackColor = System.Drawing.Color.Coral;
            this.AddTask_button.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.AddTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTask_button.Location = new System.Drawing.Point(266, 368);
            this.AddTask_button.Name = "AddTask_button";
            this.AddTask_button.Size = new System.Drawing.Size(130, 44);
            this.AddTask_button.TabIndex = 1;
            this.AddTask_button.Text = "Add task";
            this.AddTask_button.UseVisualStyleBackColor = false;
            this.AddTask_button.Click += new System.EventHandler(this.AddTask_button_Click);
            // 
            // editTask_button
            // 
            this.editTask_button.BackColor = System.Drawing.Color.Coral;
            this.editTask_button.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.editTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTask_button.Location = new System.Drawing.Point(266, 421);
            this.editTask_button.Name = "editTask_button";
            this.editTask_button.Size = new System.Drawing.Size(130, 44);
            this.editTask_button.TabIndex = 2;
            this.editTask_button.Text = "Edit task";
            this.editTask_button.UseVisualStyleBackColor = false;
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Location = new System.Drawing.Point(111, 25);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(121, 27);
            this.Category_comboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Category_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.userToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "&Programm";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.changeLoginToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "&User";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change password";
            // 
            // changeLoginToolStripMenuItem
            // 
            this.changeLoginToolStripMenuItem.Name = "changeLoginToolStripMenuItem";
            this.changeLoginToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changeLoginToolStripMenuItem.Text = "&Change login";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "&Author";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(402, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mark as done";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(402, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mark as To Do";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskManager.Properties.Resources.task;
            this.pictureBox1.Location = new System.Drawing.Point(583, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editTask_button);
            this.Controls.Add(this.AddTask_button);
            this.Controls.Add(this.task_viewer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView task_viewer;
        private System.Windows.Forms.ColumnHeader number_header;
        private System.Windows.Forms.ColumnHeader name_header;
        private System.Windows.Forms.ColumnHeader description_header;
        private System.Windows.Forms.ColumnHeader status_header;
        private System.Windows.Forms.ColumnHeader category_header;
        private System.Windows.Forms.Button AddTask_button;
        private System.Windows.Forms.Button editTask_button;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLoginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

