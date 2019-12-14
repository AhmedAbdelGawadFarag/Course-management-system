namespace upcourse
{
    partial class TrainerCoursePanel
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
            this.CourseDescription = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Controls.Add(this.CourseName);
            this.panel1.Controls.Add(this.CourseDescription);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 177);
            this.panel1.TabIndex = 0;
            // 
            // CourseDescription
            // 
            this.CourseDescription.AutoSize = true;
            this.CourseDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDescription.Location = new System.Drawing.Point(49, 84);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(49, 19);
            this.CourseDescription.TabIndex = 0;
            this.CourseDescription.Text = "label1";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.Location = new System.Drawing.Point(49, 20);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(65, 26);
            this.CourseName.TabIndex = 1;
            this.CourseName.Text = "label2";
            // 
            // ViewButton
            // 
            this.ViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ViewButton.Location = new System.Drawing.Point(581, 122);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(119, 23);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View Trainees";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainerCoursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TrainerCoursePanel";
            this.Size = new System.Drawing.Size(773, 177);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label CourseDescription;
    }
}
