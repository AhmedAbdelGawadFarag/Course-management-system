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
    public partial class trainerForm : Form
    {
        public trainerForm()
        {
            InitializeComponent();

            trainerFormHome1.Visible = true;
            trainerFormProgress1.Visible = false;
            trainerFormSearch1.Visible = false;
            trainerFormCertificates1.Visible = false;
            trainerFormCourses1.Visible = false;

        }

        private void trainerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePnl.Top = btnHome.Top;
            sidePnl.Height = btnHome.Height;

            trainerFormCourses1.Visible = false;
            trainerFormProgress1.Visible = false;
            trainerFormSearch1.Visible = false;
            trainerFormCertificates1.Visible = false;
            animationHoriz.ShowSync(trainerFormHome1);
            

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            sidePnl.Top = btnCourse.Top;
            sidePnl.Height = btnCourse.Height;
trainerFormHome1.Visible = false;
            trainerFormProgress1.Visible = false;
            trainerFormSearch1.Visible = false;
            trainerFormCertificates1.Visible = false;
            animationHoriz.ShowSync(trainerFormCourses1);
            
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            sidePnl.Top = btnProgress.Top;
            sidePnl.Height = btnProgress.Height;

            animationHoriz.ShowSync(trainerFormProgress1);
            animationHoriz.HideSync(trainerFormCourses1);
            animationHoriz.HideSync(trainerFormHome1);
            animationHoriz.HideSync(trainerFormCertificates1);
            animationHoriz.HideSync(trainerFormSearch1);
        }

        private void btnCertificates_Click(object sender, EventArgs e)
        {
            sidePnl.Top = btnCertificates.Top;
            sidePnl.Height = btnCertificates.Height;

            animationHoriz.ShowSync(trainerFormCertificates1);
            animationHoriz.HideSync(trainerFormCourses1);
            animationHoriz.HideSync(trainerFormProgress1);
            animationHoriz.HideSync(trainerFormHome1);
            animationHoriz.HideSync(trainerFormSearch1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sidePnl.Top = btnSearch.Top;
            sidePnl.Height = btnSearch.Height;

            animationHoriz.ShowSync(trainerFormSearch1);
            animationHoriz.HideSync(trainerFormCourses1);
            animationHoriz.HideSync(trainerFormProgress1);
            animationHoriz.HideSync(trainerFormCertificates1);
            animationHoriz.HideSync(trainerFormHome1);
        }
    }
}
