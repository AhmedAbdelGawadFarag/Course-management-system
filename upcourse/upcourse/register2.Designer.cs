﻿namespace upcourse
{
    partial class register2
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
            this.register2_backBtn = new System.Windows.Forms.Label();
            this.register2_loginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.register2_male = new System.Windows.Forms.RadioButton();
            this.register2_female = new System.Windows.Forms.RadioButton();
            this.register2_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register2_qual = new System.Windows.Forms.TextBox();
            this.register_RB_trainee = new System.Windows.Forms.RadioButton();
            this.register_RB_trainer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // register2_backBtn
            // 
            this.register2_backBtn.AutoSize = true;
            this.register2_backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register2_backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register2_backBtn.Location = new System.Drawing.Point(10, 425);
            this.register2_backBtn.Name = "register2_backBtn";
            this.register2_backBtn.Size = new System.Drawing.Size(73, 24);
            this.register2_backBtn.TabIndex = 27;
            this.register2_backBtn.Text = "< Back";
            this.register2_backBtn.Click += new System.EventHandler(this.register2_backBtn_Click);
            // 
            // register2_loginBtn
            // 
            this.register2_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.register2_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register2_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register2_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register2_loginBtn.ForeColor = System.Drawing.Color.White;
            this.register2_loginBtn.Location = new System.Drawing.Point(138, 400);
            this.register2_loginBtn.Name = "register2_loginBtn";
            this.register2_loginBtn.Size = new System.Drawing.Size(157, 49);
            this.register2_loginBtn.TabIndex = 26;
            this.register2_loginBtn.Text = "Next";
            this.register2_loginBtn.UseVisualStyleBackColor = false;
            this.register2_loginBtn.Click += new System.EventHandler(this.register2_loginBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date of birth :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // register2_male
            // 
            this.register2_male.AutoSize = true;
            this.register2_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register2_male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.register2_male.Location = new System.Drawing.Point(24, 65);
            this.register2_male.Name = "register2_male";
            this.register2_male.Size = new System.Drawing.Size(76, 28);
            this.register2_male.TabIndex = 28;
            this.register2_male.TabStop = true;
            this.register2_male.Text = "Male";
            this.register2_male.UseVisualStyleBackColor = true;
            // 
            // register2_female
            // 
            this.register2_female.AutoSize = true;
            this.register2_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register2_female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.register2_female.Location = new System.Drawing.Point(159, 65);
            this.register2_female.Name = "register2_female";
            this.register2_female.Size = new System.Drawing.Size(101, 28);
            this.register2_female.TabIndex = 29;
            this.register2_female.TabStop = true;
            this.register2_female.Text = "Female";
            this.register2_female.UseVisualStyleBackColor = true;
            this.register2_female.CheckedChanged += new System.EventHandler(this.register2_female_CheckedChanged);
            // 
            // register2_date
            // 
            this.register2_date.Location = new System.Drawing.Point(200, 19);
            this.register2_date.Name = "register2_date";
            this.register2_date.Size = new System.Drawing.Size(232, 22);
            this.register2_date.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(19, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Current position :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(19, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Qualification :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // register2_qual
            // 
            this.register2_qual.Location = new System.Drawing.Point(14, 173);
            this.register2_qual.Multiline = true;
            this.register2_qual.Name = "register2_qual";
            this.register2_qual.Size = new System.Drawing.Size(374, 81);
            this.register2_qual.TabIndex = 33;
            // 
            // register_RB_trainee
            // 
            this.register_RB_trainee.AutoSize = true;
            this.register_RB_trainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_RB_trainee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.register_RB_trainee.Location = new System.Drawing.Point(170, 329);
            this.register_RB_trainee.Name = "register_RB_trainee";
            this.register_RB_trainee.Size = new System.Drawing.Size(103, 28);
            this.register_RB_trainee.TabIndex = 35;
            this.register_RB_trainee.TabStop = true;
            this.register_RB_trainee.Text = "Trainee";
            this.register_RB_trainee.UseVisualStyleBackColor = true;
            // 
            // register_RB_trainer
            // 
            this.register_RB_trainer.AutoSize = true;
            this.register_RB_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_RB_trainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.register_RB_trainer.Location = new System.Drawing.Point(24, 329);
            this.register_RB_trainer.Name = "register_RB_trainer";
            this.register_RB_trainer.Size = new System.Drawing.Size(98, 28);
            this.register_RB_trainer.TabIndex = 34;
            this.register_RB_trainer.TabStop = true;
            this.register_RB_trainer.Text = "Trainer";
            this.register_RB_trainer.UseVisualStyleBackColor = true;
            this.register_RB_trainer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // register2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.register_RB_trainee);
            this.Controls.Add(this.register_RB_trainer);
            this.Controls.Add(this.register2_qual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register2_date);
            this.Controls.Add(this.register2_female);
            this.Controls.Add(this.register2_male);
            this.Controls.Add(this.register2_backBtn);
            this.Controls.Add(this.register2_loginBtn);
            this.Controls.Add(this.label6);
            this.Name = "register2";
            this.Size = new System.Drawing.Size(466, 462);
            this.Load += new System.EventHandler(this.register2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label register2_backBtn;
        private System.Windows.Forms.Button register2_loginBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton register2_male;
        private System.Windows.Forms.RadioButton register2_female;
        private System.Windows.Forms.DateTimePicker register2_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox register2_qual;
        private System.Windows.Forms.RadioButton register_RB_trainee;
        private System.Windows.Forms.RadioButton register_RB_trainer;
    }
}
