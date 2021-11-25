namespace HospitalManagementSystem.Forms
{
    partial class AdminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.doctorsButton = new System.Windows.Forms.Button();
            this.patientsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.removeDoctorButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.doctorsButton);
            this.panel1.Controls.Add(this.patientsButton);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 425);
            this.panel1.TabIndex = 0;
            // 
            // doctorsButton
            // 
            this.doctorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsButton.Location = new System.Drawing.Point(-1, 15);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(224, 49);
            this.doctorsButton.TabIndex = 1;
            this.doctorsButton.Text = "Doctors";
            this.doctorsButton.UseVisualStyleBackColor = true;
            this.doctorsButton.Click += new System.EventHandler(this.DoctorsButton_Click);
            // 
            // patientsButton
            // 
            this.patientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsButton.Location = new System.Drawing.Point(-2, 81);
            this.patientsButton.Name = "patientsButton";
            this.patientsButton.Size = new System.Drawing.Size(225, 49);
            this.patientsButton.TabIndex = 2;
            this.patientsButton.Text = "Patients";
            this.patientsButton.UseVisualStyleBackColor = true;
            this.patientsButton.Click += new System.EventHandler(this.PatientsButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(243, 13);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(545, 361);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // addDoctorButton
            // 
            this.addDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctorButton.Location = new System.Drawing.Point(243, 393);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(260, 49);
            this.addDoctorButton.TabIndex = 3;
            this.addDoctorButton.Text = "Add Doctor";
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // removeDoctorButton
            // 
            this.removeDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDoctorButton.Location = new System.Drawing.Point(535, 393);
            this.removeDoctorButton.Name = "removeDoctorButton";
            this.removeDoctorButton.Size = new System.Drawing.Size(253, 49);
            this.removeDoctorButton.TabIndex = 4;
            this.removeDoctorButton.Text = "Remove Doctor";
            this.removeDoctorButton.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeDoctorButton);
            this.Controls.Add(this.addDoctorButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doctorsButton;
        private System.Windows.Forms.Button patientsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button addDoctorButton;
        private System.Windows.Forms.Button removeDoctorButton;
    }
}