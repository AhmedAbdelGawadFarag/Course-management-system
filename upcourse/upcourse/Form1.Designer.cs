namespace upcourse
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainForm_exitBtn = new System.Windows.Forms.PictureBox();
            this.mainForm_miniBtn = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.register31 = new upcourse.register3();
            this.register21 = new upcourse.register2();
            this.register1 = new upcourse.register();
            this.mainscreen2 = new upcourse.mainscreen();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainForm_exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainForm_miniBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // mainForm_exitBtn
            // 
            this.mainForm_exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.mainForm_exitBtn.BackgroundImage = global::upcourse.Properties.Resources.icons8_x_lowercase_26;
            this.mainForm_exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainForm_exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainForm_exitBtn.Location = new System.Drawing.Point(967, 12);
            this.mainForm_exitBtn.Name = "mainForm_exitBtn";
            this.mainForm_exitBtn.Size = new System.Drawing.Size(28, 24);
            this.mainForm_exitBtn.TabIndex = 11;
            this.mainForm_exitBtn.TabStop = false;
            this.mainForm_exitBtn.Click += new System.EventHandler(this.mainForm_exitBtn_Click);
            // 
            // mainForm_miniBtn
            // 
            this.mainForm_miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.mainForm_miniBtn.BackgroundImage = global::upcourse.Properties.Resources.icons8_horizontal_line_50;
            this.mainForm_miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainForm_miniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainForm_miniBtn.Location = new System.Drawing.Point(924, 12);
            this.mainForm_miniBtn.Name = "mainForm_miniBtn";
            this.mainForm_miniBtn.Size = new System.Drawing.Size(28, 24);
            this.mainForm_miniBtn.TabIndex = 12;
            this.mainForm_miniBtn.TabStop = false;
            this.mainForm_miniBtn.Click += new System.EventHandler(this.mainForm_miniBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // register31
            // 
            this.register31.BackColor = System.Drawing.Color.White;
            this.register31.Location = new System.Drawing.Point(0, 112);
            this.register31.Name = "register31";
            this.register31.Size = new System.Drawing.Size(466, 462);
            this.register31.TabIndex = 16;
            // 
            // register21
            // 
            this.register21.BackColor = System.Drawing.Color.White;
            this.register21.Location = new System.Drawing.Point(0, 112);
            this.register21.Name = "register21";
            this.register21.Size = new System.Drawing.Size(466, 462);
            this.register21.TabIndex = 15;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.White;
            this.register1.Location = new System.Drawing.Point(0, 112);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(466, 462);
            this.register1.TabIndex = 14;
            this.register1.Load += new System.EventHandler(this.register1_Load);
            // 
            // mainscreen2
            // 
            this.mainscreen2.BackColor = System.Drawing.Color.White;
            this.mainscreen2.ForeColor = System.Drawing.Color.Gray;
            this.mainscreen2.Location = new System.Drawing.Point(0, 112);
            this.mainscreen2.Name = "mainscreen2";
            this.mainscreen2.Size = new System.Drawing.Size(466, 462);
            this.mainscreen2.TabIndex = 13;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "TEST (dont delete it)";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(642, 384);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton1.TabIndex = 17;
            this.bunifuFlatButton1.Text = "TEST (dont delete it)";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::upcourse.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 574);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.register31);
            this.Controls.Add(this.register21);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.mainscreen2);
            this.Controls.Add(this.mainForm_miniBtn);
            this.Controls.Add(this.mainForm_exitBtn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainForm_exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainForm_miniBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox mainForm_exitBtn;
        private System.Windows.Forms.PictureBox mainForm_miniBtn;
        private mainscreen mainscreen2;
        private register register1;
        private register2 register21;
        private register3 register31;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

