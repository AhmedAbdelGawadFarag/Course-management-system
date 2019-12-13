using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upcourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            register1.Hide();
            register21.Hide();
            register31.Hide();
          
        }

        private void mainForm_exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register31_Load(object sender, EventArgs e)
        {

        }

        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userForm uf = new userForm();
            uf.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            adminForm af = new adminForm();
            af.ShowDialog();
        }
    }
}
