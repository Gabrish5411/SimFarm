using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    class Consumable
    {
        protected int Uses;
        protected int buyPrice;   
        /*
        public int Uses1
        {
            get { return Uses; }
            set { Uses = value; }
        }
        */
        public void AddUse()
        {
            this.Uses += 1;
        }
        public int GetBuyPrice()
        {
            return this.buyPrice;
        }
        public int GetUses()
        {
            return Uses;
        }
    }
    
}
