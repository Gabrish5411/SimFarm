using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Products.Animals
{
    [Serializable]
    class Pig : Animal
    {
        public Pig()
        {
            Set("Pig", 20, 2000, 0.2F, 0.1F);
        }
    }
}
