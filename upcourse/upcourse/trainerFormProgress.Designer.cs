namespace upcourse
{
    partial class trainerFormProgress
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
            this.progressFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // progressFlowPanel
            // 
            this.progressFlowPanel.AutoScroll = true;
            this.progressFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.progressFlowPanel.Name = "progressFlowPanel";
            this.progressFlowPanel.Size = new System.Drawing.Size(854, 536);
            this.progressFlowPanel.TabIndex = 0;
            // 
            // trainerFormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressFlowPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "trainerFormProgress";
            this.Size = new System.Drawing.Size(854, 536);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel progressFlowPanel;
    }
}
