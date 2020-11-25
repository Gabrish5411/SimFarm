using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Buildings;

namespace WindowsFormsApp1.CustomEventArgs
{
    public class BuildingArgs : EventArgs
    {
        public Building building { get; set; }
    }
}
