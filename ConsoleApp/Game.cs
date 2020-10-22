using ConsoleApp.Products;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products.Seeds;
using ConsoleApp.Buildings;
using System.Security.Cryptography;

namespace ConsoleApp
{
    [Serializable]
    public class Game
    {
        public Map Map;
        public int current_turn;
        public static Random randNum = new Random();
        private int random;
        private int change;
        public Queue<int> thirtyList_tomato;
        public Queue<int> thirtyList_potato;
        public Queue<int> thirtyList_rice;
        private Player player;

        public Game()
        {
            player = new Player();
            current_turn = 1;
            thirtyList_tomato = new Queue<int>();
            thirtyList_potato = new Queue<int>();
            thirtyList_rice = new Queue<int>();
            
            for (int i = 1; i<30; i++)
            {
                Add_Element(thirtyList_tomato, player.tomato);
                Add_Element(thirtyList_potato, player.potato);
                Add_Element(thirtyList_rice, player.rice);
            }
           
        }
        public Player GetPlayer()
        {
            return this.player;
        }

        public void UpdateGame() //Aqui actualizamos las listas de precios.
        {
            Update_Seed(thirtyList_tomato, player.tomato);
            Update_Seed(thirtyList_potato, player.potato);
            Update_Seed(thirtyList_rice, player.rice);

            foreach (Terrain terrain in Map.terrains)
            {
                terrain.Get_Building().Update();
            }

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
