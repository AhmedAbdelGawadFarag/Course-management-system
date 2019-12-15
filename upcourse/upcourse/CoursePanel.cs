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
        public CoursePanel(int courseId, string CourseName,string CourseDetails,DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.SetCourseName(CourseName);
            this.SetCourseDetails(CourseDetails);
            this.courseId = courseId;
            SetStartDate(startDate);
            SetEndDate(endDate);
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
        public void SetStartDate(DateTime Date)
        {
            this.StartDateLabel.Text = Date.ToString();
        }
        public void SetEndDate(DateTime Date)
        {
            this.EndDateLabel.Text = Date.ToString();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlCommand Register = new SqlCommand("insert into Traineecourse values(@UserId,0,@CourseId,0,null)",Program.dbconnection);
            Register.Parameters.AddWithValue("@UserId",mainscreen.GetUserID());
            Register.Parameters.AddWithValue("@CourseId", this.getCourseId());
            Console.WriteLine(mainscreen.GetUserID().ToString());
            Console.WriteLine(this.getCourseId());

            Register.ExecuteNonQuery();
            
            MessageBox.Show(this.courseId.ToString());

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
