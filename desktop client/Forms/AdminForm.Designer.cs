namespace Student_housing_project
{
    partial class AdminForm
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
            roomsGroupBox = new GroupBox();
            roomsListBox = new ListBox();
            roomNumber = new Label();
            roomNumberUpDown = new NumericUpDown();
            label3 = new Label();
            roomFloorUpDown = new NumericUpDown();
            createNewRoomButton = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label6 = new Label();
            taskOverviewStudentsComboBox = new ComboBox();
            housingTaskListBox = new ListBox();
            listAllHousingTasksButton = new Button();
            housingTasksGroup = new GroupBox();
            dueTaskDate = new DateTimePicker();
            label5 = new Label();
            studentsComboBox = new ComboBox();
            label4 = new Label();
            createTaskDescriptionTextBox = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            createTaskTitleTextBox = new TextBox();
            createNewHousingTaskButton = new Button();
            tabPage3 = new TabPage();
            button1 = new Button();
            changeComplaintStateButton = new Button();
            groupBox2 = new GroupBox();
            doneComplaintsListBox = new ListBox();
            complaintsGroupBox = new GroupBox();
            complaintsListBox = new ListBox();
            roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomNumberUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomFloorUpDown).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            housingTasksGroup.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            complaintsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // roomsGroupBox
            // 
            roomsGroupBox.AutoSize = true;
            roomsGroupBox.Controls.Add(roomsListBox);
            roomsGroupBox.Controls.Add(roomNumber);
            roomsGroupBox.Controls.Add(roomNumberUpDown);
            roomsGroupBox.Controls.Add(label3);
            roomsGroupBox.Controls.Add(roomFloorUpDown);
            roomsGroupBox.Controls.Add(createNewRoomButton);
            roomsGroupBox.ForeColor = SystemColors.ButtonHighlight;
            roomsGroupBox.Location = new Point(22, 14);
            roomsGroupBox.Name = "roomsGroupBox";
            roomsGroupBox.Size = new Size(463, 260);
            roomsGroupBox.TabIndex = 2;
            roomsGroupBox.TabStop = false;
            roomsGroupBox.Text = "Rooms";
            // 
            // roomsListBox
            // 
            roomsListBox.FormattingEnabled = true;
            roomsListBox.ItemHeight = 15;
            roomsListBox.Location = new Point(6, 22);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new Size(451, 124);
            roomsListBox.TabIndex = 3;
            // 
            // roomNumber
            // 
            roomNumber.AutoSize = true;
            roomNumber.Location = new Point(222, 179);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(89, 15);
            roomNumber.TabIndex = 9;
            roomNumber.Text = "Room Number:";
            // 
            // roomNumberUpDown
            // 
            roomNumberUpDown.Location = new Point(316, 177);
            roomNumberUpDown.Name = "roomNumberUpDown";
            roomNumberUpDown.Size = new Size(80, 23);
            roomNumberUpDown.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 177);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Floor:";
            // 
            // roomFloorUpDown
            // 
            roomFloorUpDown.Location = new Point(103, 175);
            roomFloorUpDown.Name = "roomFloorUpDown";
            roomFloorUpDown.Size = new Size(80, 23);
            roomFloorUpDown.TabIndex = 8;
            // 
            // createNewRoomButton
            // 
            createNewRoomButton.BackColor = Color.Teal;
            createNewRoomButton.FlatStyle = FlatStyle.Popup;
            createNewRoomButton.Location = new Point(142, 206);
            createNewRoomButton.Name = "createNewRoomButton";
            createNewRoomButton.Size = new Size(169, 22);
            createNewRoomButton.TabIndex = 7;
            createNewRoomButton.Text = "Create New Room";
            createNewRoomButton.UseVisualStyleBackColor = false;
            createNewRoomButton.Click += createNewRoomButton_ClickAsync;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(300, 35);
            tabControl1.Location = new Point(-2, -1);
            tabControl1.Margin = new Padding(6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(519, 328);
            tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.AppWorkspace;
            tabPage2.Controls.Add(roomsGroupBox);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(511, 285);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Room";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.AppWorkspace;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(housingTasksGroup);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(511, 285);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Task";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(taskOverviewStudentsComboBox);
            groupBox1.Controls.Add(housingTaskListBox);
            groupBox1.Controls.Add(listAllHousingTasksButton);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(257, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 235);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Overview";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 139);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 4;
            label6.Text = "Student:";
            // 
            // taskOverviewStudentsComboBox
            // 
            taskOverviewStudentsComboBox.FormattingEnabled = true;
            taskOverviewStudentsComboBox.Location = new Point(116, 136);
            taskOverviewStudentsComboBox.Name = "taskOverviewStudentsComboBox";
            taskOverviewStudentsComboBox.Size = new Size(85, 23);
            taskOverviewStudentsComboBox.TabIndex = 3;
            taskOverviewStudentsComboBox.SelectedIndexChanged += taskOverviewStudentsComboBox_SelectedIndexChanged;
            // 
            // housingTaskListBox
            // 
            housingTaskListBox.FormattingEnabled = true;
            housingTaskListBox.ItemHeight = 15;
            housingTaskListBox.Location = new Point(6, 21);
            housingTaskListBox.Name = "housingTaskListBox";
            housingTaskListBox.Size = new Size(236, 109);
            housingTaskListBox.TabIndex = 2;
            housingTaskListBox.SelectedIndexChanged += housingTaskListBox_SelectedIndexChanged;
            // 
            // listAllHousingTasksButton
            // 
            listAllHousingTasksButton.BackColor = Color.Teal;
            listAllHousingTasksButton.FlatStyle = FlatStyle.Popup;
            listAllHousingTasksButton.Location = new Point(75, 181);
            listAllHousingTasksButton.Name = "listAllHousingTasksButton";
            listAllHousingTasksButton.Size = new Size(126, 30);
            listAllHousingTasksButton.TabIndex = 1;
            listAllHousingTasksButton.Text = "List all";
            listAllHousingTasksButton.UseVisualStyleBackColor = false;
            listAllHousingTasksButton.Click += listAllHousingTasksButton_Click;
            // 
            // housingTasksGroup
            // 
            housingTasksGroup.Controls.Add(dueTaskDate);
            housingTasksGroup.Controls.Add(label5);
            housingTasksGroup.Controls.Add(studentsComboBox);
            housingTasksGroup.Controls.Add(label4);
            housingTasksGroup.Controls.Add(createTaskDescriptionTextBox);
            housingTasksGroup.Controls.Add(label2);
            housingTasksGroup.Controls.Add(label1);
            housingTasksGroup.Controls.Add(createTaskTitleTextBox);
            housingTasksGroup.Controls.Add(createNewHousingTaskButton);
            housingTasksGroup.ForeColor = SystemColors.HighlightText;
            housingTasksGroup.Location = new Point(10, 6);
            housingTasksGroup.Name = "housingTasksGroup";
            housingTasksGroup.Size = new Size(241, 235);
            housingTasksGroup.TabIndex = 1;
            housingTasksGroup.TabStop = false;
            housingTasksGroup.Text = "Housing Task";
            // 
            // dueTaskDate
            // 
            dueTaskDate.Format = DateTimePickerFormat.Short;
            dueTaskDate.Location = new Point(77, 144);
            dueTaskDate.MinDate = new DateTime(2024, 6, 15, 0, 0, 0, 0);
            dueTaskDate.Name = "dueTaskDate";
            dueTaskDate.Size = new Size(150, 23);
            dueTaskDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 149);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Due date:";
            // 
            // studentsComboBox
            // 
            studentsComboBox.FormattingEnabled = true;
            studentsComboBox.Location = new Point(77, 33);
            studentsComboBox.Name = "studentsComboBox";
            studentsComboBox.Size = new Size(150, 23);
            studentsComboBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 35);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Student:";
            // 
            // createTaskDescriptionTextBox
            // 
            createTaskDescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            createTaskDescriptionTextBox.Location = new Point(77, 91);
            createTaskDescriptionTextBox.Name = "createTaskDescriptionTextBox";
            createTaskDescriptionTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            createTaskDescriptionTextBox.Size = new Size(150, 47);
            createTaskDescriptionTextBox.TabIndex = 6;
            createTaskDescriptionTextBox.Tag = "Description";
            createTaskDescriptionTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 64);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "Title:";
            // 
            // createTaskTitleTextBox
            // 
            createTaskTitleTextBox.Location = new Point(77, 62);
            createTaskTitleTextBox.Name = "createTaskTitleTextBox";
            createTaskTitleTextBox.Size = new Size(150, 23);
            createTaskTitleTextBox.TabIndex = 2;
            createTaskTitleTextBox.Tag = "Title";
            // 
            // createNewHousingTaskButton
            // 
            createNewHousingTaskButton.BackColor = Color.Teal;
            createNewHousingTaskButton.FlatStyle = FlatStyle.Popup;
            createNewHousingTaskButton.Location = new Point(24, 188);
            createNewHousingTaskButton.Name = "createNewHousingTaskButton";
            createNewHousingTaskButton.Size = new Size(203, 23);
            createNewHousingTaskButton.TabIndex = 0;
            createNewHousingTaskButton.Text = "Create New Task";
            createNewHousingTaskButton.UseVisualStyleBackColor = false;
            createNewHousingTaskButton.Click += createNewHousingTaskButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.AppWorkspace;
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(changeComplaintStateButton);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(complaintsGroupBox);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(511, 285);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Complaint";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(176, 192);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 8;
            button1.Text = "Open Complaint";
            button1.UseVisualStyleBackColor = false;
            button1.Click += openComplaintButton_Click;
            // 
            // changeComplaintStateButton
            // 
            changeComplaintStateButton.BackColor = Color.Teal;
            changeComplaintStateButton.FlatStyle = FlatStyle.Popup;
            changeComplaintStateButton.ForeColor = SystemColors.HighlightText;
            changeComplaintStateButton.Location = new Point(176, 163);
            changeComplaintStateButton.Name = "changeComplaintStateButton";
            changeComplaintStateButton.Size = new Size(123, 23);
            changeComplaintStateButton.TabIndex = 5;
            changeComplaintStateButton.Text = "Change state";
            changeComplaintStateButton.UseVisualStyleBackColor = false;
            changeComplaintStateButton.Click += changeComplaintStateButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(doneComplaintsListBox);
            groupBox2.ForeColor = SystemColors.HighlightText;
            groupBox2.Location = new Point(305, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 214);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Completed Complaints";
            // 
            // doneComplaintsListBox
            // 
            doneComplaintsListBox.FormattingEnabled = true;
            doneComplaintsListBox.ItemHeight = 15;
            doneComplaintsListBox.Location = new Point(6, 22);
            doneComplaintsListBox.Name = "doneComplaintsListBox";
            doneComplaintsListBox.Size = new Size(168, 139);
            doneComplaintsListBox.TabIndex = 5;
            // 
            // complaintsGroupBox
            // 
            complaintsGroupBox.Controls.Add(complaintsListBox);
            complaintsGroupBox.ForeColor = SystemColors.HighlightText;
            complaintsGroupBox.Location = new Point(10, 15);
            complaintsGroupBox.Name = "complaintsGroupBox";
            complaintsGroupBox.Size = new Size(160, 224);
            complaintsGroupBox.TabIndex = 6;
            complaintsGroupBox.TabStop = false;
            complaintsGroupBox.Text = "Complaints";
            // 
            // complaintsListBox
            // 
            complaintsListBox.FormattingEnabled = true;
            complaintsListBox.ItemHeight = 15;
            complaintsListBox.Location = new Point(6, 22);
            complaintsListBox.Name = "complaintsListBox";
            complaintsListBox.Size = new Size(143, 139);
            complaintsListBox.TabIndex = 4;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 324);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "HousingHub-Admin";
            Load += AdminForm_Load;
            roomsGroupBox.ResumeLayout(false);
            roomsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomNumberUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomFloorUpDown).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            housingTasksGroup.ResumeLayout(false);
            housingTasksGroup.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            complaintsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox roomsGroupBox;
        private ListBox roomsListBox;
        private Button createNewRoomButton;
        private NumericUpDown roomFloorUpDown;
        private Label roomNumber;
        private NumericUpDown roomNumberUpDown;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private GroupBox housingTasksGroup;
        private ComboBox studentsComboBox;
        private Label label4;
        private RichTextBox createTaskDescriptionTextBox;
        private Label label2;
        private Label label1;
        private TextBox createTaskTitleTextBox;
        private Button listAllHousingTasksButton;
        private Button createNewHousingTaskButton;
        private TabPage tabPage3;
        private GroupBox complaintsGroupBox;
        private ListBox complaintsListBox;
        private ComboBox taskOverviewStudentsComboBox;
        private ListBox housingTaskListBox;
        private DateTimePicker dueTaskDate;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private GroupBox groupBox2;
        private Button changeComplaintStateButton;
        private ListBox doneComplaintsListBox;
        private Button button1;
    }
}