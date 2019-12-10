namespace upcourse
{
    partial class register3
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
            this.label6 = new System.Windows.Forms.Label();
            this.register3_pass = new System.Windows.Forms.TextBox();
            this.register3_rePass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register3_terms = new System.Windows.Forms.CheckBox();
            this.register3_signup = new System.Windows.Forms.Button();
            this.register3_backBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(17, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password :";
            // 
            // register3_pass
            // 
            this.register3_pass.Location = new System.Drawing.Point(198, 13);
            this.register3_pass.Multiline = true;
            this.register3_pass.Name = "register3_pass";
            this.register3_pass.Size = new System.Drawing.Size(260, 39);
            this.register3_pass.TabIndex = 26;
            // 
            // register3_rePass
            // 
            this.register3_rePass.Location = new System.Drawing.Point(198, 77);
            this.register3_rePass.Multiline = true;
            this.register3_rePass.Name = "register3_rePass";
            this.register3_rePass.Size = new System.Drawing.Size(260, 39);
            this.register3_rePass.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Re-Password :";
            // 
            // register3_terms
            // 
            this.register3_terms.AutoSize = true;
            this.register3_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register3_terms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.register3_terms.Location = new System.Drawing.Point(22, 150);
            this.register3_terms.Name = "register3_terms";
            this.register3_terms.Size = new System.Drawing.Size(266, 29);
            this.register3_terms.TabIndex = 29;
            this.register3_terms.Text = "Agree to terms and privacy";
            this.register3_terms.UseVisualStyleBackColor = true;
            // 
            // register3_signup
            // 
            this.register3_signup.BackColor = System.Drawing.Color.RoyalBlue;
            this.register3_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register3_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register3_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register3_signup.ForeColor = System.Drawing.Color.White;
            this.register3_signup.Location = new System.Drawing.Point(145, 260);
            this.register3_signup.Name = "register3_signup";
            this.register3_signup.Size = new System.Drawing.Size(157, 49);
            this.register3_signup.TabIndex = 30;
            this.register3_signup.Text = "Sign up";
            this.register3_signup.UseVisualStyleBackColor = false;
            this.register3_signup.Click += new System.EventHandler(this.register3_signup_Click);
            // 
            // register3_backBtn
            // 
            this.register3_backBtn.AutoSize = true;
            this.register3_backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register3_backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register3_backBtn.Location = new System.Drawing.Point(3, 427);
            this.register3_backBtn.Name = "register3_backBtn";
            this.register3_backBtn.Size = new System.Drawing.Size(73, 24);
            this.register3_backBtn.TabIndex = 31;
            this.register3_backBtn.Text = "< Back";
            this.register3_backBtn.Click += new System.EventHandler(this.register3_backBtn_Click);
            // 
            // register3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.register3_backBtn);
            this.Controls.Add(this.register3_signup);
            this.Controls.Add(this.register3_terms);
            this.Controls.Add(this.register3_rePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register3_pass);
            this.Controls.Add(this.label6);
            this.Name = "register3";
            this.Size = new System.Drawing.Size(466, 462);
            this.Load += new System.EventHandler(this.register3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox register3_pass;
        private System.Windows.Forms.TextBox register3_rePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox register3_terms;
        private System.Windows.Forms.Button register3_signup;
        private System.Windows.Forms.Label register3_backBtn;
    }
}
