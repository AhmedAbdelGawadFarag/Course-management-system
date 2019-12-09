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
    
    public partial class register3 : UserControl
    {
        public register3()
        {
            InitializeComponent();

        }
        public register3(string firstName, string lastName, string userName, string email, string number, string iD,string MorF,string Qual,string CurrentPos)
        {
            InitializeComponent();
            
            System.Console.WriteLine(firstName) ;
            System.Console.WriteLine(lastName);
            System.Console.WriteLine(userName);
            System.Console.WriteLine(email);
            System.Console.WriteLine(number);
            System.Console.WriteLine(iD);
            System.Console.WriteLine(MorF);
            System.Console.WriteLine(Qual);
            System.Console.WriteLine(CurrentPos);







        }
        private void register3_signup_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(register3_pass.Text) == false&& string.IsNullOrEmpty(register3_rePass.Text) == false&&register3_terms.Checked)
            {
               


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
    }
}
