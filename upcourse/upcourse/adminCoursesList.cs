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
    public partial class adminCoursesList : UserControl
    {
        public adminCoursesList()
        {
            InitializeComponent();
            SqlCommand Courses = new SqlCommand("select * from course", Program.dbconnection);
            SqlDataReader data = Courses.ExecuteReader();
            int cnt = 0;
            while (data.Read())
            {
                AdminCoursePanel pnl = new AdminCoursePanel(data.GetInt32(0), data.GetString(3), data.GetString(5));
                flowLayoutPanel1.Controls.Add(pnl);
                cnt++;
               
            }
            data.Close();

        }
    }
}
