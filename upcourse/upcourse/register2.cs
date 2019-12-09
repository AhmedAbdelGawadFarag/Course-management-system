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
    public partial class register2 : UserControl
    {
        string FirstName, LastName, UserName, Email, Number, ID;
        public register2()
        {
            InitializeComponent();
        }
        public register2(string firstName,string lastName,string userName,string email,string number,string iD)
        {
            InitializeComponent();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Email = email;
            this.Number = number;
            this.ID = iD;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void register2_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void register2_loginBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(register2_qual.Text)==false&&((register2_female.Checked || register2_male.Checked)&&(register_RB_trainee.Checked|| register_RB_trainer.Checked)))
            {
                string Mof;
                if (register2_female.Checked)
                {
                    Mof = "Female";
                }
                else
                {
                    Mof = "Male";
                }
                string qual=register2_qual.Text;
                string currentpos;
                if (register_RB_trainee.Checked)
                {
                    currentpos = "trainee";
                }
                else
                {
                    currentpos = "trainer";
                }
                register3 register3 = new register3(FirstName,LastName,UserName,Email,Number,ID,Mof,qual,currentpos);
                this.Controls.Add(register3);
                register3.BringToFront();
            }
            else
            {
                MessageBox.Show("Please Fill all of Your info ");
            }
        }

        private void register2_currentPos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void register2_Load(object sender, EventArgs e)
        {

        }

        private void register2_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
