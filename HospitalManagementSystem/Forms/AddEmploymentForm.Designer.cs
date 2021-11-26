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
            this.jobDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.workplaceTextBox = new System.Windows.Forms.TextBox();
            this.startingDateLabel = new System.Windows.Forms.Label();
            this.endingDateLabel = new System.Windows.Forms.Label();
            this.endingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(111, 463);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 44);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // jobDescriptionTextBox
            // 
            this.jobDescriptionTextBox.Location = new System.Drawing.Point(141, 64);
            this.jobDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jobDescriptionTextBox.Multiline = true;
            this.jobDescriptionTextBox.Name = "jobDescriptionTextBox";
            this.jobDescriptionTextBox.Size = new System.Drawing.Size(265, 200);
            this.jobDescriptionTextBox.TabIndex = 12;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(25, 68);
            this.jobDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(106, 17);
            this.jobDescriptionLabel.TabIndex = 11;
            this.jobDescriptionLabel.Text = "Job Description";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(141, 15);
            this.positionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(265, 22);
            this.positionTextBox.TabIndex = 10;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(25, 18);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(58, 17);
            this.positionLabel.TabIndex = 9;
            this.positionLabel.Text = "Position";
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.AutoSize = true;
            this.workplaceLabel.Location = new System.Drawing.Point(25, 308);
            this.workplaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(75, 17);
            this.workplaceLabel.TabIndex = 18;
            this.workplaceLabel.Text = "Workplace";
            // 
            // workplaceTextBox
            // 
            this.workplaceTextBox.Location = new System.Drawing.Point(141, 304);
            this.workplaceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workplaceTextBox.Name = "workplaceTextBox";
            this.workplaceTextBox.Size = new System.Drawing.Size(265, 22);
            this.workplaceTextBox.TabIndex = 19;
            // 
            // startingDateLabel
            // 
            this.startingDateLabel.AutoSize = true;
            this.startingDateLabel.Location = new System.Drawing.Point(25, 351);
            this.startingDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingDateLabel.Name = "startingDateLabel";
            this.startingDateLabel.Size = new System.Drawing.Size(91, 17);
            this.startingDateLabel.TabIndex = 13;
            this.startingDateLabel.Text = "Starting Date";
            // 
            // endingDateLabel
            // 
            this.endingDateLabel.AutoSize = true;
            this.endingDateLabel.Location = new System.Drawing.Point(25, 396);
            this.endingDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingDateLabel.Name = "endingDateLabel";
            this.endingDateLabel.Size = new System.Drawing.Size(86, 17);
            this.endingDateLabel.TabIndex = 14;
            this.endingDateLabel.Text = "Ending Date";
            // 
            // endingDateDateTimePicker
            // 
            this.endingDateDateTimePicker.Location = new System.Drawing.Point(141, 396);
            this.endingDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.endingDateDateTimePicker.Name = "endingDateDateTimePicker";
            this.endingDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.endingDateDateTimePicker.TabIndex = 16;
            // 
            // startingDateDateTimePicker
            // 
            this.startingDateDateTimePicker.Location = new System.Drawing.Point(141, 351);
            this.startingDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startingDateDateTimePicker.Name = "startingDateDateTimePicker";
            this.startingDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.startingDateDateTimePicker.TabIndex = 15;
            // 
            // AddEmploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 535);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmploymentForm";
            this.Text = "AddEmploymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox jobDescriptionTextBox;
        private System.Windows.Forms.Label jobDescriptionLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.TextBox workplaceTextBox;
        private System.Windows.Forms.Label startingDateLabel;
        private System.Windows.Forms.Label endingDateLabel;
        private System.Windows.Forms.DateTimePicker endingDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startingDateDateTimePicker;
    }
}