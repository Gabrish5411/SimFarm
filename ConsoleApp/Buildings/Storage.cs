using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Buildings
{
    class Storage : Building
    {
        protected int capacity;
        FinishedProduct finished_product;
        public Storage(Terrain[] terrains)
        {
            this.buyPrice = 10000;
            capacity = 10;
        }

        public void Update_Storage()
        {
            int quality = finished_product.Get_product_quality();
            finished_product.Set_product_quality(quality -1);
        }
        public void Set_finished(FinishedProduct finishedProduct)
        {
            this.finished_product = finishedProduct;
        }

    }

}
