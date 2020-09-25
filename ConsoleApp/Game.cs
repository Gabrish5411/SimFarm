using ConsoleApp.Products;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products.Seeds;

namespace ConsoleApp
{
    class Game
    {
        public int current_turn;
        private int current_money;
        public static Random randNum = new Random();
        private int random;
        private int change;
        public Queue<int> thirtyList_tomato;
        public Queue<int> thirtyList_potato;
        public Queue<int> thirtyList_rice;
        public Seed tomato;
        public Seed potato;
        public Seed rice;

        public Game()
        {
            current_turn = 1;
            current_money = 50000;
            thirtyList_tomato = new Queue<int>();
            thirtyList_potato = new Queue<int>();
            thirtyList_rice = new Queue<int>();
            tomato = new Tomato();
            potato = new Potato();
            rice = new Rice();
            
            for (int i = 1; i<30; i++)
            {
                Add_Element(thirtyList_tomato, tomato);
                Add_Element(thirtyList_potato, potato);
                Add_Element(thirtyList_rice, rice);
                
            }
           
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

        private void Update_Seed(Queue<int> seed_list, Seed seed)
        {
            seed_list.Dequeue();
            Add_Element(seed_list, seed);
            
        }
        private void Add_Element(Queue<int> seed_list, Seed seed)
        {
            if (seed.Get_sellPrice() * 0.5 < seed.Get_price() && seed.Get_price() < seed.Get_sellPrice() * 1.5)
            {
                random = GetRandomNumber(0, 1);
                if (random == 0) //decrece el precio de venta
                {
                    change = seed.Change_Price(seed.Get_variation(), true);
                    seed_list.Enqueue(change);
                }
                else if (random == 1) //aumenta el precio de venta
                {
                    change = seed.Change_Price(seed.Get_variation(), true);
                    seed_list.Enqueue(change);
                }
            }
            else
            {
                seed.Reset_Price();
                seed_list.Enqueue(seed.Get_sellPrice());
            }

        }

        public static int GetRandomNumber(int min, int max)
        {
            lock (randNum)
            {
                return randNum.Next(min, max);
            }
        }
    }
}
