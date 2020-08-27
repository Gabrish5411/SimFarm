using System;
using System.Collections;
namespace ConsoleApp
{
    class Terrain
    {
        private string tNumber;
        private bool bought;
        public Terrain(string i)
        {
            bought = false;
            this.tNumber = i;
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
