
namespace HospitalManagementSystem.Forms
{
    partial class DoctorDetail
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
            this.doctorFullName = new System.Windows.Forms.Label();
            this.doctorPosition = new System.Windows.Forms.Label();
            this.doctorPhoneNumber = new System.Windows.Forms.Label();
            this.makeReservationButton = new System.Windows.Forms.Button();
            this.doctorEducations = new System.Windows.Forms.Label();
            this.doctorEmployments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorFullName
            // 
            this.doctorFullName.AutoSize = true;
            this.doctorFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFullName.Location = new System.Drawing.Point(316, 23);
            this.doctorFullName.Name = "doctorFullName";
            this.doctorFullName.Size = new System.Drawing.Size(224, 32);
            this.doctorFullName.TabIndex = 1;
            this.doctorFullName.Text = "Name Surname";
            // 
            // doctorPosition
            // 
            this.doctorPosition.AutoSize = true;
            this.doctorPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.doctorPosition.Location = new System.Drawing.Point(316, 118);
            this.doctorPosition.Name = "doctorPosition";
            this.doctorPosition.Size = new System.Drawing.Size(76, 24);
            this.doctorPosition.TabIndex = 2;
            this.doctorPosition.Text = "Position";
            // 
            // doctorPhoneNumber
            // 
            this.doctorPhoneNumber.AutoSize = true;
            this.doctorPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.doctorPhoneNumber.Location = new System.Drawing.Point(318, 199);
            this.doctorPhoneNumber.Name = "doctorPhoneNumber";
            this.doctorPhoneNumber.Size = new System.Drawing.Size(108, 18);
            this.doctorPhoneNumber.TabIndex = 3;
            this.doctorPhoneNumber.Text = "Phone Number";
            // 
            // makeReservationButton
            // 
            this.makeReservationButton.BackColor = System.Drawing.Color.Teal;
            this.makeReservationButton.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.makeReservationButton.ForeColor = System.Drawing.Color.White;
            this.makeReservationButton.Location = new System.Drawing.Point(24, 240);
            this.makeReservationButton.Name = "makeReservationButton";
            this.makeReservationButton.Size = new System.Drawing.Size(214, 57);
            this.makeReservationButton.TabIndex = 4;
            this.makeReservationButton.Text = "Set reservation";
            this.makeReservationButton.UseVisualStyleBackColor = false;
            this.makeReservationButton.Click += new System.EventHandler(this.SetReservation);
            // 
            // doctorEducations
            // 
            this.doctorEducations.AutoSize = true;
            this.doctorEducations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.doctorEducations.Location = new System.Drawing.Point(318, 276);
            this.doctorEducations.Name = "doctorEducations";
            this.doctorEducations.Size = new System.Drawing.Size(82, 18);
            this.doctorEducations.TabIndex = 5;
            this.doctorEducations.Text = "Educations";
            // 
            // doctorEmployments
            // 
            this.doctorEmployments.AutoSize = true;
            this.doctorEmployments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.doctorEmployments.Location = new System.Drawing.Point(318, 363);
            this.doctorEmployments.Name = "doctorEmployments";
            this.doctorEmployments.Size = new System.Drawing.Size(99, 18);
            this.doctorEmployments.TabIndex = 6;
            this.doctorEmployments.Text = "Employments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(318, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Educations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(318, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(316, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(318, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // doctorImage
            // 
            this.doctorImage.Location = new System.Drawing.Point(24, 23);
            this.doctorImage.Name = "doctorImage";
            this.doctorImage.Size = new System.Drawing.Size(214, 194);
            this.doctorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctorImage.TabIndex = 0;
            this.doctorImage.TabStop = false;
            // 
            // DoctorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorEmployments);
            this.Controls.Add(this.doctorEducations);
            this.Controls.Add(this.makeReservationButton);
            this.Controls.Add(this.doctorPhoneNumber);
            this.Controls.Add(this.doctorPosition);
            this.Controls.Add(this.doctorFullName);
            this.Controls.Add(this.doctorImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorDetail";
            this.ShowIcon = false;
            this.Text = "DoctorDetail";
            this.Load += new System.EventHandler(this.DoctorDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doctorImage;
        private System.Windows.Forms.Label doctorFullName;
        private System.Windows.Forms.Label doctorPosition;
        private System.Windows.Forms.Label doctorPhoneNumber;
        private System.Windows.Forms.Button makeReservationButton;
        private System.Windows.Forms.Label doctorEducations;
        private System.Windows.Forms.Label doctorEmployments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}