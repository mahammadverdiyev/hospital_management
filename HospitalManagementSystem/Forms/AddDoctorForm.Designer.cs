namespace HospitalManagementSystem.Forms
{
    partial class AddDoctorForm
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
            this.components = new System.ComponentModel.Container();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addEducationButton = new System.Windows.Forms.Button();
            this.educationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addEmploymentButton = new System.Windows.Forms.Button();
            this.employmentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(105, 37);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(28, 77);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(44, 13);
            this.positionLabel.TabIndex = 3;
            this.positionLabel.Text = "Position";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(105, 74);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(186, 20);
            this.positionTextBox.TabIndex = 2;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(28, 117);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(128, 114);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(186, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // addEducationButton
            // 
            this.addEducationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEducationButton.Location = new System.Drawing.Point(31, 179);
            this.addEducationButton.Name = "addEducationButton";
            this.addEducationButton.Size = new System.Drawing.Size(155, 42);
            this.addEducationButton.TabIndex = 6;
            this.addEducationButton.Text = "Add Education";
            this.addEducationButton.UseVisualStyleBackColor = true;
            this.addEducationButton.Click += new System.EventHandler(this.AddEducationButton_Click);
            // 
            // educationFlowLayoutPanel
            // 
            this.educationFlowLayoutPanel.AutoScroll = true;
            this.educationFlowLayoutPanel.Location = new System.Drawing.Point(372, 37);
            this.educationFlowLayoutPanel.Name = "educationFlowLayoutPanel";
            this.educationFlowLayoutPanel.Size = new System.Drawing.Size(320, 563);
            this.educationFlowLayoutPanel.TabIndex = 7;
            // 
            // addEmploymentButton
            // 
            this.addEmploymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmploymentButton.Location = new System.Drawing.Point(31, 236);
            this.addEmploymentButton.Name = "addEmploymentButton";
            this.addEmploymentButton.Size = new System.Drawing.Size(155, 42);
            this.addEmploymentButton.TabIndex = 8;
            this.addEmploymentButton.Text = "Add Employment";
            this.addEmploymentButton.UseVisualStyleBackColor = true;
            this.addEmploymentButton.Click += new System.EventHandler(this.AddEmploymentButton_Click);
            // 
            // employmentFlowLayoutPanel
            // 
            this.employmentFlowLayoutPanel.AutoScroll = true;
            this.employmentFlowLayoutPanel.Location = new System.Drawing.Point(784, 37);
            this.employmentFlowLayoutPanel.Name = "employmentFlowLayoutPanel";
            this.employmentFlowLayoutPanel.Size = new System.Drawing.Size(320, 563);
            this.employmentFlowLayoutPanel.TabIndex = 8;
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(105, 558);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(155, 42);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 728);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.employmentFlowLayoutPanel);
            this.Controls.Add(this.addEmploymentButton);
            this.Controls.Add(this.educationFlowLayoutPanel);
            this.Controls.Add(this.addEducationButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameTextBox);
            this.Name = "AddDoctorForm";
            this.Text = "AddDoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button addEducationButton;
        private System.Windows.Forms.FlowLayoutPanel educationFlowLayoutPanel;
        private System.Windows.Forms.Button addEmploymentButton;
        private System.Windows.Forms.FlowLayoutPanel employmentFlowLayoutPanel;
        private System.Windows.Forms.Button doneButton;
    }
}