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
            this.panel6 = new System.Windows.Forms.Panel();
            this.CourseDescription = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.CourseDescription);
            this.panel1.Controls.Add(this.CourseName);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 170);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Location = new System.Drawing.Point(14, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 40);
            this.panel6.TabIndex = 3;
            // 
            // CourseDescription
            // 
            this.CourseDescription.AutoSize = true;
            this.CourseDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDescription.ForeColor = System.Drawing.Color.White;
            this.CourseDescription.Location = new System.Drawing.Point(31, 55);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(126, 19);
            this.CourseDescription.TabIndex = 2;
            this.CourseDescription.Text = "CourseDiscription";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.CourseName.ForeColor = System.Drawing.Color.SeaGreen;
            this.CourseName.Location = new System.Drawing.Point(27, 19);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(131, 22);
            this.CourseName.TabIndex = 1;
            this.CourseName.Text = "Course Name";
            this.CourseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.RegisterButton.Location = new System.Drawing.Point(653, 91);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(238, 52);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Enroll Now!";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
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
        private System.Windows.Forms.Panel panel6;
    }
}
