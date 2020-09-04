using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tiles
{
    class Earth : Tile
    {
        public Earth(Random randNum)
        {
            Set_farmable(true);
            Set_quality(randNum.Next(1, 100));
            Set_tile_Name("T");
        }
    }
}
