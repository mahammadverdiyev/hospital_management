
namespace HospitalManagementSystem
{
    partial class PatientPage
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
            this.doctorList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorList
            // 
            this.doctorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorList.AutoScroll = true;
            this.doctorList.Location = new System.Drawing.Point(262, 60);
            this.doctorList.Name = "doctorList";
            this.doctorList.Size = new System.Drawing.Size(864, 636);
            this.doctorList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.reservationsButton);
            this.panel1.Controls.Add(this.myProfileButton);
            this.panel1.Controls.Add(this.labelFullName);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.userAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 696);
            this.panel1.TabIndex = 3;
            // 
            // reservationsButton
            // 
            this.reservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.reservationsButton.FlatAppearance.BorderSize = 0;
            this.reservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsButton.ForeColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(12, 343);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(230, 55);
            this.reservationsButton.TabIndex = 4;
            this.reservationsButton.Text = "My Reservations";
            this.reservationsButton.UseVisualStyleBackColor = false;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
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
            this.myProfileButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(12, 206);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(97, 24);
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
            this.logoutButton.Location = new System.Drawing.Point(12, 422);
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
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 0;
            this.userAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.Location = new System.Drawing.Point(590, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available doctors";
            // 
            // PatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doctorList);
            this.Name = "PatientPage";
            this.Text = "PatientPage";
            this.Load += new System.EventHandler(this.PatientPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel doctorList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button reservationsButton;
    }
}