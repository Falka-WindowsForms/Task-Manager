
namespace TaskManager
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FullDescription_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.SHDescription_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.ToDo_radioButton = new System.Windows.Forms.RadioButton();
            this.InProgress_radioButton = new System.Windows.Forms.RadioButton();
            this.Done_radioButton = new System.Windows.Forms.RadioButton();
            this.Catalog_textBox = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Task:";
            // 
            // FullDescription_textbox
            // 
            this.FullDescription_textbox.Location = new System.Drawing.Point(10, 192);
            this.FullDescription_textbox.Multiline = true;
            this.FullDescription_textbox.Name = "FullDescription_textbox";
            this.FullDescription_textbox.Size = new System.Drawing.Size(495, 172);
            this.FullDescription_textbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(119, 6);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(386, 47);
            this.Name_textBox.TabIndex = 10;
            // 
            // SHDescription_textBox
            // 
            this.SHDescription_textBox.Location = new System.Drawing.Point(10, 100);
            this.SHDescription_textBox.Name = "SHDescription_textBox";
            this.SHDescription_textBox.Size = new System.Drawing.Size(495, 47);
            this.SHDescription_textBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Short description:";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(279, 505);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(156, 52);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // ToDo_radioButton
            // 
            this.ToDo_radioButton.AutoSize = true;
            this.ToDo_radioButton.Checked = true;
            this.ToDo_radioButton.Location = new System.Drawing.Point(13, 371);
            this.ToDo_radioButton.Name = "ToDo_radioButton";
            this.ToDo_radioButton.Size = new System.Drawing.Size(122, 43);
            this.ToDo_radioButton.TabIndex = 15;
            this.ToDo_radioButton.TabStop = true;
            this.ToDo_radioButton.Text = "To do";
            this.ToDo_radioButton.UseVisualStyleBackColor = true;
            // 
            // InProgress_radioButton
            // 
            this.InProgress_radioButton.AutoSize = true;
            this.InProgress_radioButton.Location = new System.Drawing.Point(10, 420);
            this.InProgress_radioButton.Name = "InProgress_radioButton";
            this.InProgress_radioButton.Size = new System.Drawing.Size(212, 43);
            this.InProgress_radioButton.TabIndex = 16;
            this.InProgress_radioButton.Text = "In Progress";
            this.InProgress_radioButton.UseVisualStyleBackColor = true;
            // 
            // Done_radioButton
            // 
            this.Done_radioButton.AutoSize = true;
            this.Done_radioButton.Location = new System.Drawing.Point(10, 464);
            this.Done_radioButton.Name = "Done_radioButton";
            this.Done_radioButton.Size = new System.Drawing.Size(117, 43);
            this.Done_radioButton.TabIndex = 17;
            this.Done_radioButton.Text = "Done";
            this.Done_radioButton.UseVisualStyleBackColor = true;
            // 
            // Catalog_textBox
            // 
            this.Catalog_textBox.Location = new System.Drawing.Point(289, 420);
            this.Catalog_textBox.Name = "Catalog_textBox";
            this.Catalog_textBox.Size = new System.Drawing.Size(220, 47);
            this.Catalog_textBox.TabIndex = 18;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(289, 375);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(146, 39);
            this.label_1.TabIndex = 19;
            this.label_1.Text = "Catalog:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.Catalog_textBox);
            this.Controls.Add(this.Done_radioButton);
            this.Controls.Add(this.InProgress_radioButton);
            this.Controls.Add(this.ToDo_radioButton);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullDescription_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.SHDescription_textBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullDescription_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox SHDescription_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.RadioButton ToDo_radioButton;
        private System.Windows.Forms.RadioButton InProgress_radioButton;
        private System.Windows.Forms.RadioButton Done_radioButton;
        private System.Windows.Forms.TextBox Catalog_textBox;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button button1;
    }
}