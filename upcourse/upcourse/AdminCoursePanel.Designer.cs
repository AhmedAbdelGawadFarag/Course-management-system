namespace upcourse
{
    partial class AdminCoursePanel
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
            this.CourseName = new System.Windows.Forms.Label();
            this.CourseDescription = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(26, 21);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(68, 13);
            this.CourseName.TabIndex = 0;
            this.CourseName.Text = "CourseName";
            // 
            // CourseDescription
            // 
            this.CourseDescription.AutoSize = true;
            this.CourseDescription.Location = new System.Drawing.Point(26, 114);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(72, 13);
            this.CourseDescription.TabIndex = 1;
            this.CourseDescription.Text = "CourseDetails";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(559, 144);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete This Course";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AdminCoursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CourseDescription);
            this.Controls.Add(this.CourseName);
            this.Name = "AdminCoursePanel";
            this.Size = new System.Drawing.Size(758, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label CourseDescription;
        private System.Windows.Forms.Button DeleteButton;
    }
}
