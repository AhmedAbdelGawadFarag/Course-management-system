namespace upcourse
{
    partial class trainerFormSearch
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(283, 58);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(171, 49);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search!";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(425, 21);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(140, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(149, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Search!";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(3, 113);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(754, 420);
            this.SearchPanel.TabIndex = 3;
            // 
            // trainerFormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "trainerFormSearch";
            this.Size = new System.Drawing.Size(772, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel SearchPanel;
    }
}
