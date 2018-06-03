using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator_professions
{
    public class vertical_progressBar: ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int PBS_VERTICAL = 0x04;

                CreateParams cp = base.CreateParams;
                cp.Style |= PBS_VERTICAL;
                return cp;
            }
        }
    }
}
