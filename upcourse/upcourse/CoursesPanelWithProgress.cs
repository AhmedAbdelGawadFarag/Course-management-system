using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upcourse
{
    public partial class CoursesPanelWithProgress : UserControl
    {
        public int courseId;
        public CoursesPanelWithProgress()
        {
            InitializeComponent();
        }
        public CoursesPanelWithProgress(int courseId, string CourseName, string CourseDetails,int progress,bool certificated)
        {
            InitializeComponent();
            this.SetCourseName(CourseName);
            this.SetCourseDetails(CourseDetails);
            this.courseId = courseId;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum = 0;
            setProgressPar(progress);
            CertificatedBox.Enabled = false;
            SetCertificated(certificated);
        }
        public void SetCourseName(string text)
        {
            this.CourseName.Text = text;
        }
        public void SetCourseDetails(string text)
        {
            this.CourseDescription.Text = text;
        }
        public void setCourseId(int id)
        {
            this.courseId = id;
        }
        public int getCourseId()
        {
            return this.courseId;
        }
        public void setProgressPar(int value)
        {
            this.progressBar1.Value = value;
            this.label1.Text = progressBar1.Value.ToString();
        }
        public void SetCertificated(bool Certificated)
        {
            this.CertificatedBox.Checked = Certificated;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
