using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorMonitoringDashBoard
{
    internal class VerticalProgressbar : ProgressBar
    {
    
        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams orientation = base.CreateParams;
                orientation.Style |= 0x04;
                return orientation;

            }
        }





    }
}
