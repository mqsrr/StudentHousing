


namespace Student_housing_project
{
    partial class AuthenticationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerTabControl = new TabControl();
            loginTabPage = new TabPage();
            loginBtn = new Button();
            PasswordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            registerTabPage = new TabPage();
            label9 = new Label();
            birthdateDateTimePicker = new DateTimePicker();
            regFullNameTextBox = new TextBox();
            label8 = new Label();
            regAvailableRoomsComboBox = new ComboBox();
            label7 = new Label();
            regEmailTextBox = new TextBox();
            label6 = new Label();
            registerBtn = new Button();
            regConfirmPasswordTextBox = new TextBox();
            regPasswordTextBox = new TextBox();
            regUsernameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            registerTabControl.SuspendLayout();
            loginTabPage.SuspendLayout();
            registerTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // registerTabControl
            // 
            registerTabControl.Controls.Add(loginTabPage);
            registerTabControl.Controls.Add(registerTabPage);
            registerTabControl.Location = new Point(-1, 0);
            registerTabControl.Name = "registerTabControl";
            registerTabControl.SelectedIndex = 0;
            registerTabControl.Size = new Size(398, 312);
            registerTabControl.TabIndex = 0;
            // 
            // loginTabPage
            // 
            loginTabPage.Controls.Add(loginBtn);
            loginTabPage.Controls.Add(PasswordTextBox);
            loginTabPage.Controls.Add(usernameTextBox);
            loginTabPage.Controls.Add(label2);
            loginTabPage.Controls.Add(label1);
            loginTabPage.Location = new Point(4, 24);
            loginTabPage.Name = "loginTabPage";
            loginTabPage.Padding = new Padding(3);
            loginTabPage.Size = new Size(390, 284);
            loginTabPage.TabIndex = 0;
            loginTabPage.Text = "Login";
            loginTabPage.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(68, 187);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(236, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_ClickAsync;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(149, 136);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(155, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Tag = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(149, 89);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(155, 23);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.Tag = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 139);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 92);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // registerTabPage
            // 
            registerTabPage.Controls.Add(label9);
            registerTabPage.Controls.Add(birthdateDateTimePicker);
            registerTabPage.Controls.Add(regFullNameTextBox);
            registerTabPage.Controls.Add(label8);
            registerTabPage.Controls.Add(regAvailableRoomsComboBox);
            registerTabPage.Controls.Add(label7);
            registerTabPage.Controls.Add(regEmailTextBox);
            registerTabPage.Controls.Add(label6);
            registerTabPage.Controls.Add(registerBtn);
            registerTabPage.Controls.Add(regConfirmPasswordTextBox);
            registerTabPage.Controls.Add(regPasswordTextBox);
            registerTabPage.Controls.Add(regUsernameTextBox);
            registerTabPage.Controls.Add(label5);
            registerTabPage.Controls.Add(label4);
            registerTabPage.Controls.Add(label3);
            registerTabPage.Location = new Point(4, 24);
            registerTabPage.Name = "registerTabPage";
            registerTabPage.Padding = new Padding(3);
            registerTabPage.Size = new Size(390, 284);
            registerTabPage.TabIndex = 1;
            registerTabPage.Text = "Register";
            registerTabPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 187);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 14;
            label9.Text = "Birthdate:";
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.CustomFormat = "";
            birthdateDateTimePicker.Location = new Point(203, 181);
            birthdateDateTimePicker.MaxDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            birthdateDateTimePicker.MinDate = new DateTime(1939, 12, 31, 0, 0, 0, 0);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(78, 23);
            birthdateDateTimePicker.TabIndex = 13;
            birthdateDateTimePicker.Value = new DateTime(2024, 5, 21, 19, 53, 16, 0);
            // 
            // regFullNameTextBox
            // 
            regFullNameTextBox.Location = new Point(203, 61);
            regFullNameTextBox.Name = "regFullNameTextBox";
            regFullNameTextBox.Size = new Size(100, 23);
            regFullNameTextBox.TabIndex = 12;
            regFullNameTextBox.Tag = "FullName";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 61);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 11;
            label8.Text = "Full Name:";
            // 
            // regAvailableRoomsComboBox
            // 
            regAvailableRoomsComboBox.FormattingEnabled = true;
            regAvailableRoomsComboBox.Location = new Point(203, 216);
            regAvailableRoomsComboBox.Name = "regAvailableRoomsComboBox";
            regAvailableRoomsComboBox.Size = new Size(121, 23);
            regAvailableRoomsComboBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 219);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 9;
            label7.Text = "Available room to rent:";
            // 
            // regEmailTextBox
            // 
            regEmailTextBox.Location = new Point(203, 32);
            regEmailTextBox.Name = "regEmailTextBox";
            regEmailTextBox.Size = new Size(100, 23);
            regEmailTextBox.TabIndex = 8;
            regEmailTextBox.Tag = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 32);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 7;
            label6.Text = "Email:";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(88, 255);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(215, 23);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register Account";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // regConfirmPasswordTextBox
            // 
            regConfirmPasswordTextBox.Location = new Point(203, 148);
            regConfirmPasswordTextBox.Name = "regConfirmPasswordTextBox";
            regConfirmPasswordTextBox.Size = new Size(100, 23);
            regConfirmPasswordTextBox.TabIndex = 5;
            regConfirmPasswordTextBox.Tag = "ConfirmPassword";
            // 
            // regPasswordTextBox
            // 
            regPasswordTextBox.Location = new Point(203, 119);
            regPasswordTextBox.Name = "regPasswordTextBox";
            regPasswordTextBox.Size = new Size(100, 23);
            regPasswordTextBox.TabIndex = 4;
            regPasswordTextBox.Tag = "Password";
            // 
            // regUsernameTextBox
            // 
            regUsernameTextBox.Location = new Point(203, 90);
            regUsernameTextBox.Name = "regUsernameTextBox";
            regUsernameTextBox.Size = new Size(100, 23);
            regUsernameTextBox.TabIndex = 3;
            regUsernameTextBox.Tag = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 151);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 2;
            label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 119);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 1;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 90);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Username:";
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 323);
            Controls.Add(registerTabControl);
            Name = "AuthenticationForm";
            Text = "Student Housing";
            Load += AuthenticationForm_Load;
            registerTabControl.ResumeLayout(false);
            loginTabPage.ResumeLayout(false);
            loginTabPage.PerformLayout();
            registerTabPage.ResumeLayout(false);
            registerTabPage.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TabControl registerTabControl;
        private TabPage loginTabPage;
        private TextBox PasswordTextBox;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
        private TabPage registerTabPage;
        private Button loginBtn;
        private Button registerBtn;
        private TextBox regConfirmPasswordTextBox;
        private TextBox regPasswordTextBox;
        private TextBox regUsernameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox regAvailableRoomsComboBox;
        private Label label7;
        private TextBox regEmailTextBox;
        private Label label6;
        private TextBox regFullNameTextBox;
        private Label label8;
        private Label label9;
        private DateTimePicker birthdateDateTimePicker;
    }
}
