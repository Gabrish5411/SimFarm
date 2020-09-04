using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tiles
{
    public class Tile
    {

        private int quality;
        private bool farmable;
        private string tileName;
        private int terrainNumber;


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

        
        public bool Get_farmable()
        {
            return farmable;
        }
        public void Set_farmable(bool value)
        {
            this.farmable = value;
        }


        public int Get_terrainNumber()
        {
            return this.terrainNumber;
        }
        public void Set_terrainNumber(int value)
        {
            this.terrainNumber = value;
        }

    }
}
