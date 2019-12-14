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
    public partial class adminCourseAssign : UserControl
    {
        public int courseID;
        public adminCourseAssign()
        {
            InitializeComponent();
            updateCombo();
        }

        public void setCourseId(int id)
        {
            this.courseID = id;
        }
        public void updateCombo()
        {
            this.trainerCombo.Items.Clear();
            SqlCommand cmd = new SqlCommand("select ID,firstName,LastName from trainer", Program.dbconnection);
            SqlDataReader data = cmd.ExecuteReader();
            while(data.Read())
            {
                this.trainerCombo.Items.Add(data.GetString(data.GetOrdinal("firstName")) + " " + data.GetString(data.GetOrdinal("LastName")) + " -" + data.GetInt32(data.GetOrdinal("ID")) );
            }
            data.Close();

        }
        private void assignButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into CourseTrainer values(@TrainerID,@CourseID)",Program.dbconnection);
            cmd.Parameters.AddWithValue("CourseID", this.courseID);
            string cid = this.trainerCombo.SelectedItem.ToString().Substring (this.trainerCombo.SelectedItem.ToString().IndexOf('-') + 1);
            cmd.Parameters.AddWithValue("TrainerID", cid);

            cmd.ExecuteNonQuery();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
