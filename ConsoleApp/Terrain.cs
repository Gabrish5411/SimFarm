using System;
using System.Collections;
namespace ConsoleApp
{
    public class Terrain
    {
        private bool bought;
        public int earthNumber;

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
    }
}
