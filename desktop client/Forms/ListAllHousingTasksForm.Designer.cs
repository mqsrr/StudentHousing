namespace StudentHousingApp.Forms
{
    partial class ListAllHousingTasksForm
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
            groupBox1 = new GroupBox();
            taskStateLabel = new Label();
            label3 = new Label();
            housingTasksListBox = new ListBox();
            label2 = new Label();
            housingTaskTitleTextBox = new TextBox();
            housingTaskDescriptionTextBox = new RichTextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(taskStateLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(housingTasksListBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(housingTaskTitleTextBox);
            groupBox1.Controls.Add(housingTaskDescriptionTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 274);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Housing Tasks";
            // 
            // taskStateLabel
            // 
            taskStateLabel.AutoSize = true;
            taskStateLabel.Location = new Point(345, 19);
            taskStateLabel.Name = "taskStateLabel";
            taskStateLabel.Size = new Size(0, 15);
            taskStateLabel.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 19);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Tast Status:";
            // 
            // housingTasksListBox
            // 
            housingTasksListBox.FormattingEnabled = true;
            housingTasksListBox.ItemHeight = 15;
            housingTasksListBox.Location = new Point(6, 22);
            housingTasksListBox.Name = "housingTasksListBox";
            housingTasksListBox.Size = new Size(173, 214);
            housingTasksListBox.TabIndex = 5;
            housingTasksListBox.SelectedIndexChanged += housingTasksListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 78);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // housingTaskTitleTextBox
            // 
            housingTaskTitleTextBox.Location = new Point(185, 40);
            housingTaskTitleTextBox.Name = "housingTaskTitleTextBox";
            housingTaskTitleTextBox.ReadOnly = true;
            housingTaskTitleTextBox.Size = new Size(195, 23);
            housingTaskTitleTextBox.TabIndex = 3;
            // 
            // housingTaskDescriptionTextBox
            // 
            housingTaskDescriptionTextBox.Location = new Point(185, 96);
            housingTaskDescriptionTextBox.Name = "housingTaskDescriptionTextBox";
            housingTaskDescriptionTextBox.ReadOnly = true;
            housingTaskDescriptionTextBox.Size = new Size(195, 140);
            housingTaskDescriptionTextBox.TabIndex = 2;
            housingTaskDescriptionTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 22);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // ListAllHousingTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 301);
            Controls.Add(groupBox1);
            Name = "ListAllHousingTasksForm";
            Text = "ListAllHousingTasksForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private TextBox housingTaskTitleTextBox;
        private RichTextBox housingTaskDescriptionTextBox;
        private Label label1;
        private ListBox housingTasksListBox;
        private Label taskStateLabel;
        private Label label3;
    }
}