using System;

namespace ConsoleApp
{
    class Map
    {

        private Terrain[] terrains = new Terrain[100];
        public Tile[,] map = new Tile[100, 100];
        private Random randNum = new Random(); //para poner el argumento del random para Tile

        public Map()
        {

            for (int i = 0; i < 100; i++)
            {
                terrains[i] = new Terrain(Convert.ToString(i));
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    map[i, j] = new Tile(randNum);
                }
            }
            Console.WriteLine("Mapa generado con exito.");
            
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    map[i, j].terrainNumber = Convert.ToString(((i/10)+1 * (j /10)+1) + (i/10)*9 );
                }
            }

            Console.Write("Ingrese 1 para agregar rios, 2 para lagos, 3 para ambos y 0 para ninguno:  ");


            int water_input = Convert.ToInt32(Console.ReadLine());      //usuario elige
            switch (water_input)
            {
                default:                                     //cuando el usuario no quiere ni rio ni lago
                    break;

                case 1:                                     //cuando el usuario quiere solo rio
                    int direction = randNum.Next(0, 1);     //define si rio es horizontal o vertical 0=h 1=v
                    if (direction == 0)
                    {
                        int row = randNum.Next(0, 95);
                        for (int i = row; i < row + 5; i++)
                        {
                            for (int j = 0; j < 100; j++)
                            {
                                map[i, j].tileName = "R";             //Corregido la sintaxis asociando map a esta clase
                                map[i, j].quality = 0;
                            }
                        }
                    }
                    else if (direction == 1)
                    {
                        int column = randNum.Next(0, 95);
                        for (int j = column; j < column + 5; j++)
                        {
                            for (int i = 0; i < 100; i++)
                            {
                                map[i, j].tileName = "R";             //Corregido la sintaxis asociando map a esta clase
                                map[i, j].quality = 0;
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
                            map[i, j].tileName = "L";                //Corregido la sintaxis asociando map a esta clase
                            map[i, j].quality = 0;
                            if (i == row1)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i - 1, j].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i - 1, j].quality = 0;
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
                                    map[i, j - 1].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i, j - 1].quality = 0;
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
                                    map[i, j + 1].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i, j + j].quality = 0;
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
                                    map[i + 1, j].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i + 1, j].quality = 0;
                                }
                            }
                        }
                    }
                    break;

                case 3:                                     //cuando el usuario quiere rio y lago
                    int direction1 = randNum.Next(0, 1);     //define si rio es horizontal o vertical 0=h 1=v
                    if (direction1 == 0)
                    {
                        int row = randNum.Next(0, 95);
                        for (int i = row; i < row + 5; i++)
                        {
                            for (int j = 0; j < 100; j++)
                            {
                                map[i, j].tileName = "R";             //Corregido la sintaxis asociando map a esta clase
                                map[i, j].quality = 0;
                            }
                        }
                    }
                    else if (direction1 == 1)
                    {
                        int column = randNum.Next(0, 95);
                        for (int j = column; j < column + 5; j++)
                        {
                            for (int i = 0; i < 100; i++)
                            {
                                map[i, j].tileName = "R";             //Corregido la sintaxis asociando map a esta clase
                                map[i, j].quality = 0;
                            }
                        }
                    }                                       //fin rio
                    int row2 = randNum.Next(1, 84);
                    int column2 = randNum.Next(1, 84);
                    for (int i = row2; i < row2 + 15; i++)
                    {
                        for (int j = column2; j < column2 + 15; j++)
                        {
                            int bordes = randNum.Next(0, 2);  //"los bloques en su perímetro pueden ser agua o tierra de manera aleatoria(así se evita que sea un bloque cuadrado)"
                            map[i, j].tileName = "L";                //Corregido la sintaxis asociando map a esta clase
                            map[i, j].quality = 0;
                            if (i == row2)
                            {
                                if (bordes == 0)
                                {
                                    continue;
                                }
                                else if (bordes == 1)
                                {
                                    map[i - 1, j].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i - 1, j].quality = 0;
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
                                    map[i, j - 1].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i, j - 1].quality = 0;
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
                                    map[i, j + 1].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i, j + 1].quality = 0;
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
                                    map[i + 1, j].tileName = "L";    //Corregido la sintaxis asociando map a esta clase
                                    map[i + 1, j].quality = 0;
                                }
                            }
                        }
                    }

                    break;

            }





        }
        public void ShowMap1()
        {
            //for(int F = 0; F < 100; F += 10)
            //{
            //for (int z = 0; z < 10; z++)
            //{
            //for (int i = 0; i < 10; i++)
            //{
            //for (int j = 0; j < 10; j++)
            //{
            //Console.Write(cells[i+F].cell[z, j].tileName);
            //}
            //}
            //Console.Write("\n");
            //}
            //}
            for (int k = 0; k < 100; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    Console.Write(map[k, l].tileName);
                    //Console.Write(map[k, l].quality);
                }
                Console.Write("\n");
            }



        }
    }
}
