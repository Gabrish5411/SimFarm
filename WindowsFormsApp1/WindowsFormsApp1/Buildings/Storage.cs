using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Buildings
{
    [Serializable]
    public class Storage : Building
    {
        protected int capacity;
        protected int currentCapacity;
        protected string currentProduct;
        List<FinishedProduct> finished_products;
        public Storage()
        {
            currentCapacity = 0;
            currentProduct = "Vacio";
            capacity = 10;
            finished_products = new List<FinishedProduct>(capacity);
            this.sellPrice = 1000;
            Set_type("strg");
        }

        public override void Update()
        {
            foreach (FinishedProduct prod in finished_products)
            {
                //int quality = prod.Get_product_quality();
                prod.Update_product_quality();
            }
        }
        public void Set_finished(FinishedProduct finishedProduct)
        {
            //this.finished_product = finishedProduct;
        }

        public override List<string> Report()
        {
            List<string> result = new List<string>();
            result.Add("Producto almacenado: "+this.currentProduct);
            result.Add("Capacidad: "+this.currentCapacity+"/"+capacity);
            return result;
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
            game.GetPlayer().Current_money += price*currentCapacity;
            this.finished_products.Clear();
        }
        public string GetCurrentProduct()
        {
            return currentProduct;
        }
        public bool IsFull()
        {
            return capacity == currentCapacity ? true : false;
        }
        public List<FinishedProduct> GetFinished()
        {
            return finished_products;
        }
    }

}
