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

        private void register2_loginBtn_Click(object sender, EventArgs e)
        {
            register3 register3 = new register3();
            this.Controls.Add(register3);
            register3.BringToFront();
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
    }
}
