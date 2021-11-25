namespace HospitalManagementSystem
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.controlTitle = new System.Windows.Forms.Label();
            this.controlSubTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.controlIcon = new System.Windows.Forms.PictureBox();
            this.thirdTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTitle
            // 
            this.controlTitle.AutoSize = true;
            this.controlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.controlTitle.Location = new System.Drawing.Point(234, 13);
            this.controlTitle.Name = "controlTitle";
            this.controlTitle.Size = new System.Drawing.Size(66, 31);
            this.controlTitle.TabIndex = 1;
            this.controlTitle.Text = "Title";
            // 
            // controlSubTitle
            // 
            this.controlSubTitle.AutoSize = true;
            this.controlSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.controlSubTitle.Location = new System.Drawing.Point(236, 57);
            this.controlSubTitle.Name = "controlSubTitle";
            this.controlSubTitle.Size = new System.Drawing.Size(70, 20);
            this.controlSubTitle.TabIndex = 2;
            this.controlSubTitle.Text = "Sub title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 1);
            this.panel2.TabIndex = 4;
            // 
            // controlIcon
            // 
            this.controlIcon.BackColor = System.Drawing.Color.Transparent;
            this.controlIcon.Image = ((System.Drawing.Image)(resources.GetObject("controlIcon.Image")));
            this.controlIcon.Location = new System.Drawing.Point(13, 13);
            this.controlIcon.Name = "controlIcon";
            this.controlIcon.Size = new System.Drawing.Size(153, 140);
            this.controlIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.controlIcon.TabIndex = 0;
            this.controlIcon.TabStop = false;
            // 
            // thirdTitle
            // 
            this.thirdTitle.AutoSize = true;
            this.thirdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.thirdTitle.Location = new System.Drawing.Point(240, 107);
            this.thirdTitle.Name = "thirdTitle";
            this.thirdTitle.Size = new System.Drawing.Size(63, 18);
            this.thirdTitle.TabIndex = 5;
            this.thirdTitle.Text = "thirdTitle";
            this.thirdTitle.Visible = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.thirdTitle);
            this.Controls.Add(this.controlIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.controlSubTitle);
            this.Controls.Add(this.controlTitle);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(690, 166);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.controlIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label controlTitle;
        private System.Windows.Forms.Label controlSubTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox controlIcon;
        private System.Windows.Forms.Label thirdTitle;
    }
}
