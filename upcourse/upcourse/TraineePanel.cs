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
        
        public TraineePanel(string UserName, string FirstName, string LastName, int id, string Email, string Gender,string password,string Qualification,string phone)
        {


            InitializeComponent();
            SetTraineeFirstName(FirstName);
            SetTraineeLastName(LastName);
            SetTraineeId(id);
            SetTraineeEmail(Email);
            SetTraineeGender(Gender);
            SetTraineePassword(password);
            SetTraineeQualification(Qualification);
            SetTraineePhone(phone);
            

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
        public string GetTraineeLastName()
        {
            return TraineeLastNameLabel.Text;
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
        public void SetTraineePassword(string password)
        {
            this.TraineePasswordLabel.Text = password;
        }
        public string GetTraineePassword()
        {
            return this.TraineePasswordLabel.Text;
        }
        public void SetTraineeQualification(String Qualification)
        {
            this.TraineeQualificationLabel.Text = Qualification;

        }
        public string GetTraineeQualification()
        {
          return  this.TraineeQualificationLabel.Text;
        }
        public void SetTraineePhone(string Phone)
        {
            this.TraineePhoneBox.Text = Phone;
        }
        public string GetTraineePhone()
        {
            return this.TraineePhoneBox.Text;
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updateTraineeInfo", Program.dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", GetTraineeId());
            cmd.Parameters.AddWithValue("@firstName", GetTraineeFirstName());
            cmd.Parameters.AddWithValue("@lastName", GetTraineeLastName());
            cmd.Parameters.AddWithValue("@nickName", "Nick");
            cmd.Parameters.AddWithValue("@email", GetTraineeEmail());
            cmd.Parameters.AddWithValue("@phone", this.GetTraineePhone());
            cmd.Parameters.AddWithValue("@pass", GetTraineePassword());
            cmd.Parameters.AddWithValue("@qulification", GetTraineeQualification());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Trainee Added Successfully");
        }
    }
}
