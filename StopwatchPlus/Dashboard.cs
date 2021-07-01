using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace StopwatchPlus
{
    public partial class Dashboard : Form
    {
        List<Person> person = new List<Person>();
        Stopwatch stopwatch = new Stopwatch();
        DateTime date = DateTime.Now;        
        string dateAtStop;
        string timeLabelDefaultTxt = "-------------------------";
        string saveLabelDefaultTxt = "///////////////////////////////////////////////////////";

        public Dashboard()
        {
            InitializeComponent();

            UpdatePerson();
        }
        private void UpdatePerson()
        {
            personListBox.DataSource = person;
            personListBox.DisplayMember = "PersonInfo";            
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timeLabel.Text = "   R-U-N-N-I-N-G";
            saveLabel.Text = saveLabelDefaultTxt;  //No info here when RUNNING
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timeLabel.Text = stopwatch.Elapsed.ToString();
            dateAtStop = date.ToShortDateString();            
            saveLabel.Text = "If you're new, enter info below and save.";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timeLabel.Text = timeLabelDefaultTxt;            
            saveLabel.Text = saveLabelDefaultTxt;            
        }

        private void saveLabel_Click(object sender, EventArgs e)
        {            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();            

            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                saveLabel.Text = "                Enter all info!";                           //If these are emtpy, notify user
                return;
            }
            if (passwordTextBox.Text != reEnterPasswordTextBox.Text)
            {
                saveLabel.Text = "Passwords do not match, try again.";
                passwordTextBox.Text = "";                                                     //If passwords do not match, clear them
                reEnterPasswordTextBox.Text = "";                
                return;
            }
            if (timeLabel.Text == "" || timeLabel.Text == timeLabelDefaultTxt)
            {                                                                               //If no time listed....
                saveLabel.Text = "  No time was indicated to save.";               
                return;                
            }

            dataAccess.InsertPerson(firstNameTextBox.Text, lastNameTextBox.Text,
                                   passwordTextBox.Text, timeLabel.Text, dateAtStop);              //insert into database

            firstNameTextBox.Text = ""; lastNameTextBox.Text = ""; passwordTextBox.Text = "";
            timeLabel.Text = ""; dateAtStop = ""; reEnterPasswordTextBox.Text = "";
            saveLabel.Text = saveLabelDefaultTxt; timeLabel.Text = timeLabelDefaultTxt;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (enterPasswordTextBox.Text == "")
            {
                return;
            }

            DataAccess dataAccess = new DataAccess();

            person = dataAccess.GetPerson(enterPasswordTextBox.Text);

            UpdatePerson();
        }

        private void saveLatestTimeButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            dataAccess.LatestTimeInsert(timeLabel.Text, dateAtStop, enterPasswordTextBox.Text);

            dateAtStop = ""; enterPasswordTextBox.Text = "";

            clearButton.PerformClick();
        }

        private void enterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reEnterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
