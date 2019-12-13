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
    public partial class user_acc : UserControl
    {
        public user_acc()
        {
            InitializeComponent();
            
        }

        public void getUserData(int id)
        {
            SqlCommand cmd = new SqlCommand("getTraineeInfo", Program.dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader data = cmd.ExecuteReader();
            
            data.Read();

            this.fName.Text = (string)data["firstName"];
            this.lName.Text = (string)data["LastName"];
            this.nName.Text = (string)data["NickName"];
            this.email.Text = (string)data["Email"];
            this.phone.Text = (string)data["phone"];
            this.qualification.Text = (string)data["Qualification"];

            data.Close();

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (this.fName.Text == string.Empty || this.lName.Text == string.Empty ||
                this.nName.Text == string.Empty || this.email.Text == string.Empty ||
                this.phone.Text == string.Empty || this.phone.Text == string.Empty ||
                this.pass.Text == string.Empty)
                MessageBox.Show("Info can not be empty");
            else
            {
                if (this.pass.Text == this.rePass.Text)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("updateTraineeInfo", Program.dbconnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", mainscreen.GetUserID());
                        cmd.Parameters.AddWithValue("@firstName", this.fName.Text);
                        cmd.Parameters.AddWithValue("@lastName", this.lName.Text);
                        cmd.Parameters.AddWithValue("@nickName", this.nName.Text);
                        cmd.Parameters.AddWithValue("@email", this.email.Text);
                        cmd.Parameters.AddWithValue("@phone", this.phone.Text);
                        cmd.Parameters.AddWithValue("@pass", this.pass.Text);
                        cmd.Parameters.AddWithValue("@qulification", this.qualification.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Modified Successfully");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                    MessageBox.Show("Password doesn't match");

            }
        }
    }
}
