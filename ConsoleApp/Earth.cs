﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Earth : Tile
    {
        public Earth(Random randNum)
        {
            farmable = true;
            Set_quality(randNum.Next(1, 100));
            Set_tile_Name("T");
        }
    }
}
