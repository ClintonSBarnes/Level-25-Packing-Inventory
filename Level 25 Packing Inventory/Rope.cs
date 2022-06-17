using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Rope : InventoryItems
    {
        public int ropeCount;
        public Rope() : base(1f, 1.5f)
        {
        }
    }
}
