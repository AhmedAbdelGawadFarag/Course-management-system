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
    public partial class trainerFormCourses : UserControl
    {
        public trainerFormCourses()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand("getCoursesFromTrainerID", Program.dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("TrainerID", mainscreen.GetUserID());
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                TrainerCoursePanel pnl = new TrainerCoursePanel((string)data["Name"], (string)data["Description"], (int)data["ID"]);
                this.CoursesFlowPanel.Controls.Add(pnl);
                
            }
            data.Close();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
