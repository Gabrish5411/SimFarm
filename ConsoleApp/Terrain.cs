using System;
using System.Collections;
using ConsoleApp.Buildings;
namespace ConsoleApp
{
    public class Terrain
    {
        private bool bought;
        public int earthNumber;
        private Building building;

        public Terrain()
        {
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
    }
}
