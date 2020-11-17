using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CustomEventArgs
{
    public class PrintMapArgs : EventArgs
    {
        public Game game { get; set; }
    }
}
