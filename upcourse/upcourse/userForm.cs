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
    public partial class userForm : Form
    {
        public int userID;
        public userForm()
        {
            InitializeComponent();

            userFormHome1.Visible = true;
            user_acc1.Visible = false;
            panel9.Visible = false;
            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));



            getCoursesDB();

            this.CoursesLayoutPanel.BackColor = Color.Red;
        

            this.userFormHome1.Controls.Add(CoursesLayoutPanel);
            CoursesLayoutPanel.BringToFront();
            this.user_acc1.getUserData(mainscreen.GetUserID());
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
            animationLeaf.ShowSync(panel9);
            animationHoriz.HideSync(userFormHome1);
            animationHoriz.HideSync(user_acc1);


            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animationLeaf.HideSync(panel9);
            animationHoriz.HideSync(user_acc1);

            animationHoriz.ShowSync(userFormHome1);



            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            animationHoriz.HideSync(userFormHome1);

            animationLeaf.HideSync(panel9);
            animationHoriz.ShowSync(user_acc1);


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

        private void userFormHome1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        public static void registerCourseButtonClick(object sender, EventArgs e)
        {
          //  CoursePanel p = (CoursePanel)sender;
           // int courseId = p.getCourseId();
            //MessageBox.Show(courseId.ToString());
        }

        private void getCoursesDB()
        {
            SqlCommand Courses = new SqlCommand("select * from course", Program.dbconnection);
          SqlDataReader data= Courses.ExecuteReader();
            while (data.Read())
            {
                CoursePanel pnl = new CoursePanel(data.GetInt32(0), data.GetString(3), data.GetString(5));
                this.CoursesLayoutPanel.Controls.Add(pnl);
            }
            data.Close();
        }


    }
}
