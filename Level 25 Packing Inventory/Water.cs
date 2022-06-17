using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Water : InventoryItems
    {
        public int waterCount;

        public Water() : base(2f, 3f)
        {
        }
    }
}
