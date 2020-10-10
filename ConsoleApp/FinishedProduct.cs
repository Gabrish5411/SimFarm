using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products;

namespace ConsoleApp
{
    class FinishedProduct : Product
    {
        public int productQuality;

        public FinishedProduct(string name)
        {
            this.productName = name;
            this.productQuality = 100;
        }

        public int Get_product_quality()
        {
            return productQuality;
        }

        public void Update_product_quality()
        {
            this.productQuality -= 1;
        }

        
    }
}
