namespace upcourse
{
    partial class trainerForm
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainerForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePnl = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCertificates = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.animationHoriz = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.trainerFormHome1 = new upcourse.trainerFormHome();
            this.trainerFormCourses1 = new upcourse.trainerFormCourses();
            this.trainerFormProgress1 = new upcourse.trainerFormProgress();
            this.trainerFormCertificates1 = new upcourse.trainerFormCertificates();
            this.trainerFormSearch1 = new upcourse.trainerFormSearch();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.sidePnl);
            this.Panel1.Controls.Add(this.btnSearch);
            this.Panel1.Controls.Add(this.btnCertificates);
            this.Panel1.Controls.Add(this.btnProgress);
            this.Panel1.Controls.Add(this.btnCourse);
            this.Panel1.Controls.Add(this.btnHome);
            this.animationHoriz.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(267, 757);
            this.Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animationHoriz.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(61, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copyright@2019";
            // 
            // pictureBox1
            // 
            this.animationHoriz.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::upcourse.Properties.Resources.large_upcourse;
            this.pictureBox1.Location = new System.Drawing.Point(35, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.animationHoriz.SetDecoration(this.sidePnl, BunifuAnimatorNS.DecorationType.None);
            this.sidePnl.Location = new System.Drawing.Point(1, 241);
            this.sidePnl.Margin = new System.Windows.Forms.Padding(4);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(7, 44);
            this.sidePnl.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.animationHoriz.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(10, 396);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(257, 44);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "  Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCertificates
            // 
            this.animationHoriz.SetDecoration(this.btnCertificates, BunifuAnimatorNS.DecorationType.None);
            this.btnCertificates.FlatAppearance.BorderSize = 0;
            this.btnCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertificates.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertificates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCertificates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCertificates.Location = new System.Drawing.Point(10, 344);
            this.btnCertificates.Margin = new System.Windows.Forms.Padding(4);
            this.btnCertificates.Name = "btnCertificates";
            this.btnCertificates.Size = new System.Drawing.Size(257, 44);
            this.btnCertificates.TabIndex = 4;
            this.btnCertificates.Text = "  Certificates";
            this.btnCertificates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCertificates.UseVisualStyleBackColor = true;
            this.btnCertificates.Click += new System.EventHandler(this.btnCertificates_Click);
            // 
            // btnProgress
            // 
            this.animationHoriz.SetDecoration(this.btnProgress, BunifuAnimatorNS.DecorationType.None);
            this.btnProgress.FlatAppearance.BorderSize = 0;
            this.btnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgress.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.Location = new System.Drawing.Point(10, 292);
            this.btnProgress.Margin = new System.Windows.Forms.Padding(4);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(257, 44);
            this.btnProgress.TabIndex = 3;
            this.btnProgress.Text = "  Progress";
            this.btnProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnCourse
            // 
            this.animationHoriz.SetDecoration(this.btnCourse, BunifuAnimatorNS.DecorationType.None);
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.Location = new System.Drawing.Point(10, 241);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(257, 44);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "  Course";
            this.btnCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnHome
            // 
            this.animationHoriz.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 189);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(257, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "  Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.label2);
            this.animationHoriz.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(267, 712);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 45);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animationHoriz.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(393, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copyright@2019";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel2.Controls.Add(this.button11);
            this.Panel2.Controls.Add(this.button13);
            this.animationHoriz.SetDecoration(this.Panel2, BunifuAnimatorNS.DecorationType.None);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(267, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1013, 50);
            this.Panel2.TabIndex = 5;
            // 
            // button11
            // 
            this.animationHoriz.SetDecoration(this.button11, BunifuAnimatorNS.DecorationType.None);
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(924, 5);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(23, 37);
            this.button11.TabIndex = 35;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.animationHoriz.SetDecoration(this.button13, BunifuAnimatorNS.DecorationType.None);
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(966, 3);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 43);
            this.button13.TabIndex = 34;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // animationHoriz
            // 
            this.animationHoriz.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationHoriz.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animationHoriz.DefaultAnimation = animation2;
            this.animationHoriz.TimeStep = 0.015F;
            // 
            // trainerFormHome1
            // 
            this.animationHoriz.SetDecoration(this.trainerFormHome1, BunifuAnimatorNS.DecorationType.None);
            this.trainerFormHome1.Location = new System.Drawing.Point(267, 49);
            this.trainerFormHome1.Name = "trainerFormHome1";
            this.trainerFormHome1.Size = new System.Drawing.Size(1013, 660);
            this.trainerFormHome1.TabIndex = 6;
            // 
            // trainerFormCourses1
            // 
            this.animationHoriz.SetDecoration(this.trainerFormCourses1, BunifuAnimatorNS.DecorationType.None);
            this.trainerFormCourses1.Location = new System.Drawing.Point(267, 49);
            this.trainerFormCourses1.Name = "trainerFormCourses1";
            this.trainerFormCourses1.Size = new System.Drawing.Size(1013, 660);
            this.trainerFormCourses1.TabIndex = 7;
            // 
            // trainerFormProgress1
            // 
            this.animationHoriz.SetDecoration(this.trainerFormProgress1, BunifuAnimatorNS.DecorationType.None);
            this.trainerFormProgress1.Location = new System.Drawing.Point(267, 49);
            this.trainerFormProgress1.Name = "trainerFormProgress1";
            this.trainerFormProgress1.Size = new System.Drawing.Size(1013, 660);
            this.trainerFormProgress1.TabIndex = 8;
            // 
            // trainerFormCertificates1
            // 
            this.animationHoriz.SetDecoration(this.trainerFormCertificates1, BunifuAnimatorNS.DecorationType.None);
            this.trainerFormCertificates1.Location = new System.Drawing.Point(267, 49);
            this.trainerFormCertificates1.Name = "trainerFormCertificates1";
            this.trainerFormCertificates1.Size = new System.Drawing.Size(1013, 660);
            this.trainerFormCertificates1.TabIndex = 9;
            // 
            // trainerFormSearch1
            // 
            this.animationHoriz.SetDecoration(this.trainerFormSearch1, BunifuAnimatorNS.DecorationType.None);
            this.trainerFormSearch1.Location = new System.Drawing.Point(267, 53);
            this.trainerFormSearch1.Name = "trainerFormSearch1";
            this.trainerFormSearch1.Size = new System.Drawing.Size(1013, 660);
            this.trainerFormSearch1.TabIndex = 10;
            // 
            // trainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 757);
            this.Controls.Add(this.trainerFormSearch1);
            this.Controls.Add(this.trainerFormCertificates1);
            this.Controls.Add(this.trainerFormProgress1);
            this.Controls.Add(this.trainerFormCourses1);
            this.Controls.Add(this.trainerFormHome1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.animationHoriz.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trainerForm";
            this.Load += new System.EventHandler(this.trainerForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel sidePnl;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnCertificates;
        internal System.Windows.Forms.Button btnProgress;
        internal System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        internal System.Windows.Forms.Button btnHome;
        private BunifuAnimatorNS.BunifuTransition animationHoriz;
        private trainerFormHome trainerFormHome1;
        private trainerFormCourses trainerFormCourses1;
        private trainerFormProgress trainerFormProgress1;
        private trainerFormCertificates trainerFormCertificates1;
        private trainerFormSearch trainerFormSearch1;
    }
}