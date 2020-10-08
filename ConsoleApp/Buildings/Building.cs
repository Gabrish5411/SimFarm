using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products;

namespace ConsoleApp.Buildings
{
    public class Building
    {
        public string name;
        private string type;
        protected int tNumber;
        public int buyPrice;
        public int sellPrice;
        protected Product item;

        
        public Product Get_product()
        {
            return item;
        }
        public void Set_type(string tipo)
        {
            this.type = tipo;
        }
        public string Get_type()
        {
            return type;
        }
    }
}
