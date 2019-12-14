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
            this.ViewTraineeButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.ForeColor = System.Drawing.Color.White;
            this.CourseName.Location = new System.Drawing.Point(58, 25);
            this.CourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(178, 30);
            this.CourseName.TabIndex = 0;
            this.CourseName.Text = "Course Name";
            // 
            // CourseDescription
            // 
            this.CourseDescription.AutoSize = true;
            this.CourseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDescription.ForeColor = System.Drawing.Color.White;
            this.CourseDescription.Location = new System.Drawing.Point(22, 95);
            this.CourseDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(116, 20);
            this.CourseDescription.TabIndex = 1;
            this.CourseDescription.Text = "CourseDetails";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(832, 121);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(173, 54);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete This Course";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewTraineeButton
            // 
            this.ViewTraineeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ViewTraineeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTraineeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTraineeButton.ForeColor = System.Drawing.Color.White;
            this.ViewTraineeButton.Location = new System.Drawing.Point(832, 25);
            this.ViewTraineeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTraineeButton.Name = "ViewTraineeButton";
            this.ViewTraineeButton.Size = new System.Drawing.Size(173, 54);
            this.ViewTraineeButton.TabIndex = 3;
            this.ViewTraineeButton.Text = "ViewTrainee";
            this.ViewTraineeButton.UseVisualStyleBackColor = false;
            this.ViewTraineeButton.Click += new System.EventHandler(this.ViewTraineeButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(26, 13);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 54);
            this.SidePanel.TabIndex = 5;
            // 
            // AdminCoursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.ViewTraineeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CourseDescription);
            this.Controls.Add(this.CourseName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminCoursePanel";
            this.Size = new System.Drawing.Size(1033, 217);
            this.Load += new System.EventHandler(this.AdminCoursePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label CourseDescription;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ViewTraineeButton;
        private System.Windows.Forms.Panel SidePanel;
    }
}
