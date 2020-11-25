using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Products.Animals
{
    [Serializable]
    class Sheep : Animal
    {
        public Sheep()
        {
            Set("Obeja", 20, 2000, 0.2F, 0.1F);
        }
    }
}
