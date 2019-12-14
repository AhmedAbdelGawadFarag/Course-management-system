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
    public partial class TraineePanel : UserControl
    {
        public TraineePanel()
        {
            InitializeComponent();
        }
        
        public TraineePanel(string UserName, string FirstName, string LastName, int id, string Email, string Gender)
        {


            InitializeComponent();
            SetTraineeUserName(UserName);
            SetTraineeFirstName(FirstName);
            SetTraineeLastName(LastName);
            SetTraineeId(id);
            SetTraineeEmail(Email);
            SetTraineeGender(Gender);
        }


        public void SetTraineeUserName(string userName)
        {
            this.TraineeUserNameLabel.Text = userName;
        }
        public string GetTraineeUserName()
        {
            return this.TraineeUserNameLabel.Text;

        }

        public void SetTraineeFirstName(string FirstName)
        {
            this.TraineeFIrstNameLabel.Text = FirstName;
        }

        public string GetTraineeFirstName()
        {
            return this.TraineeFIrstNameLabel.Text;
        }

        public void SetTraineeLastName(string LastName)
        {
            this.TraineeLastNameLabel.Text = LastName;
        }
        public string GetTraineeLastName(string LastName)
        {
            return this.TraineeLastNameLabel.Text;
        }
        public void SetTraineeId(int id)
        {
            this.TraineeIdLabel.Text = id.ToString();

        }
        public int GetTraineeId()
        {
            int x;
            Int32.TryParse( this.TraineeIdLabel.Text,out x);
            return x;

        }
        public void SetTraineeEmail(string Email)
        {
            this.TraineeEmailLabel.Text = Email;
        }
        public string GetTraineeEmail()
        {
            return this.TraineeEmailLabel.Text;        }
        public void SetTraineeGender(string Gender)
        {
            this.TraineeGenderLabel.Text = Gender;
        }
        public string GetTraineeGender()
        {
            return this.TraineeGenderLabel.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlCommand DeleteTrainee = new SqlCommand("DeleteTrainee", Program.dbconnection);
            DeleteTrainee.CommandType = CommandType.StoredProcedure;
            DeleteTrainee.Parameters.AddWithValue("@ID", this.GetTraineeId());
            DeleteTrainee.ExecuteNonQuery();
            MessageBox.Show("Trainee deleted successfully\n");
            this.Hide();
        }
    }
}
