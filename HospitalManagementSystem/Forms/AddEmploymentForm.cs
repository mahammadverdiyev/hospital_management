using System;
using System.Windows.Forms;
using System.Collections.Generic;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Forms
{
    public partial class AddEmploymentForm : Form
    {
        private List<Employment> employments;

        public AddEmploymentForm()
        {
            InitializeComponent();
            employments = new List<Employment>();
        }

        public event EventHandler OnEmploymentAdded;

        private void AddButton_Click(object sender, EventArgs e)
        {
            string position = positionTextBox.Text;
            string jobDescription = jobDescriptionTextBox.Text;
            string workplace = workplaceTextBox.Text;
            DateTime startingDate = startingDateDateTimePicker.Value;
            DateTime endingDate = endingDateDateTimePicker.Value;

            Employment employment = new Employment()
            {
                Position = position,
                JobDescription = jobDescription,
                WorkPlace = workplace,
                StartingDate = startingDate,
                EndingDate = endingDate
            };

            employments.Add(employment);
            OnEmploymentAdded?.Invoke(this, new EventArgs());
            Close();
        }

        public Employment GetLastAddedEmployment()
        {
            return employments[employments.Count - 1];
        }

        public List<Employment> GetEmployments()
        {
            return employments;
        }
    }
}
