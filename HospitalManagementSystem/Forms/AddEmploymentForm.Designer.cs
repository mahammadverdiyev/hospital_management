namespace HospitalManagementSystem.Forms
{
    partial class AddEmploymentForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.endingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endingDateLabel = new System.Windows.Forms.Label();
            this.startingDateLabel = new System.Windows.Forms.Label();
            this.jobDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.workplaceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(83, 376);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 36);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // endingDateDateTimePicker
            // 
            this.endingDateDateTimePicker.Location = new System.Drawing.Point(106, 322);
            this.endingDateDateTimePicker.Name = "endingDateDateTimePicker";
            this.endingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endingDateDateTimePicker.TabIndex = 16;
            // 
            // startingDateDateTimePicker
            // 
            this.startingDateDateTimePicker.Location = new System.Drawing.Point(106, 285);
            this.startingDateDateTimePicker.Name = "startingDateDateTimePicker";
            this.startingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startingDateDateTimePicker.TabIndex = 15;
            // 
            // endingDateLabel
            // 
            this.endingDateLabel.AutoSize = true;
            this.endingDateLabel.Location = new System.Drawing.Point(19, 322);
            this.endingDateLabel.Name = "endingDateLabel";
            this.endingDateLabel.Size = new System.Drawing.Size(66, 13);
            this.endingDateLabel.TabIndex = 14;
            this.endingDateLabel.Text = "Ending Date";
            // 
            // startingDateLabel
            // 
            this.startingDateLabel.AutoSize = true;
            this.startingDateLabel.Location = new System.Drawing.Point(19, 285);
            this.startingDateLabel.Name = "startingDateLabel";
            this.startingDateLabel.Size = new System.Drawing.Size(69, 13);
            this.startingDateLabel.TabIndex = 13;
            this.startingDateLabel.Text = "Starting Date";
            // 
            // jobDescriptionTextBox
            // 
            this.jobDescriptionTextBox.Location = new System.Drawing.Point(106, 52);
            this.jobDescriptionTextBox.Multiline = true;
            this.jobDescriptionTextBox.Name = "jobDescriptionTextBox";
            this.jobDescriptionTextBox.Size = new System.Drawing.Size(200, 163);
            this.jobDescriptionTextBox.TabIndex = 12;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(19, 55);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.jobDescriptionLabel.TabIndex = 11;
            this.jobDescriptionLabel.Text = "Job Description";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(106, 12);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(200, 20);
            this.positionTextBox.TabIndex = 10;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(19, 15);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(44, 13);
            this.positionLabel.TabIndex = 9;
            this.positionLabel.Text = "Position";
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.AutoSize = true;
            this.workplaceLabel.Location = new System.Drawing.Point(19, 250);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(59, 13);
            this.workplaceLabel.TabIndex = 18;
            this.workplaceLabel.Text = "Workplace";
            // 
            // workplaceTextBox
            // 
            this.workplaceTextBox.Location = new System.Drawing.Point(106, 247);
            this.workplaceTextBox.Name = "workplaceTextBox";
            this.workplaceTextBox.Size = new System.Drawing.Size(200, 20);
            this.workplaceTextBox.TabIndex = 19;
            // 
            // AddEmploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 435);
            this.Controls.Add(this.workplaceTextBox);
            this.Controls.Add(this.workplaceLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endingDateDateTimePicker);
            this.Controls.Add(this.startingDateDateTimePicker);
            this.Controls.Add(this.endingDateLabel);
            this.Controls.Add(this.startingDateLabel);
            this.Controls.Add(this.jobDescriptionTextBox);
            this.Controls.Add(this.jobDescriptionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.positionLabel);
            this.Name = "AddEmploymentForm";
            this.Text = "AddEmploymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker endingDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startingDateDateTimePicker;
        private System.Windows.Forms.Label endingDateLabel;
        private System.Windows.Forms.Label startingDateLabel;
        private System.Windows.Forms.TextBox jobDescriptionTextBox;
        private System.Windows.Forms.Label jobDescriptionLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.TextBox workplaceTextBox;
    }
}