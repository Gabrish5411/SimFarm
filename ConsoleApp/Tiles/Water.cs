using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tiles
{
    [Serializable]
    class Water : Tile
    {
        public Water()
        {
            Set_farmable(false);
        }
    }
}
