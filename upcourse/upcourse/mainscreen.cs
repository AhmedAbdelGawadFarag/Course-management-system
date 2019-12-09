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

            try
            {

                // modify it to your server and db name
                string databaseString = "Server=localhost;Database=Up Course;Trusted_Connection=True;";
                SqlConnection dbconnection = new SqlConnection(databaseString);
                dbconnection.Open();
            
                string checkCredentials = "Select * from Trainee Where UserName = '" + mainScreen_username.Text + "' and Password = '" + mainScreen_password.Text.Trim() + "'";
                SqlDataAdapter asd = new SqlDataAdapter(checkCredentials, dbconnection);

                DataTable dtbl = new DataTable();
                asd.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successsful !");
                }
                else {throw new Exception("Something Went Wrong!");}

                dbconnection.Close();
            }
            catch (Exception Ex){
                MessageBox.Show("Check your username and password \n", Ex.Message);
            }
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
    }
}
