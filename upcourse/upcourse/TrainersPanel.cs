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
    public partial class TrainersPanel : UserControl
    {
        public TrainersPanel()
        {
            InitializeComponent();
            
        }
        public TrainersPanel(string UserName, string FirstName, string LastName, int id, string Email, string Gender)
        {


            InitializeComponent();
            SetTrainerUserName(UserName);
            SetTrainerFirstName(FirstName);
            SetTrainerLastName(LastName);
            SetTrainerId(id);
            SetTrainerEmail(Email);
            SetTrainerGender(Gender);
        }

        public void SetTrainerUserName(string userName)
        {
            this.TrainerUserNameLabel.Text = userName;
        }
        public string GetTrainerUserName()
        {
            return this.TrainerUserNameLabel.Text;

        }

        public void SetTrainerFirstName(string FirstName)
        {
            this.TrainerFIrstNameLabel.Text = FirstName;
        }

        public string GetTrainerFirstName()
        {
            return this.TrainerFIrstNameLabel.Text;
        }

        public void SetTrainerLastName(string LastName)
        {
            this.TrainerLastNameLabel.Text = LastName;
        }
        public string GetTrainerLastName(string LastName)
        {
            return this.TrainerLastNameLabel.Text;
        }
        public void SetTrainerId(int id)
        {
            this.TrainerIdLabel.Text = id.ToString();

        }
        public int GetTrainerId()
        {
            int x;
            Int32.TryParse(this.TrainerIdLabel.Text, out x);
            return x;

        }
        public void SetTrainerEmail(string Email)
        {
            this.TrainerEmailLabel.Text = Email;
        }
        public string GetTrainerEmail()
        {
            return this.TrainerEmailLabel.Text;
        }
        public void SetTrainerGender(string Gender)
        {
            this.TrainerGenderLabel.Text = Gender;
        }
        public string GetTrainerGender()
        {
            return this.TrainerGenderLabel.Text;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlCommand DeleteTrainee = new SqlCommand("DeleteTrainer", Program.dbconnection);
            DeleteTrainee.CommandType = CommandType.StoredProcedure;
            DeleteTrainee.Parameters.AddWithValue("@ID", this.GetTrainerId());
            DeleteTrainee.ExecuteNonQuery();
            MessageBox.Show("Trainee deleted successfully\n");
            this.Hide();
        }
    }
}
