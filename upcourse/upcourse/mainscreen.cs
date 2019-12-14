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
    public partial class mainscreen : UserControl
    {
         static int UserId;
        public mainscreen()
        {
            InitializeComponent();


        }

        private void mainScreen_create_Click(object sender, EventArgs e)
        {
            register register = new register();
            this.Controls.Add(register);
            register.Dock = DockStyle.Fill;
             register.BringToFront();
        }


        private void mainScreen_loginBtn_Click(object sender, EventArgs e)
        {
            String txtUsername = mainScreen_username.Text;
            String txtPassword = mainScreen_password.Text;

            //try
            //{

            // modify it to your server and db name
            if (txtUsername=="admin"&&txtPassword=="admin") {
                adminForm AdminPage = new adminForm();
                AdminPage.ShowDialog();
            }
            else {

                string checkCredentials = "Select * from Trainee Where UserName = '" + mainScreen_username.Text + "' and Pass = '" + mainScreen_password.Text.Trim() + "'";
                SqlCommand CheckTrainee = new SqlCommand(checkCredentials, Program.dbconnection);
                SqlDataReader TraineeData = CheckTrainee.ExecuteReader();


                if (TraineeData.HasRows)
                {
                    MessageBox.Show("Successsful Trainee Login !");
                    TraineeData.Read();
                    UserId = TraineeData.GetInt32(0);
                    TraineeData.Close();
                    Console.WriteLine(UserId.ToString());
                    userForm objuserForm = new userForm();
                    this.Hide();
                    objuserForm.Show();

                }
                else
                {
                    TraineeData.Close();
                    string checkCredentialsTrainer = "Select * from Trainer Where UserName = '" + mainScreen_username.Text + "' and Password = '" + mainScreen_password.Text.Trim() + "'";
                    SqlCommand CheckTrainer = new SqlCommand(checkCredentialsTrainer, Program.dbconnection);
                    SqlDataReader TrainerData = CheckTrainer.ExecuteReader();
                    if (TrainerData.HasRows)
                    {
                        TrainerData.Read();
                        UserId = TrainerData.GetInt32(0);
                        TrainerData.Close();
                        trainerForm objuserForm = new trainerForm();
                        this.Hide();
                        objuserForm.Show();
                    }
                    else
                    {
                        TrainerData.Close();
                        MessageBox.Show("Check your username and password \n");
                    }


                  

                }
            }

        //}
           // catch (Exception Ex)
            //{
              //  MessageBox.Show(Ex.Message);
            //}
}

        private void mainScreen_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainScreen_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainscreen_Load(object sender, EventArgs e)
        {

        }
        public static int GetUserID()
        {
            return UserId;
        }
    }
}
