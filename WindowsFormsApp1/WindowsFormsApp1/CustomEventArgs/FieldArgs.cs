using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Buildings;

namespace WindowsFormsApp1.CustomEventArgs
{
    class FieldArgs : EventArgs
    {
        public Field field { get; set; }
    }
}
