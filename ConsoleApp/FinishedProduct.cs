using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FinishedProduct : Products
    {
        public int productQuality;

        public int Get_product_quality()
        {
            return productQuality;

        }

        public void Set_product_quality(int value)
        {

            productQuality = value;

        }

        public FinishedProduct(string name)
        {
            Set_productName(name);

        }
    }
}
