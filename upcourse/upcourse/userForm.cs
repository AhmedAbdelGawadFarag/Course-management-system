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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();

            panel9.Visible = false;
            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
        }

        private void userForm_Load(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
