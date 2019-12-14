namespace upcourse
{
    partial class mainscreen
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainscreen));
            this.mainScreen_forgetBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainScreen_checkBtn = new System.Windows.Forms.CheckBox();
            this.mainScreen_loginBtn = new System.Windows.Forms.Button();
            this.mainScreen_create = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainScreen_google = new System.Windows.Forms.PictureBox();
            this.mainScreen_twit = new System.Windows.Forms.PictureBox();
            this.mainScreen_fb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mainScreen_username = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.mainScreen_password = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen_google)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen_twit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen_fb)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScreen_forgetBtn
            // 
            this.mainScreen_forgetBtn.AutoSize = true;
            this.mainScreen_forgetBtn.BackColor = System.Drawing.Color.White;
            this.mainScreen_forgetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_forgetBtn, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_forgetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen_forgetBtn.ForeColor = System.Drawing.Color.DimGray;
            this.mainScreen_forgetBtn.Location = new System.Drawing.Point(261, 256);
            this.mainScreen_forgetBtn.Name = "mainScreen_forgetBtn";
            this.mainScreen_forgetBtn.Size = new System.Drawing.Size(161, 24);
            this.mainScreen_forgetBtn.TabIndex = 18;
            this.mainScreen_forgetBtn.Text = "Forget password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(13, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Or login with";
            // 
            // mainScreen_checkBtn
            // 
            this.mainScreen_checkBtn.AutoSize = true;
            this.mainScreen_checkBtn.BackColor = System.Drawing.Color.White;
            this.mainScreen_checkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_checkBtn, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen_checkBtn.ForeColor = System.Drawing.Color.DimGray;
            this.mainScreen_checkBtn.Location = new System.Drawing.Point(17, 254);
            this.mainScreen_checkBtn.Name = "mainScreen_checkBtn";
            this.mainScreen_checkBtn.Size = new System.Drawing.Size(159, 28);
            this.mainScreen_checkBtn.TabIndex = 16;
            this.mainScreen_checkBtn.Text = "Remember me";
            this.mainScreen_checkBtn.UseVisualStyleBackColor = false;
            // 
            // mainScreen_loginBtn
            // 
            this.mainScreen_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.mainScreen_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_loginBtn, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainScreen_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen_loginBtn.ForeColor = System.Drawing.Color.White;
            this.mainScreen_loginBtn.Location = new System.Drawing.Point(265, 293);
            this.mainScreen_loginBtn.Name = "mainScreen_loginBtn";
            this.mainScreen_loginBtn.Size = new System.Drawing.Size(157, 49);
            this.mainScreen_loginBtn.TabIndex = 15;
            this.mainScreen_loginBtn.Text = "Login";
            this.mainScreen_loginBtn.UseVisualStyleBackColor = false;
            this.mainScreen_loginBtn.Click += new System.EventHandler(this.mainScreen_loginBtn_Click);
            // 
            // mainScreen_create
            // 
            this.mainScreen_create.AutoSize = true;
            this.mainScreen_create.BackColor = System.Drawing.Color.White;
            this.mainScreen_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_create, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.mainScreen_create.Location = new System.Drawing.Point(208, 68);
            this.mainScreen_create.Name = "mainScreen_create";
            this.mainScreen_create.Size = new System.Drawing.Size(142, 18);
            this.mainScreen_create.TabIndex = 12;
            this.mainScreen_create.Text = "Create your account";
            this.mainScreen_create.Click += new System.EventHandler(this.mainScreen_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Don\'t have an account?";
            // 
            // mainScreen_google
            // 
            this.mainScreen_google.BackColor = System.Drawing.Color.White;
            this.mainScreen_google.BackgroundImage = global::upcourse.Properties.Resources.iconfinder_google_circle_294707;
            this.mainScreen_google.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainScreen_google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_google, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_google.Location = new System.Drawing.Point(324, 387);
            this.mainScreen_google.Name = "mainScreen_google";
            this.mainScreen_google.Size = new System.Drawing.Size(66, 66);
            this.mainScreen_google.TabIndex = 21;
            this.mainScreen_google.TabStop = false;
            // 
            // mainScreen_twit
            // 
            this.mainScreen_twit.BackColor = System.Drawing.Color.White;
            this.mainScreen_twit.BackgroundImage = global::upcourse.Properties.Resources.iconfinder_twitter_circle_294709;
            this.mainScreen_twit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainScreen_twit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_twit, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_twit.Location = new System.Drawing.Point(235, 387);
            this.mainScreen_twit.Name = "mainScreen_twit";
            this.mainScreen_twit.Size = new System.Drawing.Size(66, 66);
            this.mainScreen_twit.TabIndex = 20;
            this.mainScreen_twit.TabStop = false;
            // 
            // mainScreen_fb
            // 
            this.mainScreen_fb.BackColor = System.Drawing.Color.White;
            this.mainScreen_fb.BackgroundImage = global::upcourse.Properties.Resources.iconfinder_facebook_circle_294710;
            this.mainScreen_fb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainScreen_fb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.mainScreen_fb, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_fb.Location = new System.Drawing.Point(143, 387);
            this.mainScreen_fb.Name = "mainScreen_fb";
            this.mainScreen_fb.Size = new System.Drawing.Size(68, 66);
            this.mainScreen_fb.TabIndex = 19;
            this.mainScreen_fb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 44);
            this.label2.TabIndex = 22;
            this.label2.Text = "Login";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.mainScreen_loginBtn;
            // 
            // mainScreen_username
            // 
            this.bunifuTransition1.SetDecoration(this.mainScreen_username, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.mainScreen_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.mainScreen_username.Location = new System.Drawing.Point(18, 125);
            this.mainScreen_username.Multiline = true;
            this.mainScreen_username.Name = "mainScreen_username";
            this.mainScreen_username.Size = new System.Drawing.Size(405, 48);
            this.mainScreen_username.TabIndex = 23;
            this.mainScreen_username.WaterMark = "Username";
            this.mainScreen_username.WaterMarkActiveForeColor = System.Drawing.Color.Silver;
            this.mainScreen_username.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.mainScreen_username.WaterMarkForeColor = System.Drawing.Color.Silver;
            this.mainScreen_username.TextChanged += new System.EventHandler(this.mainScreen_username_TextChanged);
            // 
            // mainScreen_password
            // 
            this.bunifuTransition1.SetDecoration(this.mainScreen_password, BunifuAnimatorNS.DecorationType.None);
            this.mainScreen_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.mainScreen_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(51)))), ((int)(((byte)(206)))));
            this.mainScreen_password.Location = new System.Drawing.Point(16, 189);
            this.mainScreen_password.Name = "mainScreen_password";
            this.mainScreen_password.PasswordChar = '*';
            this.mainScreen_password.Size = new System.Drawing.Size(405, 38);
            this.mainScreen_password.TabIndex = 24;
            this.mainScreen_password.WaterMark = "Password";
            this.mainScreen_password.WaterMarkActiveForeColor = System.Drawing.Color.Silver;
            this.mainScreen_password.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.mainScreen_password.WaterMarkForeColor = System.Drawing.Color.Silver;
            this.mainScreen_password.TextChanged += new System.EventHandler(this.mainScreen_password_TextChanged);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainScreen_password);
            this.Controls.Add(this.mainScreen_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainScreen_google);
            this.Controls.Add(this.mainScreen_twit);
            this.Controls.Add(this.mainScreen_fb);
            this.Controls.Add(this.mainScreen_forgetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainScreen_checkBtn);
            this.Controls.Add(this.mainScreen_loginBtn);
            this.Controls.Add(this.mainScreen_create);
            this.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "mainscreen";
            this.Size = new System.Drawing.Size(466, 462);
            this.Load += new System.EventHandler(this.mainscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen_google)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen_twit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen_fb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainScreen_google;
        private System.Windows.Forms.PictureBox mainScreen_twit;
        private System.Windows.Forms.PictureBox mainScreen_fb;
        private System.Windows.Forms.Label mainScreen_forgetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox mainScreen_checkBtn;
        private System.Windows.Forms.Button mainScreen_loginBtn;
        private System.Windows.Forms.Label mainScreen_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ChreneLib.Controls.TextBoxes.CTextBox mainScreen_username;
        private ChreneLib.Controls.TextBoxes.CTextBox mainScreen_password;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}
