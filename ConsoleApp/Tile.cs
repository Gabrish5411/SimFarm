using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Tile
    {

        private int quality;
        public bool farmable;
        private string tileName;
        public string terrainNumber;


        public string Get_tileName()
        {
            return tileName;
        }
        public void Set_tile_Name(string name)
        {
            tileName = name;
        }
        public int Get_quality()
        {
            return quality;
        }
        public void Set_quality(int quality)
        {
            this.quality = quality;
        }
    }
}
