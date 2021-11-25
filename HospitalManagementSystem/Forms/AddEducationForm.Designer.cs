namespace HospitalManagementSystem.Forms
{
    partial class AddEducationForm
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
            this.universityLabel = new System.Windows.Forms.Label();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.startingYearLabel = new System.Windows.Forms.Label();
            this.endingYear = new System.Windows.Forms.Label();
            this.startingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Location = new System.Drawing.Point(30, 22);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(53, 13);
            this.universityLabel.TabIndex = 0;
            this.universityLabel.Text = "University";
            // 
            // universityTextBox
            // 
            this.universityTextBox.Location = new System.Drawing.Point(117, 19);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(194, 20);
            this.universityTextBox.TabIndex = 1;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(117, 59);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(194, 20);
            this.departmentTextBox.TabIndex = 3;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(30, 62);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(62, 13);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Department";
            // 
            // startingYearLabel
            // 
            this.startingYearLabel.AutoSize = true;
            this.startingYearLabel.Location = new System.Drawing.Point(30, 111);
            this.startingYearLabel.Name = "startingYearLabel";
            this.startingYearLabel.Size = new System.Drawing.Size(69, 13);
            this.startingYearLabel.TabIndex = 4;
            this.startingYearLabel.Text = "Starting Date";
            // 
            // endingYear
            // 
            this.endingYear.AutoSize = true;
            this.endingYear.Location = new System.Drawing.Point(30, 148);
            this.endingYear.Name = "endingYear";
            this.endingYear.Size = new System.Drawing.Size(66, 13);
            this.endingYear.TabIndex = 5;
            this.endingYear.Text = "Ending Date";
            // 
            // startingDateDateTimePicker
            // 
            this.startingDateDateTimePicker.Location = new System.Drawing.Point(117, 111);
            this.startingDateDateTimePicker.Name = "startingDateDateTimePicker";
            this.startingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startingDateDateTimePicker.TabIndex = 6;
            // 
            // endingDateDateTimePicker
            // 
            this.endingDateDateTimePicker.Location = new System.Drawing.Point(117, 148);
            this.endingDateDateTimePicker.Name = "endingDateDateTimePicker";
            this.endingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endingDateDateTimePicker.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(98, 191);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 36);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 239);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endingDateDateTimePicker);
            this.Controls.Add(this.startingDateDateTimePicker);
            this.Controls.Add(this.endingYear);
            this.Controls.Add(this.startingYearLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.universityTextBox);
            this.Controls.Add(this.universityLabel);
            this.Name = "AddEducationForm";
            this.Text = "AddEducationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.TextBox universityTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label startingYearLabel;
        private System.Windows.Forms.Label endingYear;
        private System.Windows.Forms.DateTimePicker startingDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endingDateDateTimePicker;
        private System.Windows.Forms.Button addButton;
    }
}