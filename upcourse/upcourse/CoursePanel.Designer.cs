namespace upcourse
{
    partial class CoursePanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.Label();
            this.CourseDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.CourseDescription);
            this.panel1.Controls.Add(this.CourseName);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 170);
            this.panel1.TabIndex = 0;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(653, 120);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(238, 23);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "button1";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(27, 19);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(71, 13);
            this.CourseName.TabIndex = 1;
            this.CourseName.Text = "Course Name";
            this.CourseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // CourseDescription
            // 
            this.CourseDescription.AutoSize = true;
            this.CourseDescription.Location = new System.Drawing.Point(27, 107);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(89, 13);
            this.CourseDescription.TabIndex = 2;
            this.CourseDescription.Text = "CourseDiscription";
            // 
            // CoursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CoursePanel";
            this.Size = new System.Drawing.Size(925, 170);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label CourseDescription;
    }
}
