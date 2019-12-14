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
    public partial class TrainerProgressPanel : UserControl
    {
        public int userId;
        public int courseId;
        public TrainerProgressPanel(int id,int courseId,string traineeName, int progress, bool certificated)
        {
            InitializeComponent();
            this.TraineeName.Text = traineeName;
            this.progress.Value = progress;
            this.userId = id;
            this.courseId = courseId;
            if (certificated)
                this.radioYes.Checked = true;
            else
                this.radioNo.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updateTraineeCourse", Program.dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("traineeID", this.userId);
            cmd.Parameters.AddWithValue("courseID", this.courseId);
            cmd.Parameters.AddWithValue("progress",this.progress.Value);
            if (this.radioYes.Checked)
                cmd.Parameters.AddWithValue("certificated", 1);
            else
                cmd.Parameters.AddWithValue("certificated", 0);
            cmd.ExecuteNonQuery();
        }
    }
}
