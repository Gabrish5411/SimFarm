using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Products;

namespace WindowsFormsApp1.Buildings
{
    [Serializable]
    public abstract class Building
    {
        public string name;
        private string type;
        protected int tNumber;
        public int buyPrice;
        public int sellPrice;
        public int value;
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
        public void Set_sell(int value)
        {
            this.value = value;
        }
        public int Get_sell()
        {
            return value;
        }
        public abstract void Update();
        public abstract List<string> Report();
    }
}
