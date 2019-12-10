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
        static string Gender;
        static string qualf;
        static string CurrentPos;
        public register2()
        {
            InitializeComponent();
        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void register2_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public static string GetQualf()
        {
            return qualf;
        }
        public static string GetGender()
        {
            return Gender;
        }
        public static string GetCurrentPos()
        {
            return CurrentPos;
        }
        private void register2_loginBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(register2_qual.Text)==false&&((register2_female.Checked || register2_male.Checked)&&(register_RB_trainee.Checked|| register_RB_trainer.Checked)))
            {
                
                if (register2_female.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "Male";
                }
                if (register_RB_trainee.Checked)
                {
                    CurrentPos = "Trainee";
                }
                else
                {
                    CurrentPos = "Trainer";
                }
                qualf = register2_qual.Text;
                register3 register3 = new register3();
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
