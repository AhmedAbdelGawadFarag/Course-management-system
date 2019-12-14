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
    
    public partial class register3 : UserControl
    {
        public register3()
        {
            InitializeComponent();

        }

      

        private void register3_signup_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(register3_pass.Text) == false&& string.IsNullOrEmpty(register3_rePass.Text) == false&&register3_terms.Checked)
            {

                if (register3_pass.Text==register3_rePass.Text) {

                    if (register2.GetCurrentPos() == "Trainer")
                    {
                        SqlCommand checkemail = new SqlCommand("select * from trainer where Email=@mail or UserName=@Usrnam", Program.dbconnection);
                        checkemail.Parameters.AddWithValue("@mail", register.getEmail());
                        checkemail.Parameters.AddWithValue("@Usrnam",register.getUserName());
                        SqlDataReader EmailData = checkemail.ExecuteReader();


                        if (EmailData.HasRows == false) {
                            EmailData.Close();
                            SqlCommand NewRegister = new SqlCommand("insert into Trainer values(@Username, @Password, @Email, @Gender, @Age, @Phone, @firstName, @LastName,@ID)", Program.dbconnection);
                            NewRegister.Parameters.AddWithValue("Username", register.getUserName());
                            NewRegister.Parameters.AddWithValue("Password", register3_pass.Text);
                            NewRegister.Parameters.AddWithValue("Email", register.getEmail());
                            NewRegister.Parameters.AddWithValue("Gender", register2.GetGender());
                            NewRegister.Parameters.AddWithValue("Age", "12");
                            NewRegister.Parameters.AddWithValue("Phone", register.getNumber());
                            NewRegister.Parameters.AddWithValue("FirstName", register.getFirstName());
                            NewRegister.Parameters.AddWithValue("LastName", register.getLastName());
                            NewRegister.Parameters.AddWithValue("ID", register.getId());
                            NewRegister.ExecuteNonQuery();
                            MessageBox.Show("succesful register");
                        }
                        else
                        {
                            EmailData.Close();
                            MessageBox.Show("Email or user Name exist");

                        }


                    }
                    else
                    {

                        SqlCommand checkemail = new SqlCommand("select * from Trainee where Email=@mail or UserName=@Usrnam ", Program.dbconnection);
                        checkemail.Parameters.AddWithValue("@mail", register.getEmail());
                        checkemail.Parameters.AddWithValue("@Usrnam", register.getUserName());
                        SqlDataReader EmailData = checkemail.ExecuteReader();

                        if (EmailData.HasRows == false)
                        {
                            EmailData.Close();
                            SqlCommand NewRegister = new SqlCommand("insert into Trainee values( @Username, @Password, @Email, @Gender, @Age, @Phone, @firstName, @LastName,@ID,@qua)", Program.dbconnection);
                            NewRegister.Parameters.AddWithValue("Username", register.getUserName());
                            NewRegister.Parameters.AddWithValue("Password", register3_pass.Text);
                            NewRegister.Parameters.AddWithValue("Email", register.getEmail());
                            NewRegister.Parameters.AddWithValue("Gender", register2.GetGender());
                            NewRegister.Parameters.AddWithValue("Age", "12");
                            NewRegister.Parameters.AddWithValue("Phone", register.getNumber());
                            NewRegister.Parameters.AddWithValue("FirstName", register.getFirstName());
                            NewRegister.Parameters.AddWithValue("LastName", register.getLastName());
                            NewRegister.Parameters.AddWithValue("ID", register.getId());
                            NewRegister.Parameters.AddWithValue("qua", register2.GetQualf());
                            NewRegister.ExecuteNonQuery();
                            MessageBox.Show("succesful register");
                        }
                        else
                        {
                            EmailData.Close();
                            MessageBox.Show("Email or username exist");

                        }


                    }
                }
                else
                {
                    MessageBox.Show("password fields must match");
                }

            }
            else
            {
                MessageBox.Show("Please Fill all of Your info ");
            }

        }

        private void register3_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void register3_Load(object sender, EventArgs e)
        {

        }
    }
}
