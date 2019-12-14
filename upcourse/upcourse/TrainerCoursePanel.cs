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
    public partial class TrainerCoursePanel : UserControl
    {
        public int courseId;
        public TrainerCoursePanel(string CourseName, string CourseDescription, int courseID)
        {
            InitializeComponent();
            this.courseId = courseID;
            this.CourseName.Text = CourseName;
            this.CourseDescription.Text = CourseDescription;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("getTraineeFromCourseID", Program.dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CourseID", this.courseId);
            SqlDataReader data = cmd.ExecuteReader();
            ViewProgress view = new ViewProgress();
            trainerFormProgress form = new trainerFormProgress();
            view.Controls.Add(form);
            while (data.Read())
            {
                form.newProgressPanel(data.GetInt32(data.GetOrdinal("ID")), 
                    this.courseId,
                    data.GetString(data.GetOrdinal("firstName")) + data.GetString(data.GetOrdinal("LastName")),
                     data.GetInt32(data.GetOrdinal("progress")),data.GetBoolean(data.GetOrdinal("certificated")));
            }
            view.Show();
            view.BringToFront();
            data.Close();
        }
    }
}
