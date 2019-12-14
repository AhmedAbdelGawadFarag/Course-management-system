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
    public partial class AdminCoursePanel : UserControl
    {
         int courseId;

        public AdminCoursePanel()
        {
            InitializeComponent();

        }
        public AdminCoursePanel(int courseId, string CourseName, string CourseDetails)
        {
           
            InitializeComponent();
            this.SetCourseName(CourseName);
            this.SetCourseDetails(CourseDetails);
            this.courseId = courseId;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlCommand DeleteCourse = new SqlCommand("DeleteCourse", Program.dbconnection);
            DeleteCourse.CommandType = CommandType.StoredProcedure;
            DeleteCourse.Parameters.AddWithValue("@ID",getCourseId());
            DeleteCourse.ExecuteNonQuery();
            MessageBox.Show("Course deleted successfully\n");
            this.Hide();
            


        }
    }

}

