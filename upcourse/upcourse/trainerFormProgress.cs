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
    public partial class trainerFormProgress : UserControl
    {
        public trainerFormProgress()
        {
            InitializeComponent();
        }

        public void newProgressPanel(int id,int courseId,string traineeName, int progress, bool certificated)
        {
            TrainerProgressPanel pnl = new TrainerProgressPanel(id,courseId,traineeName, progress, certificated);

            this.progressFlowPanel.Controls.Add(pnl);
 
        }
    }

}
