using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Food : InventoryItems
    {
        public int foodCount;
        public Food() : base(1f, .5f)
        {
        }
    }
}
