using ConsoleApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Game
    {
        private int current_turn;
        private int current_money;
        private Random randNum = new Random();

        public Game()
        {
            current_turn = 1;
            current_money = 50000;
        }

        public void UpdateGame() //Aqui actualizamos los precios y el current_money
        {
            List<int> thirtyList = new List<int>();
            Product product = new Product();
            double startingPrice = product.sellPrice;
            while (current_turn < 30)
            {
                if (startingPrice * 0.5 < product.sellPrice && product.sellPrice < startingPrice * 1.5)
                {
                    int random = randNum.Next(0, 2);
                    if (random == 0) //decrece el precio de venta
                    {
                        product.sellPrice -= 50;
                    }
                    else if (random == 1) //aumenta el precio de venta
                    {
                        product.sellPrice += 50;
                    }
                }
                else
                {
                    break;
                }
                thirtyList.Add(product.sellPrice);
            }
            while (current_turn > 30)
            {
                if (startingPrice * 0.5 < product.sellPrice && product.sellPrice < startingPrice * 1.5)
                {
                    int random = randNum.Next(0, 2);
                    if (random == 0) //decrece el precio de venta
                    {
                        product.sellPrice -= 50;
                    }
                    else if (random == 1) //aumenta el precio de venta
                    {
                        product.sellPrice += 50;
                    }
                }
                else
                {
                    break;
                }
                thirtyList.Add(product.sellPrice);
                thirtyList.RemoveAt(0);
            }           
            current_turn += 1;
        }
    }
}
