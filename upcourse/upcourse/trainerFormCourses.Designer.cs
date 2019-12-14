namespace upcourse
{
    partial class trainerFormCourses
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
            this.CoursesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CoursesFlowPanel
            // 
            this.CoursesFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoursesFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.CoursesFlowPanel.Name = "CoursesFlowPanel";
            this.CoursesFlowPanel.Size = new System.Drawing.Size(760, 536);
            this.CoursesFlowPanel.TabIndex = 0;
            this.CoursesFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // trainerFormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CoursesFlowPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "trainerFormCourses";
            this.Size = new System.Drawing.Size(760, 536);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CoursesFlowPanel;
    }
}
