using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Buildings
{
    class Storage : Building
    {
        protected int capacity;
        protected int currentCapacity;
        protected string currentProduct;
        List<FinishedProduct> finished_products;
        public Storage()
        {
            currentCapacity = 0;
            currentProduct = "Empty";
            capacity = 10;
            finished_products = new List<FinishedProduct>(capacity);
            this.sellPrice = 1000;
            Set_type("strg");
        }

        public void Update_Storage()
        {
            foreach (FinishedProduct prod in finished_products)
            {
                int quality = prod.Get_product_quality();
                prod.Update_product_quality();
            }
            
        }
        public void Set_finished(FinishedProduct finishedProduct)
        {
            //this.finished_product = finishedProduct;
        }

        public void ReportStorageStatus()
        {
            Console.WriteLine("Product: "+this.currentProduct);
            Console.WriteLine("Capacity: "+this.currentCapacity+"/"+capacity);
        }

        public bool AddProduct(FinishedProduct prod)
        {
            if (currentCapacity == 0)
            {
                currentProduct = prod.Get_productName();
            }
            if (currentCapacity < capacity)
            {
                finished_products.Add(prod);
                currentCapacity += 1;
                return true;
            }
            else {
                return false;
            }
        }
        public void SellProducts(Game game)
        {
            currentProduct = "Empty";
            currentCapacity = 0;
            int price = (currentCapacity == 0 ? 0 : finished_products[0].Get_sellPrice());
            game.Current_money += price*currentCapacity;
        }
    }

}
