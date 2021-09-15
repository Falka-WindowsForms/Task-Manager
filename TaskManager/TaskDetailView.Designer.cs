
namespace TaskManager
{
    partial class TaskDetailView
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
            this.label2 = new System.Windows.Forms.Label();
            this.SHDescription_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FullDescription_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short description:";
            // 
            // SHDescription_textBox
            // 
            this.SHDescription_textBox.Enabled = false;
            this.SHDescription_textBox.Location = new System.Drawing.Point(26, 106);
            this.SHDescription_textBox.Name = "SHDescription_textBox";
            this.SHDescription_textBox.Size = new System.Drawing.Size(495, 47);
            this.SHDescription_textBox.TabIndex = 3;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Enabled = false;
            this.Name_textBox.Location = new System.Drawing.Point(135, 12);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(386, 47);
            this.Name_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // FullDescription_textbox
            // 
            this.FullDescription_textbox.Enabled = false;
            this.FullDescription_textbox.Location = new System.Drawing.Point(26, 198);
            this.FullDescription_textbox.Multiline = true;
            this.FullDescription_textbox.Name = "FullDescription_textbox";
            this.FullDescription_textbox.Size = new System.Drawing.Size(495, 172);
            this.FullDescription_textbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task:";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(178, 377);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(129, 51);
            this.close_button.TabIndex = 8;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // TaskDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 440);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullDescription_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.SHDescription_textBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "TaskDetailView";
            this.Text = "TaskDetailView";
            this.Load += new System.EventHandler(this.TaskDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SHDescription_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullDescription_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_button;
    }
}