using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace upcourse
{
    public partial class adminAddCourse : Form
    {
        public adminAddCourse()
        {
            InitializeComponent();
        }

        private void adminAddCourse_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlCommand insertCourse = new SqlCommand("InsertCourse", Program.dbconnection);
            insertCourse.CommandType = CommandType.StoredProcedure;
            
           // @StartDate,@EndDate,@name,@Places,@Description;
            insertCourse.Parameters.AddWithValue("@StartDate",this.StartDateTimePicker.Value.Date);
            insertCourse.Parameters.AddWithValue("@EndDate", this.EndDateTimePicker.Value.Date);
            insertCourse.Parameters.AddWithValue("@name", this.CourseNameBox.Text);
            insertCourse.Parameters.AddWithValue("@Places", Int32.Parse(this.AvilablePlacesBox.Text));
            insertCourse.Parameters.AddWithValue("@Description", this.Description.Text);
            insertCourse.ExecuteNonQuery();
            


            this.Hide();

        }
    }
}
