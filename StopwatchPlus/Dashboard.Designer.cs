namespace StopwatchPlus
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.timeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.saveLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.reEnterPasswordLabel = new System.Windows.Forms.Label();
            this.reEnterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.returningLabel = new System.Windows.Forms.Label();
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.enterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveLatestTimeButton = new System.Windows.Forms.Button();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeLabel.Location = new System.Drawing.Point(186, 25);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(264, 31);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "-------------------------";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(186, 104);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(280, 153);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(342, 104);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(114, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.ForeColor = System.Drawing.Color.Black;
            this.saveLabel.Location = new System.Drawing.Point(182, 193);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(284, 20);
            this.saveLabel.TabIndex = 4;
            this.saveLabel.Text = "///////////////////////////////////////////////////////";
            this.saveLabel.Click += new System.EventHandler(this.saveLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(134, 252);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(73, 16);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(134, 289);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(73, 16);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(134, 328);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(213, 246);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(237, 22);
            this.firstNameTextBox.TabIndex = 8;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(213, 283);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(237, 22);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(213, 322);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(237, 22);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // reEnterPasswordLabel
            // 
            this.reEnterPasswordLabel.AutoSize = true;
            this.reEnterPasswordLabel.Location = new System.Drawing.Point(82, 357);
            this.reEnterPasswordLabel.Name = "reEnterPasswordLabel";
            this.reEnterPasswordLabel.Size = new System.Drawing.Size(119, 16);
            this.reEnterPasswordLabel.TabIndex = 11;
            this.reEnterPasswordLabel.Text = "Reenter Password";
            // 
            // reEnterPasswordTextBox
            // 
            this.reEnterPasswordTextBox.Location = new System.Drawing.Point(213, 357);
            this.reEnterPasswordTextBox.Name = "reEnterPasswordTextBox";
            this.reEnterPasswordTextBox.PasswordChar = '*';
            this.reEnterPasswordTextBox.Size = new System.Drawing.Size(237, 22);
            this.reEnterPasswordTextBox.TabIndex = 12;
            this.reEnterPasswordTextBox.TextChanged += new System.EventHandler(this.reEnterPasswordTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(291, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returningLabel
            // 
            this.returningLabel.AutoSize = true;
            this.returningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returningLabel.Location = new System.Drawing.Point(261, 444);
            this.returningLabel.Name = "returningLabel";
            this.returningLabel.Size = new System.Drawing.Size(140, 20);
            this.returningLabel.TabIndex = 14;
            this.returningLabel.Text = "***Returning?***";
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Location = new System.Drawing.Point(82, 477);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(102, 16);
            this.enterPasswordLabel.TabIndex = 15;
            this.enterPasswordLabel.Text = "Enter Password";
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(213, 477);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.PasswordChar = '*';
            this.enterPasswordTextBox.Size = new System.Drawing.Size(237, 22);
            this.enterPasswordTextBox.TabIndex = 16;
            this.enterPasswordTextBox.TextChanged += new System.EventHandler(this.enterPasswordTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(472, 475);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveLatestTimeButton
            // 
            this.saveLatestTimeButton.Location = new System.Drawing.Point(265, 515);
            this.saveLatestTimeButton.Name = "saveLatestTimeButton";
            this.saveLatestTimeButton.Size = new System.Drawing.Size(159, 23);
            this.saveLatestTimeButton.TabIndex = 18;
            this.saveLatestTimeButton.Text = "Save Latest Time";
            this.saveLatestTimeButton.UseVisualStyleBackColor = true;
            this.saveLatestTimeButton.Click += new System.EventHandler(this.saveLatestTimeButton_Click);
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 16;
            this.personListBox.Location = new System.Drawing.Point(85, 557);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(488, 20);
            this.personListBox.TabIndex = 19;
            this.personListBox.SelectedIndexChanged += new System.EventHandler(this.personListBox_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(646, 614);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.saveLatestTimeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.enterPasswordTextBox);
            this.Controls.Add(this.enterPasswordLabel);
            this.Controls.Add(this.returningLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reEnterPasswordTextBox);
            this.Controls.Add(this.reEnterPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "StopwatchPlus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label reEnterPasswordLabel;
        private System.Windows.Forms.TextBox reEnterPasswordTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label returningLabel;
        private System.Windows.Forms.Label enterPasswordLabel;
        private System.Windows.Forms.TextBox enterPasswordTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveLatestTimeButton;
        private System.Windows.Forms.ListBox personListBox;
    }
}

