using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace upcourse
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            adminCoursesList1.Visible = false;
            adminTrainee1.Visible = false;
            adminTrainers1.Visible = false;
            adminHome1.Visible = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        //home
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            adminCoursesList1.Visible = false;
            adminTrainee1.Visible = false;
            adminTrainers1.Visible = false;
            animationHoriz.ShowSync(adminHome1);
           


      


        }

        //allcourses
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            adminHome1.Visible = false;
            adminTrainee1.Visible = false;
            adminTrainers1.Visible = false;
            animationHoriz.ShowSync(adminCoursesList1);

     
        }

        //trainers
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            adminHome1.Visible = false;
            adminTrainee1.Visible = false;
            adminCoursesList1.Visible = false;
            animationHoriz.ShowSync(adminTrainers1);

          
        }

        //trainee
        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            adminHome1.Visible = false;
            adminTrainers1.Visible = false;
            adminCoursesList1.Visible = false;
            animationHoriz.ShowSync(adminTrainee1);

            
        }
    }
}
