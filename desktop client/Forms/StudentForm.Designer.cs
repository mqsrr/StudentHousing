namespace Student_housing_project
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            garbageListBox = new ListBox();
            groupBox1 = new GroupBox();
            viewAllTasksButton = new Button();
            viewCurrentTasksButton = new Button();
            housingTasksListBox = new ListBox();
            changeHousingTaskStateButton = new Button();
            viewCompletedTasksButton = new Button();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            complaintDescriptionTextBox = new RichTextBox();
            label4 = new Label();
            fileComplaintButton = new Button();
            label3 = new Label();
            label2 = new Label();
            complaintTitleTextBox = new TextBox();
            tabPage3 = new TabPage();
            pictureBox2 = new PictureBox();
            label13 = new Label();
            createPartyDescription = new RichTextBox();
            createPartyStartDate = new DateTimePicker();
            createPartyTime = new TextBox();
            label12 = new Label();
            groupBox4 = new GroupBox();
            openPartyButton = new Button();
            partyListBox = new ListBox();
            joinPartyButton = new Button();
            createPartyButton = new Button();
            createPartyName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 142);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(300, 35);
            tabControl1.Location = new Point(-4, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(693, 326);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.AppWorkspace;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.ForeColor = SystemColors.MenuText;
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(685, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tasks & Garbage";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = StudentHousingApp.Properties.Resources.HousingHub;
            pictureBox3.Location = new Point(465, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(3);
            pictureBox3.Size = new Size(189, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(garbageListBox);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = SystemColors.HighlightText;
            groupBox2.Location = new Point(412, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Garbage";
            // 
            // garbageListBox
            // 
            garbageListBox.BackColor = SystemColors.Window;
            garbageListBox.ForeColor = SystemColors.Desktop;
            garbageListBox.FormattingEnabled = true;
            garbageListBox.ItemHeight = 15;
            garbageListBox.Location = new Point(17, 22);
            garbageListBox.Name = "garbageListBox";
            garbageListBox.Size = new Size(225, 124);
            garbageListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(viewAllTasksButton);
            groupBox1.Controls.Add(viewCurrentTasksButton);
            groupBox1.Controls.Add(housingTasksListBox);
            groupBox1.Controls.Add(changeHousingTaskStateButton);
            groupBox1.Controls.Add(viewCompletedTasksButton);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(15, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tasks";
            // 
            // viewAllTasksButton
            // 
            viewAllTasksButton.BackColor = Color.Teal;
            viewAllTasksButton.FlatStyle = FlatStyle.Popup;
            viewAllTasksButton.ForeColor = SystemColors.HighlightText;
            viewAllTasksButton.Location = new Point(191, 178);
            viewAllTasksButton.Name = "viewAllTasksButton";
            viewAllTasksButton.Size = new Size(179, 23);
            viewAllTasksButton.TabIndex = 10;
            viewAllTasksButton.Text = "View all tasks";
            viewAllTasksButton.UseVisualStyleBackColor = false;
            viewAllTasksButton.Click += viewAllTasksButton_Click;
            // 
            // viewCurrentTasksButton
            // 
            viewCurrentTasksButton.BackColor = Color.Teal;
            viewCurrentTasksButton.FlatStyle = FlatStyle.Popup;
            viewCurrentTasksButton.ForeColor = SystemColors.HighlightText;
            viewCurrentTasksButton.Location = new Point(6, 207);
            viewCurrentTasksButton.Name = "viewCurrentTasksButton";
            viewCurrentTasksButton.Size = new Size(179, 23);
            viewCurrentTasksButton.TabIndex = 0;
            viewCurrentTasksButton.Text = "View current tasks";
            viewCurrentTasksButton.UseVisualStyleBackColor = false;
            viewCurrentTasksButton.Click += viewCurrentTasksButton_Click;
            // 
            // housingTasksListBox
            // 
            housingTasksListBox.BackColor = SystemColors.Window;
            housingTasksListBox.ForeColor = SystemColors.Desktop;
            housingTasksListBox.FormattingEnabled = true;
            housingTasksListBox.ItemHeight = 15;
            housingTasksListBox.Location = new Point(6, 14);
            housingTasksListBox.Name = "housingTasksListBox";
            housingTasksListBox.Size = new Size(363, 154);
            housingTasksListBox.TabIndex = 3;
            housingTasksListBox.SelectedIndexChanged += housingTasksListBox_SelectedIndexChanged;
            // 
            // changeHousingTaskStateButton
            // 
            changeHousingTaskStateButton.BackColor = Color.Teal;
            changeHousingTaskStateButton.FlatStyle = FlatStyle.Popup;
            changeHousingTaskStateButton.ForeColor = SystemColors.HighlightText;
            changeHousingTaskStateButton.Location = new Point(191, 207);
            changeHousingTaskStateButton.Name = "changeHousingTaskStateButton";
            changeHousingTaskStateButton.Size = new Size(179, 23);
            changeHousingTaskStateButton.TabIndex = 2;
            changeHousingTaskStateButton.Text = "Change state";
            changeHousingTaskStateButton.UseVisualStyleBackColor = false;
            changeHousingTaskStateButton.Click += changeHousingTaskStateButton_ClickAsync;
            // 
            // viewCompletedTasksButton
            // 
            viewCompletedTasksButton.BackColor = Color.Teal;
            viewCompletedTasksButton.FlatStyle = FlatStyle.Popup;
            viewCompletedTasksButton.ForeColor = Color.Transparent;
            viewCompletedTasksButton.Location = new Point(6, 178);
            viewCompletedTasksButton.Name = "viewCompletedTasksButton";
            viewCompletedTasksButton.Size = new Size(179, 23);
            viewCompletedTasksButton.TabIndex = 1;
            viewCompletedTasksButton.Text = "View completed tasks";
            viewCompletedTasksButton.UseVisualStyleBackColor = false;
            viewCompletedTasksButton.Click += viewCompletedTasksButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.AppWorkspace;
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(685, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Complaints";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = StudentHousingApp.Properties.Resources.HousingHub;
            pictureBox1.Location = new Point(467, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(13, 155);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 3;
            label5.Text = "Rules:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 178);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(434, 88);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(complaintDescriptionTextBox);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(fileComplaintButton);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(complaintTitleTextBox);
            groupBox3.ForeColor = SystemColors.HighlightText;
            groupBox3.Location = new Point(13, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(631, 146);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Complaints";
            // 
            // complaintDescriptionTextBox
            // 
            complaintDescriptionTextBox.Location = new Point(398, 19);
            complaintDescriptionTextBox.Name = "complaintDescriptionTextBox";
            complaintDescriptionTextBox.Size = new Size(193, 91);
            complaintDescriptionTextBox.TabIndex = 6;
            complaintDescriptionTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 10F, FontStyle.Bold);
            label4.Location = new Point(6, 110);
            label4.Name = "label4";
            label4.Size = new Size(291, 24);
            label4.TabIndex = 5;
            label4.Text = "Note: Complaints are 100% anonymous";
            // 
            // fileComplaintButton
            // 
            fileComplaintButton.BackColor = Color.Teal;
            fileComplaintButton.FlatStyle = FlatStyle.Popup;
            fileComplaintButton.Location = new Point(490, 116);
            fileComplaintButton.Name = "fileComplaintButton";
            fileComplaintButton.Size = new Size(101, 23);
            fileComplaintButton.TabIndex = 4;
            fileComplaintButton.Text = "File Complaints";
            fileComplaintButton.UseVisualStyleBackColor = false;
            fileComplaintButton.Click += fileComplaintButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 22);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 22);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // complaintTitleTextBox
            // 
            complaintTitleTextBox.BackColor = SystemColors.Window;
            complaintTitleTextBox.Location = new Point(54, 19);
            complaintTitleTextBox.Name = "complaintTitleTextBox";
            complaintTitleTextBox.Size = new Size(174, 23);
            complaintTitleTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.AppWorkspace;
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(createPartyDescription);
            tabPage3.Controls.Add(createPartyStartDate);
            tabPage3.Controls.Add(createPartyTime);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(createPartyButton);
            tabPage3.Controls.Add(createPartyName);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(685, 283);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Party";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = StudentHousingApp.Properties.Resources.HousingHub;
            pictureBox2.Location = new Point(467, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(353, 10);
            label13.Name = "label13";
            label13.Size = new Size(106, 15);
            label13.TabIndex = 22;
            label13.Text = "Choose party date:";
            // 
            // createPartyDescription
            // 
            createPartyDescription.Location = new Point(476, 71);
            createPartyDescription.Name = "createPartyDescription";
            createPartyDescription.Size = new Size(168, 73);
            createPartyDescription.TabIndex = 20;
            createPartyDescription.Text = "";
            // 
            // createPartyStartDate
            // 
            createPartyStartDate.Location = new Point(350, 27);
            createPartyStartDate.Name = "createPartyStartDate";
            createPartyStartDate.Size = new Size(293, 23);
            createPartyStartDate.TabIndex = 18;
            // 
            // createPartyTime
            // 
            createPartyTime.Location = new Point(350, 115);
            createPartyTime.Name = "createPartyTime";
            createPartyTime.PlaceholderText = "hh:mm:ss";
            createPartyTime.Size = new Size(100, 23);
            createPartyTime.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HighlightText;
            label12.Location = new Point(353, 100);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 16;
            label12.Text = "Party time:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(openPartyButton);
            groupBox4.Controls.Add(partyListBox);
            groupBox4.Controls.Add(joinPartyButton);
            groupBox4.ForeColor = SystemColors.HighlightText;
            groupBox4.Location = new Point(4, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 250);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Party list";
            // 
            // openPartyButton
            // 
            openPartyButton.BackColor = Color.Teal;
            openPartyButton.FlatStyle = FlatStyle.Popup;
            openPartyButton.Location = new Point(168, 207);
            openPartyButton.Name = "openPartyButton";
            openPartyButton.Size = new Size(140, 23);
            openPartyButton.TabIndex = 21;
            openPartyButton.Text = "Open Party";
            openPartyButton.UseVisualStyleBackColor = false;
            openPartyButton.Click += OpenPartyDetails_Action;
            // 
            // partyListBox
            // 
            partyListBox.FormattingEnabled = true;
            partyListBox.ItemHeight = 15;
            partyListBox.Location = new Point(6, 17);
            partyListBox.Name = "partyListBox";
            partyListBox.Size = new Size(302, 169);
            partyListBox.TabIndex = 19;
            partyListBox.SelectedIndexChanged += partyListBox_SelectedIndexChanged;
            // 
            // joinPartyButton
            // 
            joinPartyButton.BackColor = Color.Teal;
            joinPartyButton.FlatStyle = FlatStyle.Popup;
            joinPartyButton.Location = new Point(6, 207);
            joinPartyButton.Name = "joinPartyButton";
            joinPartyButton.Size = new Size(140, 23);
            joinPartyButton.TabIndex = 19;
            joinPartyButton.Text = "Join Party ";
            joinPartyButton.UseVisualStyleBackColor = false;
            joinPartyButton.Click += JoinParty_ActionAsync;
            // 
            // createPartyButton
            // 
            createPartyButton.BackColor = Color.Teal;
            createPartyButton.FlatStyle = FlatStyle.Popup;
            createPartyButton.ForeColor = SystemColors.HighlightText;
            createPartyButton.Location = new Point(350, 150);
            createPartyButton.Name = "createPartyButton";
            createPartyButton.Size = new Size(294, 23);
            createPartyButton.TabIndex = 13;
            createPartyButton.Text = "Create party";
            createPartyButton.UseVisualStyleBackColor = false;
            createPartyButton.Click += createPartyButton_Click;
            // 
            // createPartyName
            // 
            createPartyName.Location = new Point(350, 71);
            createPartyName.Name = "createPartyName";
            createPartyName.Size = new Size(100, 23);
            createPartyName.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(479, 56);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 10;
            label11.Text = "Party description:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(353, 56);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 9;
            label10.Text = "Party name:";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 315);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "HousingHub";
            Load += StudentForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private ListBox garbageListBox;
        private GroupBox groupBox1;
        private ListBox housingTasksListBox;
        private Button changeHousingTaskStateButton;
        private Button viewCompletedTasksButton;
        private Button viewCurrentTasksButton;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private Label label4;
        private Button fileComplaintButton;
        private Label label3;
        private Label label2;
        private TextBox complaintTitleTextBox;
        private RichTextBox complaintDescriptionTextBox;
        private Button viewAllTasksButton;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private ListBox partyListBox;
        private RichTextBox createPartyDescription;
        private Button joinPartyButton;
        private DateTimePicker createPartyStartDate;
        private TextBox createPartyTime;
        private Label label12;
        private Button createPartyButton;
        private TextBox createPartyName;
        private Label label11;
        private Label label10;
        private Button openPartyButton;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label13;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}