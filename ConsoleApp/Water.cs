using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Water
    {
        private Random randNum = new Random();
        public Water()
        {
            int water_input = Convert.ToInt32(Console.ReadLine());      //usuario elige
            switch (water_input)
            {
                case 0:                                     //cuando el usuario no quiere ni rio ni lago
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
                                map[i, j] = "R";             //CORREGIR arreglar sintaxis, asociar el mapa con esta clase
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
                                map[i, j] = "R";             //CORREGIR arreglar sintaxis, asociar el mapa con esta clase
                            }
                        }
                    }
                    break;

                case 2:                                     //cuando el usuario quiere solo lago                           
                    int row1 = randNum.Next(1, 84);
                    int column1 = randNum.Next(1, 84);
                    for (int i = row1; i < row1 + 15; i++)
                    {
                        for (int j = column1; j < column1 +15; j++)
                        {
                            int bordes = randNum.Next(0, 1);  //"los bloques en su perímetro pueden ser agua o tierra de manera aleatoria(así se evita que sea un bloque cuadrado)"
                            map[i, j] = "L";                //CORREGIR arreglar sintaxis, asociar el mapa con esta clase
                            if (i == row1)
                            {
                                if (bordes == 0)
                                {
                                    break;
                                }
                                else if (bordes == 1)
                                {
                                    map[i - 1, j] = "L";    //CORREGIR
                                }                            
                            }
                            else if (row1 < i & i < row1 + 14 & j == column1)   
                            {
                                if (bordes == 0)
                                {
                                    break;
                                }
                                else if (bordes == 1)
                                {
                                    map[i, j-1] = "L";    //CORREGIR
                                }
                            }
                            else if (row1 < i & i < row1 + 14 & j == column1 + 14)
                            {
                                if (bordes == 0)
                                {
                                    break;
                                }
                                else if (bordes == 1)
                                {
                                    map[i, j + 1] = "L";    //CORREGIR
                                }
                            }
                            else if (i == row1 + 14)
                            {
                                if (bordes == 0)
                                {
                                    break;
                                }
                                else if (bordes == 1)
                                {
                                    map[i + 1, j] = "L";    //CORREGIR
                                }
                            }
                        }
                    }
                    break;          

                case 3:                                     //cuando el usuario quiere rio y lago
                    
                    break;
            }
        }
    }
}
