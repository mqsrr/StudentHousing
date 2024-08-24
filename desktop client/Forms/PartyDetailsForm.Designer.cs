namespace StudentHousingApp.Forms
{
    partial class PartyDetailsForm
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
            chatListBox = new ListBox();
            membersListBox = new ListBox();
            groupBox1 = new GroupBox();
            sendButton = new Button();
            messageTextBox = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            partyStartTimeLabel = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // chatListBox
            // 
            chatListBox.FormattingEnabled = true;
            chatListBox.ItemHeight = 15;
            chatListBox.Location = new Point(6, 40);
            chatListBox.Name = "chatListBox";
            chatListBox.Size = new Size(293, 169);
            chatListBox.TabIndex = 0;
            // 
            // membersListBox
            // 
            membersListBox.FormattingEnabled = true;
            membersListBox.ItemHeight = 15;
            membersListBox.Location = new Point(6, 22);
            membersListBox.Name = "membersListBox";
            membersListBox.Size = new Size(135, 199);
            membersListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(membersListBox);
            groupBox1.Location = new Point(323, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 234);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Members";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(212, 211);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(87, 23);
            sendButton.TabIndex = 3;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(6, 211);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(200, 23);
            messageTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chatListBox);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(messageTextBox);
            groupBox2.Controls.Add(sendButton);
            groupBox2.Location = new Point(12, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 239);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chat";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 11);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search for author or date";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // partyStartTimeLabel
            // 
            partyStartTimeLabel.AutoSize = true;
            partyStartTimeLabel.Location = new Point(100, 6);
            partyStartTimeLabel.Name = "partyStartTimeLabel";
            partyStartTimeLabel.Size = new Size(13, 15);
            partyStartTimeLabel.TabIndex = 6;
            partyStartTimeLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Party Start Time:";
            // 
            // PartyDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 262);
            Controls.Add(partyStartTimeLabel);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PartyDetailsForm";
            Text = "PartyDetailsForm";
            FormClosing += PartyDetailsForm_FormClosing;
            Load += PartyDetailsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox chatListBox;
        private ListBox membersListBox;
        private GroupBox groupBox1;
        private Button sendButton;
        private TextBox messageTextBox;
        private GroupBox groupBox2;
        private Label label1;
        private Label partyStartTimeLabel;
        private TextBox textBox1;
    }
}