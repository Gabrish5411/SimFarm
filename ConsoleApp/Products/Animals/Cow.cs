using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products.Animals
{
    [Serializable]
    class Cow : Animal
    {
        public Cow()
        {
            Set("Cow", 20, 2000, 0.2F, 0.1F);
        }
    }
}
