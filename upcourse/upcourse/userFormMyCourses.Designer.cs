namespace upcourse
{
    partial class userFormMyCourses
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
            this.MyCoursesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MyCoursesFlowPanel
            // 
            this.MyCoursesFlowPanel.AutoScroll = true;
            this.MyCoursesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyCoursesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MyCoursesFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.MyCoursesFlowPanel.Name = "MyCoursesFlowPanel";
            this.MyCoursesFlowPanel.Size = new System.Drawing.Size(971, 534);
            this.MyCoursesFlowPanel.TabIndex = 0;
            this.MyCoursesFlowPanel.WrapContents = false;
            // 
            // userFormMyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.MyCoursesFlowPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "userFormMyCourses";
            this.Size = new System.Drawing.Size(971, 534);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MyCoursesFlowPanel;
    }
}
