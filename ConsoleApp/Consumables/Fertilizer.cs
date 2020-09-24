using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    class Fertilizer : Consumable
    {
        public Fertilizer()
        {
            Uses = 5;   //ejemplo de los usos restantes del fertilizante (tiene 5 unidades de fertilizante con 1 uso c/u)
            buyPrice = 5000; //ejemplo coste
        }
        public void Use(Field field)   //AVAILABLE FOOD DE FIELD
        {
            field.GiveFood(20); //Supuesto de que aumenta el alimento en 20
        }
    }
}
