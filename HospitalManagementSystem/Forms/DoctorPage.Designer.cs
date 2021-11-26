
namespace HospitalManagementSystem
{
    partial class DoctorPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptedReservationsButton = new System.Windows.Forms.Button();
            this.requestedReservationsButton = new System.Windows.Forms.Button();
            this.reservationPanel = new System.Windows.Forms.Panel();
            this.resPatientAvatar = new System.Windows.Forms.PictureBox();
            this.noResLabel = new System.Windows.Forms.Label();
            this.nextReservationDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.reservationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resPatientAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.myProfileButton);
            this.panel1.Controls.Add(this.labelFullName);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.userAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 692);
            this.panel1.TabIndex = 6;
            // 
            // myProfileButton
            // 
            this.myProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.myProfileButton.FlatAppearance.BorderSize = 0;
            this.myProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileButton.ForeColor = System.Drawing.Color.White;
            this.myProfileButton.Location = new System.Drawing.Point(12, 265);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(230, 55);
            this.myProfileButton.TabIndex = 3;
            this.myProfileButton.Text = "My Profile";
            this.myProfileButton.UseVisualStyleBackColor = false;
            this.myProfileButton.Click += new System.EventHandler(this.MyProfileButton_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(12, 206);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(94, 23);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Olive;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(12, 351);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(230, 55);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // userAvatar
            // 
            this.userAvatar.Image = global::HospitalManagementSystem.Properties.Resources.male;
            this.userAvatar.Location = new System.Drawing.Point(12, 20);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(230, 168);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatar.TabIndex = 0;
            this.userAvatar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label3.Location = new System.Drawing.Point(427, -103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available doctors";
            // 
            // acceptedReservationsButton
            // 
            this.acceptedReservationsButton.BackColor = System.Drawing.Color.Green;
            this.acceptedReservationsButton.FlatAppearance.BorderSize = 0;
            this.acceptedReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptedReservationsButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedReservationsButton.ForeColor = System.Drawing.Color.White;
            this.acceptedReservationsButton.Location = new System.Drawing.Point(456, 441);
            this.acceptedReservationsButton.Name = "acceptedReservationsButton";
            this.acceptedReservationsButton.Size = new System.Drawing.Size(355, 89);
            this.acceptedReservationsButton.TabIndex = 8;
            this.acceptedReservationsButton.Text = "Accepted Reservations";
            this.acceptedReservationsButton.UseVisualStyleBackColor = false;
            this.acceptedReservationsButton.Click += new System.EventHandler(this.acceptedReservationsButton_Click);
            // 
            // requestedReservationsButton
            // 
            this.requestedReservationsButton.BackColor = System.Drawing.Color.Orange;
            this.requestedReservationsButton.FlatAppearance.BorderSize = 0;
            this.requestedReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestedReservationsButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedReservationsButton.ForeColor = System.Drawing.Color.White;
            this.requestedReservationsButton.Location = new System.Drawing.Point(456, 560);
            this.requestedReservationsButton.Name = "requestedReservationsButton";
            this.requestedReservationsButton.Size = new System.Drawing.Size(355, 89);
            this.requestedReservationsButton.TabIndex = 9;
            this.requestedReservationsButton.Text = "Requested Reservations";
            this.requestedReservationsButton.UseVisualStyleBackColor = false;
            this.requestedReservationsButton.Click += new System.EventHandler(this.requestedReversationsButton_Click);
            // 
            // reservationPanel
            // 
            this.reservationPanel.Controls.Add(this.descriptionLabel);
            this.reservationPanel.Controls.Add(this.fullNameLabel);
            this.reservationPanel.Controls.Add(this.resPatientAvatar);
            this.reservationPanel.Controls.Add(this.nextReservationDateLabel);
            this.reservationPanel.Controls.Add(this.label4);
            this.reservationPanel.Location = new System.Drawing.Point(282, 20);
            this.reservationPanel.Name = "reservationPanel";
            this.reservationPanel.Size = new System.Drawing.Size(747, 224);
            this.reservationPanel.TabIndex = 10;
            // 
            // resPatientAvatar
            // 
            this.resPatientAvatar.Location = new System.Drawing.Point(12, 30);
            this.resPatientAvatar.Name = "resPatientAvatar";
            this.resPatientAvatar.Size = new System.Drawing.Size(181, 168);
            this.resPatientAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resPatientAvatar.TabIndex = 4;
            this.resPatientAvatar.TabStop = false;
            // 
            // noResLabel
            // 
            this.noResLabel.AutoSize = true;
            this.noResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.noResLabel.Location = new System.Drawing.Point(400, 261);
            this.noResLabel.Name = "noResLabel";
            this.noResLabel.Size = new System.Drawing.Size(498, 48);
            this.noResLabel.TabIndex = 3;
            this.noResLabel.Text = "You have no Reservation.";
            this.noResLabel.Visible = false;
            // 
            // nextReservationDateLabel
            // 
            this.nextReservationDateLabel.AutoSize = true;
            this.nextReservationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.nextReservationDateLabel.Location = new System.Drawing.Point(471, 30);
            this.nextReservationDateLabel.Name = "nextReservationDateLabel";
            this.nextReservationDateLabel.Size = new System.Drawing.Size(205, 25);
            this.nextReservationDateLabel.TabIndex = 2;
            this.nextReservationDateLabel.Text = "Next reservation Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label4.Location = new System.Drawing.Point(221, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Next reservation Date:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.fullNameLabel.Location = new System.Drawing.Point(221, 88);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(106, 26);
            this.fullNameLabel.TabIndex = 11;
            this.fullNameLabel.Text = "FullName";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.descriptionLabel.Location = new System.Drawing.Point(221, 142);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(121, 26);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // DoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 692);
            this.Controls.Add(this.reservationPanel);
            this.Controls.Add(this.noResLabel);
            this.Controls.Add(this.requestedReservationsButton);
            this.Controls.Add(this.acceptedReservationsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorPage";
            this.Text = "DoctorPage";
            this.Load += new System.EventHandler(this.DoctorPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.reservationPanel.ResumeLayout(false);
            this.reservationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resPatientAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptedReservationsButton;
        private System.Windows.Forms.Button requestedReservationsButton;
        private System.Windows.Forms.Panel reservationPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nextReservationDateLabel;
        private System.Windows.Forms.Label noResLabel;
        private System.Windows.Forms.PictureBox resPatientAvatar;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}