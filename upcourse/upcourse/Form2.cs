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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int CourseId)
        {
            InitializeComponent();
            SqlDataAdapter sqlda = new SqlDataAdapter("GetTraineeCourse", Program.dbconnection);
            
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@ID", CourseId);
            sqlda.SelectCommand.ExecuteNonQuery();
            

            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            CourseGrid.DataSource = dt;
            
            
        }
    }
}
