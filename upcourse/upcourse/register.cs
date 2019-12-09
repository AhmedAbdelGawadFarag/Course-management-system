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
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
           
        }

        private void register_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void register_nextBtn_Click(object sender, EventArgs e)
        {
            register2 register2 = new register2();
            this.Controls.Add(register2);
            register2.BringToFront();
        }
    }
}
