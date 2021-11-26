using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Forms
{
    public partial class AddEducationForm : Form
    {
        private List<Education> addedEducations;

        public event EventHandler OnEducationAdded;

        public AddEducationForm()
        {
            InitializeComponent();
            addedEducations = new List<Education>();
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            string university = universityTextBox.Text;
            string department = departmentTextBox.Text;



            Education education = new Education()
            {
                StartingDate = startingDateDateTimePicker.Value,
                EndingDate =endingDateDateTimePicker.Value,
                University = university,
                Department = department,
            };

            addedEducations.Add(education);
            OnEducationAdded?.Invoke(this, EventArgs.Empty);

            Close();
        }

        public Education GetLastAddedEducation()
        {
            return addedEducations[addedEducations.Count - 1];
        }

        public List<Education> GetEducations()
        {
            return addedEducations;
        }
    }
}
