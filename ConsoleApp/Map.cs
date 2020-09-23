using System;
using ConsoleApp.Tiles;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Map 
    {
        public Terrain[] terrains = new Terrain[100];
        public Tile[,] map = new Tile[100, 100];
        private Random randNum = new Random(); //para poner el argumento del random para Tile

        public Map()
        {

            for (int i = 0; i < 100; i++)
            {
                terrains[i] = new Terrain();
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    map[i, j] = new Earth(randNum);
                }
            }
            //Console.WriteLine("Mapa generado con exito.");



            //Console.Write("Ingrese 1 para agregar rios, 2 para lagos, 3 para ambos y 0 para ninguno:  ");
            //int water_input = Convert.ToInt32(Console.ReadLine());      //usuario elige

            Console.Write("Select a type of map: \n");
            List<string> map_options = new List<string>(new string[] { "Normal", "River", "Lake", "Both" });
            int water_input;
            water_input = MenuManager.PrintMenu(map_options);
            

            switch (water_input)
            {
                default:                                     //cuando el usuario no quiere ni rio ni lago
                    break;

                case 1:                                     //cuando el usuario quiere solo rio
                    int direction = randNum.Next(0, 2);     //define si rio es horizontal o vertical 0=h 1=v
                    if (direction == 0)
                    {
                        int row = randNum.Next(0, 85);
                        //int row = 85;
                        for (int i = row; i < row + 5; i++)
                        {
                            for (int j = 0; j < 100; j++)
                            {
                                map[i, j] = new Water();
                                map[i, j].Set_tile_Name("R");             
                                
                            }
                        }
                    }
                    else if (direction == 1)
                    {
                        int column = randNum.Next(0, 85);
                        //int column = 85;
                        for (int j = column; j < column + 5; j++)
                        {
                            for (int i = 0; i < 100; i++)
                            {
                                map[i, j] = new Water();
                                map[i, j].Set_tile_Name("R");             
                                
                            }
                        }
                    }
                    break;

                case 2:                                     //cuando el usuario quiere solo lago                           
                    int row1 = randNum.Next(1, 84);
                    int column1 = randNum.Next(1, 84);
                    for (int i = row1; i < row1 + 15; i++)
                    {
                        for (int j = column1; j < column1 + 15; j++)
                        {
                            int bordes = randNum.Next(0, 2);  //"los bloques en su perímetro pueden ser agua o tierra de manera aleatoria(así se evita que sea un bloque cuadrado)"
                            map[i, j] = new Water();
                            map[i, j].Set_tile_Name("L");              
                            
                            if (i == row1)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i - 1, j] = new Water();
                                    map[i - 1, j].Set_tile_Name("L");
                                    
                                }
                            }
                            else if (row1 < i & i < row1 + 14 & j == column1)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i, j - 1] = new Water();
                                    map[i, j - 1].Set_tile_Name("L");
                                    
                                }
                            }
                            else if (row1 < i & i < row1 + 14 & j == column1 + 14)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i, j + 1] = new Water();
                                    map[i, j + 1].Set_tile_Name("L");
                                }
                            }
                            else if (i == row1 + 14)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i + 1, j] = new Water();
                                    map[i + 1, j].Set_tile_Name("L");
                                }
                            }
                        }
                    }
                    break;

                case 3:                                     //cuando el usuario quiere rio y lago
                    int direction1 = randNum.Next(0, 2);     //define si rio es horizontal o vertical 0=h 1=v
                    if (direction1 == 0)
                    {
                        int row = randNum.Next(0, 85);
                        for (int i = row; i < row + 5; i++)
                        {
                            for (int j = 0; j < 100; j++)
                            {
                                map[i, j] = new Water();
                                map[i, j].Set_tile_Name("R");
                            }
                        }
                    }
                    else if (direction1 == 1)
                    {
                        int column = randNum.Next(0, 85);
                        for (int j = column; j < column + 5; j++)
                        {
                            for (int i = 0; i < 100; i++)
                            {
                                map[i, j] = new Water();
                                map[i, j].Set_tile_Name("R");
                            }
                        }
                    }                                       //fin rio
                    int row2 = randNum.Next(1, 83);
                    int column2 = randNum.Next(1, 83);
                    for (int i = row2; i < row2 + 15; i++)
                    {
                        for (int j = column2; j < column2 + 15; j++)
                        {
                            int bordes = randNum.Next(0, 2);  //"los bloques en su perímetro pueden ser agua o tierra de manera aleatoria(así se evita que sea un bloque cuadrado)"
                            map[i, j] = new Water();
                            map[i, j].Set_tile_Name("L");
                            if (i == row2)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i - 1, j] = new Water();
                                    map[i - 1, j].Set_tile_Name("L");
                                }
                            }
                            else if (row2 < i & i < row2 + 14 & j == column2)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i, j - 1] = new Water();
                                    map[i, j - 1].Set_tile_Name("L");    //Corregido la sintaxis asociando map a esta clase

                                }
                            }
                            else if (row2 < i & i < row2 + 14 & j == column2 + 14)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i, j + 1] = new Water();
                                    map[i, j + 1].Set_tile_Name("L");    //Corregido la sintaxis asociando map a esta clase
                                    
                                }
                            }
                            else if (i == row2 + 14)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i + 1, j] = new Water();
                                    map[i + 1, j].Set_tile_Name("L");    //Corregido la sintaxis asociando map a esta clase
                                }
                            }
                        }
                    }

                    break;

            }

            // aca comienza la creacion de la granja de dimensiones 3x2

            int row_1 = 10 * randNum.Next(1, 7);
            int column_1 = 10 * randNum.Next(1, 8); // en caso de que la granja se enuentre fuera de limites, no se podra continuar.

            
            for (int i = row_1; i < row_1 + 29; i++)
            {
                for (int j = column_1; j < column_1 + 20; j++)
                {
                    int bordes = randNum.Next(0, 1);
                    map[i, j].Set_tile_Name("G");
                    if (i == row_1)
                    {
                        if (bordes != 0)
                        {
                            break;
                        }
                        else if (bordes != 1)
                        {
                            map[i - 1, j].Set_tile_Name("G");
                        }
                    }
                }
            }
            // finaliza creacion de granja

            /*
            //Loop para asignar a que terreno corresponden las casillas
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    map[i, j].Set_terrainNumber(((j / 10) + 1 * (i / 10) + 1) + (j / 10) * 9);
                    //map[i, j].terrainNumber = Convert.ToString(((i/10)+1 * (j /10)+1) + (i/10)*9 );
                }
            }

            foreach(Tile casilla in map)
            {
                if (casilla.Get_tileName() == "G")
                {
                    terrains[casilla.Get_terrainNumber()].Set_bought(true);
                }
            }
            */

            //Loop para contar el numero de tierras en un terreno
            foreach (Tile casilla in map)
            {
                if (!casilla.Get_farmable())
                {
                    terrains[casilla.Get_terrainNumber()].earthNumber -= 1;
                }
                
            }



        }
        
    }
}
