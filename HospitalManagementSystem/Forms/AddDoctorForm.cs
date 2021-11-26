using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utility;

namespace HospitalManagementSystem.Forms
{
    public partial class AddDoctorForm : Form
    {
        private AddEducationForm addEducationForm;
        private AddEmploymentForm addEmploymentForm;

        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void AddEducationButton_Click(object sender, EventArgs e)
        {
            addEducationForm = new AddEducationForm();
            addEducationForm.Show();
            addEducationForm.OnEducationAdded += AddEducationForm_OnEducationAdded;
        }

        private void AddEducationForm_OnEducationAdded(object sender, EventArgs e)
        {
            PrintEducation(addEducationForm.GetLastAddedEducation());
        }

        private void PrintEducation(Education addedEducation)
        {
            Label educationLabel = new Label()
            {
                Text = addedEducation.ToString(),
                Size = new Size(435, 80),
                BackColor = Color.Gray,
                Font = new Font(FontFamily.GenericSerif, 10, FontStyle.Regular)
            };

            educationFlowLayoutPanel.Controls.Add(educationLabel);
        }

        private void AddEmploymentButton_Click(object sender, EventArgs e)
        {
            addEmploymentForm = new AddEmploymentForm();
            addEmploymentForm.Show();
            addEmploymentForm.OnEmploymentAdded += AddEmploymentForm_OnEmploymentAdded;
        }

        private void AddEmploymentForm_OnEmploymentAdded(object sender, EventArgs e)
        {
            PrintEmployment(addEmploymentForm.GetLastAddedEmployment());
        }

        private void PrintEmployment(Employment addedEmployment)
        {
            Label employmentLabel = new Label()
            {
                Text = addedEmployment.ToString(),
                Size = new Size(435, 80),
                BackColor = Color.Gray,
                Font = new Font(FontFamily.GenericSerif, 10, FontStyle.Regular)
            };

            employmentFlowLayoutPanel.Controls.Add(employmentLabel);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {

            string fullName = fullNameTextBox.Text;
            string position = positionTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string sex = sexComboBox.Text;
            string email = emailTextBox.Text;

            if(string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(position) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(sex) || 
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Fields are empty");
                return;
            }

            if (DatabaseManager.Instance().DoctorExists(email))
            {
                MessageBox.Show("This email has been already registered for another doctor");
                return;
            }


            string password = Encryptor.Encrypt(passwordTextBox.Text,"cleancoders");
            List<Education> educations = addEducationForm.GetEducations();
            List<Employment> employments = addEmploymentForm.GetEmployments();
            List<Reservation> reservations = new List<Reservation>();


            byte[] imageData = null;

            if (sex == "Male")
                imageData = FileUtility.ImageToByteArray(HospitalManagementSystem.Properties.Resources.male);

            else
                imageData = FileUtility.ImageToByteArray(HospitalManagementSystem.Properties.Resources.female);

            Doctor newDoctor = new Doctor()
            {
                Image = imageData,
                Sex = sex,
                Email= email,
                Password= password,
                FullName = fullName,
                Position = position,
                PhoneNumber = phoneNumber,
                Educations = educations,
                Employments = employments,
                Reservations = reservations
            };

            foreach (Education education in newDoctor.Educations)
            {
                education.Doctor = newDoctor;
            }

            foreach (Employment employment in newDoctor.Employments)
            {
                employment.Doctor = newDoctor;
            }


            DatabaseManager.Instance().AddEducations(educations);
            DatabaseManager.Instance().AddEmployments(employments);
            DatabaseManager.Instance().AddDoctor(newDoctor);
            DatabaseManager.Instance().SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }
    }
}
