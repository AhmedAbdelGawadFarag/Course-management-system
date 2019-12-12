using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace upcourse
{
    public partial class CoursePanel : UserControl
    {
        public int courseId;
        public CoursePanel()
        {
            InitializeComponent();
        }
        public CoursePanel(int courseId, string CourseName,string CourseDetails)
        {
            InitializeComponent();
            this.SetCourseName(CourseName);
            this.SetCourseDetails(CourseDetails);
            this.courseId = courseId;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void SetCourseName(string text)
        {
            this.CourseName.Text=text;
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlCommand Register = new SqlCommand("insert into Traineecourse values(@UserId,null,null,@CourseId,null,null)",Program.dbconnection);
            Register.Parameters.AddWithValue("UserId",mainscreen.GetUserID());
            Register.Parameters.AddWithValue("CourseId", this.getCourseId());
            Register.ExecuteNonQuery();
            
            MessageBox.Show(this.courseId.ToString());

        }
    }
}
