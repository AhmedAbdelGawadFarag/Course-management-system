namespace upcourse
{
    partial class CoursesPanelWithProgress
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.CourseDescription = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CertificatedBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Location = new System.Drawing.Point(14, 9);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 40);
            this.panel6.TabIndex = 6;
            // 
            // CourseDescription
            // 
            this.CourseDescription.AutoSize = true;
            this.CourseDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDescription.ForeColor = System.Drawing.Color.White;
            this.CourseDescription.Location = new System.Drawing.Point(10, 69);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(126, 19);
            this.CourseDescription.TabIndex = 5;
            this.CourseDescription.Text = "CourseDiscription";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.CourseName.ForeColor = System.Drawing.Color.SeaGreen;
            this.CourseName.Location = new System.Drawing.Point(27, 18);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(131, 22);
            this.CourseName.TabIndex = 4;
            this.CourseName.Text = "Course Name";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(667, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(626, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CertificatedBox
            // 
            this.CertificatedBox.AutoSize = true;
            this.CertificatedBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CertificatedBox.Location = new System.Drawing.Point(667, 31);
            this.CertificatedBox.Name = "CertificatedBox";
            this.CertificatedBox.Size = new System.Drawing.Size(79, 17);
            this.CertificatedBox.TabIndex = 9;
            this.CertificatedBox.Text = "Certificated";
            this.CertificatedBox.UseVisualStyleBackColor = true;
            // 
            // CoursesPanelWithProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.CertificatedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.CourseDescription);
            this.Controls.Add(this.CourseName);
            this.Name = "CoursesPanelWithProgress";
            this.Size = new System.Drawing.Size(925, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label CourseDescription;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CertificatedBox;
    }
}
