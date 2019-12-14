using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void SetTraineeFirstName(string FirstName)
        {
            this.TraineeFIrstNameLabel.Text = FirstName;
        }
        public void SetTraineeLastName(string LastName)
        {
            this.TraineeLastNameLabel.Text = LastName;
        }
        public void SetTraineeId(int id)
        {
            this.TraineeIdLabel.Text = id.ToString();

        }
        public void SetTraineeEmail(string Email)
        {
            this.TraineeEmailLabel.Text = Email;
        }
        public void SetTraineeGender(string Gender)
        {
            this.TraineeGenderLabel.Text = Gender;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
