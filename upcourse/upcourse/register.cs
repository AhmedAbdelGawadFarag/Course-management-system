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
    public partial class register : UserControl
    {
        static string FirstName, LastName, UserName, Email, Number, ID;
        public register()
        {
            InitializeComponent();
           
        }

        private void register_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public static string getFirstName()
        {
            return FirstName;
        }
        public static string getLastName()
        {
            return LastName;
        }
        public static string getUserName()
        {
            return UserName;
        }
        public static string getEmail()
        {
            return Email;
        }
        public static string getNumber()
        {
            return Number;
        }
       public static string getId()
        {
            return ID;
        }

        private void register_nextBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(register_firstName.Text) == false && string.IsNullOrEmpty(register_lastName.Text) == false &&
                string.IsNullOrEmpty(register_username.Text) == false && string.IsNullOrEmpty(register_email.Text) == false &&
                string.IsNullOrEmpty(register_email.Text) == false && string.IsNullOrEmpty(register_id.Text) == false)
            {
                FirstName = register_firstName.Text;
                LastName = register_lastName.Text;
                UserName = register_username.Text;
                Email = register_email.Text;
                Number = register_number.Text;
                ID=register_id.Text; 
               
                register2 register2 = new register2();
                this.Controls.Add(register2);
                register2.BringToFront();
            }
            else
            {
                MessageBox.Show("Please Fill all of Your info ");
            }
        }
    }
}
