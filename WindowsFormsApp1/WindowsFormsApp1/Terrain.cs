using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Buildings;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Terrain
    {
        private bool bought;
        private double basePrice;
        public double terrainQuality;
        public double earthNumber;
        private Building building;

        public Terrain()
        {
            basePrice = 48000;
            terrainQuality = 0;
            earthNumber = 100;
            bought = false;

        }

        public void Set_bought(bool value)
        {
            bought = value;
        }
        public bool Get_bought()
        {
            return bought;
        }

        public void Set_Building(Building item)
        {
            building = item;
        }

        public Building Get_Building()
        {
            return building;
        }
        public int Get_terrain_price()
        {
            return Convert.ToInt32(basePrice * terrainQuality * (earthNumber / 100));
        }
    }
}
