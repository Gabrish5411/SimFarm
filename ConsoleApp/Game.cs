using ConsoleApp.Products;
using System;
using System.Collections;
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
        public Queue thirtyList_tomato;
        public Queue thirtyList_potato;
        public Queue thirtyList_rice;
        public Seed tomato;
        public Seed potato;
        public Seed rice;

        public Game()
        {
            current_turn = 1;
            current_money = 50000;
            tomato = new Seed();
            potato = new Seed();
            rice = new Seed();

        }
        //******************************************
        public int Current_money
        {
            get { return current_money; }
            set { current_money = value; }
        }
        //******************************************
        /*
        public int Price()//Aca la idea es que se establezcan los precios y que vaya cambiando segun el codigo de abajo
        {
            Product product = new Product();
            product.Set_sellPrice(randNum.Next(1000,4000)); // puse 3000 como ejemplo, hay que definir como vamos a establecer los precios de los productos
            return product.Get_sellPrice();

        }
        */

        public void UpdateGame() //Aqui actualizamos las listas de precios.
        {
            Update_Seed(thirtyList_tomato, tomato);
            Update_Seed(thirtyList_potato, potato);
            Update_Seed(thirtyList_rice, rice);

            current_turn += 1;
        }

        private void Update_Seed(Queue seed_list, Seed seed)
        {
            if (seed_list.Count > 30)
            {
                Add_Element(seed_list, seed);
            }
            else
            {
                seed_list.Dequeue();
                Add_Element(seed_list, seed);
            }
        }
        private void Add_Element(Queue seed_list, Seed seed)
        {
            if (seed.Get_sellPrice() * 0.5 < seed.Get_price() && seed.Get_price() < seed.Get_sellPrice() * 1.5)
            {
                int random = randNum.Next(0, 2);
                if (random == 0) //decrece el precio de venta
                {
                    seed.Change_Price(seed.Get_variation() * -1);
                    seed_list.Enqueue(seed.Get_sellPrice() + seed.Get_variation() * current_turn);
                }
                else if (random == 1) //aumenta el precio de venta
                {
                    seed.Change_Price(seed.Get_variation());
                    seed_list.Enqueue(seed.Get_sellPrice() + seed.Get_variation() * current_turn);
                }
            }
            else
            {
                seed.Change_Price(seed.Get_sellPrice());
                seed_list.Enqueue(seed.Get_sellPrice() + seed.Get_variation() * current_turn);
            }

        }
    }
}
