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
    public partial class userFormMyCourses : UserControl
    {
        public userFormMyCourses()
        {
            InitializeComponent();
            SqlCommand GetMyCourses = new SqlCommand("GetCourses", Program.dbconnection);
            GetMyCourses.CommandType = CommandType.StoredProcedure;
            GetMyCourses.Parameters.AddWithValue("@id",mainscreen.GetUserID());
           
            SqlDataReader data=GetMyCourses.ExecuteReader();
            while (data.Read())
            {
                CoursesPanelWithProgress s = new CoursesPanelWithProgress(data.GetInt32(data.GetOrdinal("CourseID")),data.GetString(data.GetOrdinal("Name"))
                    ,data.GetString(data.GetOrdinal("Description")),data.GetInt32(data.GetOrdinal("progress")),data.GetBoolean(data.GetOrdinal("certificated")));
                this.MyCoursesFlowPanel.Controls.Add(s);
            }
            data.Close();
            
            //this.MyCoursesFlowPanel.Controls.Add(new CheckBox());
        }
    }
}
