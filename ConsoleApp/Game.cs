using ConsoleApp.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Game
    {
        public int current_turn;
        private int current_money;
        public Random randNum = new Random();
        public List<int> thirtyList_tomato;
        public List<int> thirtyList_potato;
        public List<int> thirtyList_rice;

        public Game()
        {
            current_turn = 1;
            current_money = 50000;
            
        }
        //******************************************
        public int Current_money
        {
            get { return current_money; }
            set { current_money = value; }
        }
        //******************************************
        public int Price()//Aca la idea es que se establezcan los precios y que vaya cambiando segun el codigo de abajo
        {
            Product product = new Product();
            product.Set_sellPrice(randNum.Next(1000,4000)); // puse 3000 como ejemplo, hay que definir como vamos a establecer los precios de los productos
            return product.Get_sellPrice();

        }

        public void UpdateGame(List<int> seed_list) //Aqui actualizamos los precios y el current_money
        {
            Product product = new Product();
            double startingPrice = product.sellPrice;
            product.Set_sellPrice(3000);
            seed_list.Add(product.Get_sellPrice());
            Seed seed = new Seed();
            int price_var = seed.priceVariation;


            if (current_turn == 1)
            {
                while (seed_list.Count < 30)
                {
                    if (startingPrice * 0.5 < product.sellPrice && product.sellPrice < startingPrice * 1.5)
                    {
                        int random = randNum.Next(0, 2);
                        if (random == 0) //decrece el precio de venta
                        {
                            product.sellPrice -= price_var;
                        }
                        else if (random == 1) //aumenta el precio de venta
                        {
                            product.sellPrice += price_var;
                        }
                    }
                    else
                    {
                        break;
                    }
                    seed_list.Add(product.sellPrice);
                }
            }
            else
            {
                while (seed_list.Count == 30)
                {
                    if (startingPrice * 0.5 < product.sellPrice && product.sellPrice < startingPrice * 1.5)
                    {
                        int random = randNum.Next(0, 2);
                        if (random == 0) //decrece el precio de venta
                        {
                            product.sellPrice -= price_var;
                        }
                        else if (random == 1) //aumenta el precio de venta
                        {
                            product.sellPrice += price_var;
                        }
                        seed_list.Add(product.sellPrice);
                        seed_list.RemoveAt(0);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            current_turn += 1;
        }
    }
}
