﻿using System;
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
    public partial class adminHome : UserControl
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            adminFormAddCourse uf = new adminFormAddCourse();
            uf.ShowDialog();
        }
    }
}
