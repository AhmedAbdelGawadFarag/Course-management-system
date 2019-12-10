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
        static string databaseString = "Data Source=DESKTOP-9UTNJPD\\SQLEXPRESS;Initial Catalog='Course Mangment System';Integrated Security=True";

        static SqlConnection dbconnection = new SqlConnection(databaseString);
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

                dbconnection.Open();

                string checkCredentials = "Select * from Trainee Where UserName = '" + mainScreen_username.Text + "' and Password = '" + mainScreen_password.Text.Trim() + "'";
                SqlDataAdapter asd = new SqlDataAdapter(checkCredentials, dbconnection);
                DataTable dtbl = new DataTable();
                asd.Fill(dtbl);


                string checkCredentialsTrainer = "Select * from Trainer Where UserName = '" + mainScreen_username.Text + "' and Password = '" + mainScreen_password.Text.Trim() + "'";
                SqlDataAdapter dsa = new SqlDataAdapter(checkCredentialsTrainer, dbconnection);
                DataTable dtbl2 = new DataTable();
                dsa.Fill(dtbl2);


                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successsful !");
                    userForm objuserForm = new userForm();
                    this.Hide();
                    objuserForm.Show();

                }
                else if (dtbl2.Rows.Count == 1)
                {

                    MessageBox.Show("Successsful Trainer Login !");
                    //we efta7 form el trainer
                }
                else { throw new Exception("Something Went Wrong!"); }

                dbconnection.Close();
            }
            catch (Exception Ex)
            {
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
